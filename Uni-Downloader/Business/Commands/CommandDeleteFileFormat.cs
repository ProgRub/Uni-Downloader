using System.Collections.Generic;
using Business.DTOs;
using Business.Services;

namespace Business.Commands
{
	public class CommandDeleteFileFormat:ICommand
	{
		private readonly ISet<FileFormatDTO> _fileFormats;
		public CommandDeleteFileFormat(ISet<FileFormatDTO> fileFormats)
		{
			_fileFormats = fileFormats;
		}

		public void Execute() => FileFormatService.Instance.MarkFileFormatsToDelete(_fileFormats);

		public void Undo() => FileFormatService.Instance.UnMarkFileFormatsToDelete(_fileFormats);

		public void Redo() => Execute();
		
	}
}