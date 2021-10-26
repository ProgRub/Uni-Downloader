using System.Collections.Generic;
using Business.DTOs;
using Business.Services;

namespace Business.Commands
{
	public class CommandAddFileFormat:ICommand
	{
		private readonly ISet<FileFormatDTO> _fileFormats;
		public CommandAddFileFormat(ISet<FileFormatDTO> fileFormats)
		{
			_fileFormats = fileFormats;
		}

		public void Execute() => FileFormatService.Instance.MarkFileFormatsToAdd(_fileFormats);

		public void Undo() => FileFormatService.Instance.UnMarkFileFormatsToAdd(_fileFormats);

		public void Redo() => Execute();
	}
}