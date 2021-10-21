using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Business.CustomEventArgs;
using Business.DTOs;
using Business.Enums;
using Business.Services;
using Microsoft.VisualBasic.FileIO;

namespace Business
{
	public class BusinessFacade
	{
		public event EventHandler<NewFileEventArgs> NotifyNewDownloadedFile;
		public event EventHandler<DirectoryCreatedArgs> NotifyNewDirectory;

		public event EventHandler<FileMovedArgs> NotifyFileMoved;

		private BusinessFacade()
		{
			DownloadUniFilesService.Instance.NotifyNewDownloadedFile +=
				(sender, args) => NotifyNewDownloadedFile.Invoke(sender, args);
			DownloadUniFilesService.Instance.NotifyFileMoved += (sender, args) => NotifyFileMoved.Invoke(sender, args);
			DownloadUniFilesService.Instance.NotifyNewDirectory += (sender, args) => NotifyNewDirectory.Invoke(sender, args);
		}

		public static BusinessFacade Instance { get; } = new();


		public string GetBaseUniversityDirectory() => DirectoriesService.Instance.UniToBaseDirectory;

		public string GetDownloadsDirectory() => DirectoriesService.Instance.UniFromDirectory;

		public void SetBaseUniversityDirectory(string baseUniDirectory) =>
			DirectoriesService.Instance.UniToBaseDirectory = baseUniDirectory;

		public void SetDownloadsDirectory(string downloadsDirectory) =>
			DirectoriesService.Instance.UniFromDirectory = downloadsDirectory;

		public void SaveChanges()
		{
			DirectoriesService.Instance.SaveChanges();
		}

		public void LoadDatabase() => DirectoriesService.Instance.SaveChanges();

		public void StartGettingNewFiles()  {
			DownloadUniFilesService.Instance.CheckedFiles.Clear();
			DownloadUniFilesService.Instance.StartTimer();
		}
		public void StopGettingNewFiles() => DownloadUniFilesService.Instance.StopTimer();

		public IEnumerable<string> GetUniSubDirectories() =>
			DirectoriesService.Instance.GetChildrenDirectoriesOfBaseUniDirectory();

		public void MoveFile(string selectedDirectory, string newFilename) => DownloadUniFilesService.Instance.MoveFile(selectedDirectory, newFilename);

		public void SkipFile(string filename)
		{
			DownloadUniFilesService.SemaphoreFileBeingChecked.Release();
			NotifyFileMoved?.Invoke(this,new FileMovedArgs{Condition = FileMovedCondition.Skipped,FilePath = filename});
		}

		public void DeleteFile(string filePath)
		{
			FileSystem.DeleteFile(filePath, UIOption.OnlyErrorDialogs,
				RecycleOption.SendToRecycleBin);
			DownloadUniFilesService.SemaphoreFileBeingChecked.Release();
		}

		public IEnumerable<FileFormatDTO> GetAllFileFormats()
		{
			return FileFormatService.Instance.GetFileFormats();
		}
	}
}