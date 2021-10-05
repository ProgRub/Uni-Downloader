using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Timers;
using Business.CustomEventArgs;
using Business.Enums;
using DB;
using Microsoft.VisualBasic.FileIO;

namespace Business.Services
{
	public class DownloadUniFilesService
	{
		internal event EventHandler<NewFileEventArgs> NotifyNewDownloadedFile;

		internal event EventHandler<FileMovedArgs> NotifyFileMoved;
		private DownloadUniFilesService()
		{
			CheckedFiles = new HashSet<string>();
		}

		public static DownloadUniFilesService Instance { get; } = new();

		internal ISet<string> CheckedFiles { get; }
		internal static SemaphoreSlim SemaphoreFileBeingChecked { get; } = new(0, 1);

		internal void CheckForNewUniFiles(object source, ElapsedEventArgs e)
		{
			var files = Directory.GetFiles(DirectoriesService.Instance.UniFromDirectory).Distinct();

			foreach (var filePath in files.Where(filePath =>
				!CheckedFiles.Contains(filePath)))
			{
				CheckedFiles.Add(filePath);
				NotifyNewDownloadedFile?.Invoke(this,
					new NewFileEventArgs {Filename = Path.GetFileName(filePath)});
				SemaphoreFileBeingChecked.Wait();
			}
		}

		internal void MoveFile(string selectedDirectory, string newFilePath)
		{
			var destinationDirectory = selectedDirectory;
			if (newFilePath.Contains(Path.PathSeparator))
				destinationDirectory=CreateDirectories(selectedDirectory,newFilePath);
			var newFilename = newFilePath.Split(Path.PathSeparator).Last();
			var shortDestinationFilePath = Path.Join(destinationDirectory,newFilename);
			var fullDestinationFilePath = Path.Join(DirectoriesService.Instance.UniToBaseDirectory,shortDestinationFilePath);
			var condition = FileMovedCondition.NoProblem;
			if (File.Exists(fullDestinationFilePath))
			{
				FileSystem.DeleteFile(fullDestinationFilePath, UIOption.OnlyErrorDialogs,
					RecycleOption.SendToRecycleBin);
				condition = FileMovedCondition.Replaced;
			}
			File.Move(CheckedFiles.Last(),fullDestinationFilePath);
			NotifyFileMoved?.Invoke(this,
				new FileMovedArgs() {FilePath = shortDestinationFilePath,Condition = condition});
			SemaphoreFileBeingChecked.Release();
		}

		private string CreateDirectories(string selectedDirectory, string newFilePath)
		{
			var filePathSplit = newFilePath.Split(Path.PathSeparator).ToList();
			filePathSplit.Remove(filePathSplit.Last());
			var currentDirectory = selectedDirectory;
			foreach (var newDirectory in filePathSplit)
			{
				var directoryToCreate = Path.Join(currentDirectory, newDirectory);
				Directory.CreateDirectory(directoryToCreate);
				currentDirectory = directoryToCreate;
			}

			return currentDirectory;
		}
	}
}