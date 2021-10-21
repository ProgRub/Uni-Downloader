using System.Collections;
using System.Collections.Generic;
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
			var allDirectories=Directory.GetDirectories(UniToBaseDirectory,"*",SearchOption.AllDirectories);
			return allDirectories.Where(dir =>
				dir.Count(x => x == Path.DirectorySeparatorChar) - uniBaseDirectoryPathSeparatorCount <= 3);
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