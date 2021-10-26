using System.Collections.Generic;
using System.Drawing;
using Business.DTOs;
using Business.Services;
using DB.Entities;

namespace Business.Commands
{
	public class CommandChangeFileFormat:ICommand
	{
		private readonly UniFileFormat _fileFormat;
		private readonly FileFormatDTO _fileFormatDto;
		private readonly string _oldExtension,_newExtension,_oldDescription,_newDescription;
		private readonly IList<FileFormatDTO> _fileFormats;
		public CommandChangeFileFormat(FileFormatDTO selectedFileFormat, string newExtension,  string newDescription,
			ref IList<FileFormatDTO> fileFormats)
		{
			_fileFormatDto = selectedFileFormat;
			_fileFormat = FileFormatService.Instance.GetFileFormatById(_fileFormatDto.Id);
			_oldExtension = _fileFormat.Extension;
			_oldDescription = _fileFormat.Description;
			_newExtension = newExtension;
			_newDescription = newDescription;
			_fileFormats = fileFormats;
		}
		public void Execute()
		{
			_fileFormat.Extension = _newExtension;
			_fileFormat.Description = _newDescription;
			_fileFormatDto.FileExtension = _newExtension;
			_fileFormatDto.Description = _newDescription;
			for (var index = 0; index < _fileFormats.Count; index++)
			{
				if (_fileFormats[index].Id == _fileFormatDto.Id) _fileFormats[index] = _fileFormatDto;
			}
		}

		public void Undo()
		{
			_fileFormat.Extension = _oldExtension;
			_fileFormat.Description = _oldDescription;
			_fileFormatDto.FileExtension = _oldExtension;
			_fileFormatDto.Description = _oldDescription;
			for (var index = 0; index < _fileFormats.Count; index++)
			{
				if (_fileFormats[index].Id == _fileFormatDto.Id) _fileFormats[index] = _fileFormatDto;
			}
		}

		public void Redo() => Execute();
	}
}