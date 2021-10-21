using System;
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

		private ISet<FileFormatDTO> _newFileFormats = new HashSet<FileFormatDTO>();

		private ISet<FileFormatDTO> _deletedFileFormats = new HashSet<FileFormatDTO>();

		internal void MarkFileFormatsToDelete(ISet<FileFormatDTO> fileFormats)
		{
			foreach (var song in fileFormats)
			{
				_deletedFileFormats.Add(song);
			}
		}

		internal void UnMarkFileFormatsToDelete(ISet<FileFormatDTO> fileFormats)
		{
			foreach (var song in fileFormats)
			{
				_deletedFileFormats.Remove(song);
			}
		}

		internal void MarkFileFormatsToAdd(ISet<FileFormatDTO> fileFormats)
		{
			foreach (var song in fileFormats)
			{
				_newFileFormats.Add(song);
			}
		}

		internal void UnMarkFileFormatsToAdd(ISet<FileFormatDTO> fileFormats)
		{
			foreach (var song in fileFormats)
			{
				_newFileFormats.Remove(song);
			}
		}

		internal IEnumerable<FileFormatDTO> GetFileFormats()
		{
			return _fileFormatRepository.GetAll().Select(FileFormatDTO.ConvertFileFormatToDTO).ToHashSet();
		}

		internal void SaveChanges()
		{
			foreach (var fileFormat in _newFileFormats)
			{
				_fileFormatRepository.Add(new UniFileFormat
					{Extension = fileFormat.FileExtension, Description = fileFormat.Description});
			}

			foreach (var deletedFileFormat in _deletedFileFormats)
			{
				_fileFormatRepository.Remove(_fileFormatRepository.GetAll()
					.First(e => e.Extension == deletedFileFormat.FileExtension));
			}

			_fileFormatRepository.SaveChanges();
		}

		public UniFileFormat GetFileFormatById(int id) => _fileFormatRepository.GetById(id);
	}
}