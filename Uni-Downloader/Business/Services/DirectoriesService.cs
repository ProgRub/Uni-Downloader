using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using DB;
using DB.Repositories.Implementations;
using DB.Repositories.Interfaces;

namespace Business.Services
{
	
	public class DirectoriesService
	{
		private readonly IDirectoriesRepository _directoriesRepository;

		private DirectoriesService(IDirectoriesRepository directoriesRepository)
		{
			_directoriesRepository = directoriesRepository;
			var allDirectories = _directoriesRepository.GetById(1);
			UniToBaseDirectory = allDirectories.UniToBaseDirectory;
			UniFromDirectory = allDirectories.UniFrom;
		}
		
		internal string UniFromDirectory { get; set; }
		internal string UniToBaseDirectory { get; set; }
		public static DirectoriesService Instance { get; } = new(new DirectoriesRepository(Database.GetContext()));

		internal IEnumerable<string> GetChildrenDirectoriesOfBaseUniDirectory()
		{
			var uniBaseDirectoryPathSeparatorCount = UniToBaseDirectory.Count(x=>x==Path.DirectorySeparatorChar);
			var allDirectories = new List<string>();
			var maxDirectoryDepth = 3;
			foreach (var baseDirectory in Directory.GetDirectories(UniToBaseDirectory))
			{
				var directoryDepth = 1;
				allDirectories.Add(baseDirectory);
				GetChildrenDirectories(directoryDepth++, maxDirectoryDepth,ref allDirectories);
			}

			return allDirectories;
		}

		internal IEnumerable<string> GetChildrenDirectories(int currentDepth, int maxDepth,ref List<string> directories)
		{
			if (currentDepth >= maxDepth) return directories;
			foreach (var directory in Directory.GetDirectories(directories.Last()))
			{
				directories.Add(directory);
				GetChildrenDirectories(++currentDepth, maxDepth, ref directories);
			}

			return directories;
		}

		internal void SaveChanges()
		{
			var directories = _directoriesRepository.GetById(1);
			directories.UniToBaseDirectory = UniToBaseDirectory;
			directories.UniFrom = UniFromDirectory;
			_directoriesRepository.SaveChanges();
		}
	}
}