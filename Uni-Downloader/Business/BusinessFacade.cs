using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Business.Services;

namespace Business
{
	public class BusinessFacade
	{
		private BusinessFacade()
		{
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

		public void LoadDatabase()=>DirectoriesService.Instance.SaveChanges();
	}
}