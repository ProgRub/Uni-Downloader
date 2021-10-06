using DB.Entities;

namespace Business.DTOs
{
	public class FileFormatDTO
	{
		public string FileExtension { get; set; }
		public string Description { get; set; }

		internal static FileFormatDTO ConvertFileFormatToDTO(UniFileFormat uniFileFormat)
		{
			return new FileFormatDTO()
				{FileExtension = uniFileFormat.Extension, Description = uniFileFormat.Description};
		}
	}
}