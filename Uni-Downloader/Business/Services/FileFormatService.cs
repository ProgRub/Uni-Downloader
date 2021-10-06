using System.Collections.Generic;
using System.Linq;
using Business.DTOs;
using DB;
using DB.Repositories.Implementations;
using DB.Repositories.Interfaces;

namespace Business.Services
{
	public class FileFormatService
	{
		private IUniFileFormatRepository _fileFormatRepository;
		
		private FileFormatService()
		{
			_fileFormatRepository = new UniFileFormatRepositoryRepository(Database.GetContext());
		}

		public static FileFormatService Instance { get; } = new();

		internal IEnumerable<FileFormatDTO> GetFileFormats()
		{
			return _fileFormatRepository.GetAll().Select(FileFormatDTO.ConvertFileFormatToDTO);
		}
	}
}