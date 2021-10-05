using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Timers;
using Business.CustomEventArgs;
using Business.Enums;
using DB;
using Microsoft.VisualBasic.FileIO;
using Timer = System.Timers.Timer;

namespace Business.Services
{
	public class DownloadUniFilesService
	{
		internal event EventHandler<NewFileEventArgs> NotifyNewDownloadedFile;
		internal event EventHandler<DirectoryCreatedArgs> NotifyNewDirectory;

		internal event EventHandler<FileMovedArgs> NotifyFileMoved;
		private Timer _timer;

		private DownloadUniFilesService()
		{
			CheckedFiles = new HashSet<string>();
			_timer = new Timer();
			_timer.Elapsed += CheckForNewUniFiles;
			_timer.Interval = 150;
		}

		public static DownloadUniFilesService Instance { get; } = new();

		internal ISet<string> CheckedFiles { get; }
		internal static SemaphoreSlim SemaphoreFileBeingChecked { get; } = new(1, 1);

		internal void StartTimer() => _timer.Start();
		internal void StopTimer() => _timer.Stop();

		internal void CheckForNewUniFiles(object source, ElapsedEventArgs e)
		{
			SemaphoreFileBeingChecked.Wait();
			var files = Directory.GetFiles(DirectoriesService.Instance.UniFromDirectory).Distinct();

			foreach (var filePath in files.Where(filePath =>
				!CheckedFiles.Contains(filePath)))
			{
				CheckedFiles.Add(filePath);
				NotifyNewDownloadedFile?.Invoke(this,
					new NewFileEventArgs {Filename = Path.GetFileName(filePath)});
				return;
			}
		}

		internal void MoveFile(string selectedDirectory, string newFilePath)
		{
			var destinationDirectory = Path.Join(DirectoriesService.Instance.UniToBaseDirectory,selectedDirectory);
			if (newFilePath.Contains(Path.DirectorySeparatorChar ))
				destinationDirectory = CreateDirectories(selectedDirectory, newFilePath);
			var newFilename = newFilePath.Split(Path.DirectorySeparatorChar ).Last();
			var destinationFilePath = Path.Join(destinationDirectory, newFilename);
			var condition = FileMovedCondition.NoProblem;
			if (File.Exists(destinationFilePath))
			{
				FileSystem.DeleteFile(destinationFilePath, UIOption.OnlyErrorDialogs,
					RecycleOption.SendToRecycleBin);
				condition = FileMovedCondition.Replaced;
			}

			File.Move(CheckedFiles.Last(), destinationFilePath);
			NotifyFileMoved?.Invoke(this,
				new FileMovedArgs() {FilePath = destinationFilePath, Condition = condition});
			SemaphoreFileBeingChecked.Release();
		}

		private string CreateDirectories(string selectedDirectory, string newFilePath)
		{
			var filePathSplit = newFilePath.Split(Path.DirectorySeparatorChar ).ToList();
			filePathSplit.Remove(filePathSplit.Last());
			var baseUniversityDirectory = DirectoriesService.Instance.UniToBaseDirectory;
			var currentDirectory = Path.Join(baseUniversityDirectory,selectedDirectory);
			foreach (var newDirectory in filePathSplit)
			{
				var directoryToCreate = Path.Join(currentDirectory, newDirectory);
				Directory.CreateDirectory(directoryToCreate);
				NotifyNewDirectory?.Invoke(this,new DirectoryCreatedArgs(){Directory = directoryToCreate.Replace(baseUniversityDirectory, "").Substring(1)});
				currentDirectory = directoryToCreate;
			}

			return currentDirectory;
		}
	}
}