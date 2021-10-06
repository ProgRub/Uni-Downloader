using System.Collections.Generic;
using System.Linq;
using Business.DTOs;
using DB;
using DB.Entities;
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

		internal ISet<FileFormatDTO> NewFileFormats = new HashSet<FileFormatDTO>();

		internal ISet<FileFormatDTO> DeletedFileFormats = new HashSet<FileFormatDTO>();

		internal IEnumerable<FileFormatDTO> GetFileFormats()
		{
			return _fileFormatRepository.GetAll().Select(FileFormatDTO.ConvertFileFormatToDTO).ToHashSet();
		}

		internal void SaveChanges()
		{
			foreach (var fileFormat in NewFileFormats)
			{
				_fileFormatRepository.Add(new UniFileFormat
					{Extension = fileFormat.FileExtension, Description = fileFormat.Description});
			}

			foreach (var deletedFileFormat in DeletedFileFormats)
			{
				_fileFormatRepository.Remove(_fileFormatRepository.GetAll()
					.First(e => e.Extension == deletedFileFormat.FileExtension));
			}

			_fileFormatRepository.SaveChanges();
		}
	}
}