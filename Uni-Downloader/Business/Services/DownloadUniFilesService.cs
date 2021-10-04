using DB;

namespace Business.Services
{
	public class DownloadUniFilesService
	{

		private DownloadUniFilesService()
		{
		}
		public static DownloadUniFilesService Instance { get; } = new();
	}
}