using DB.Entities;

namespace Business.DTOs
{
	public class FileFormatDTO
	{
		public int Id { get; set; }
		public string FileExtension { get; set; }
		public string Description { get; set; }

		internal static FileFormatDTO ConvertFileFormatToDTO(UniFileFormat uniFileFormat)
		{
			return new FileFormatDTO()
			{
				Id = uniFileFormat.Id, FileExtension = uniFileFormat.Extension, Description = uniFileFormat.Description
			};
		}
	}
}