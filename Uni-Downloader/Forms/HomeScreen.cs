using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace Forms
{
	public partial class HomeScreen : BaseControl
	{
		private string _baseUniDirectory;
		private string _downloadsDirectory;

		public HomeScreen()
		{
			InitializeComponent();
		}

		private void ButtonDownloadUniFiles_Click(object sender, EventArgs e)
		{
			MoveToScreen(new DownloadScreen(), this);
		}

		private void ButtonOptions_Click(object sender, EventArgs e)
		{
			MoveToScreen(new OptionsScreen(), this);
		}

		private void ButtonOpenDirectory_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog.Description = "Pick the base folder where you're gonna store all the files";
			var dialogResult = FolderBrowserDialog.ShowDialog();

			if (dialogResult != DialogResult.OK || string.IsNullOrWhiteSpace(FolderBrowserDialog.SelectedPath)) return;
			_baseUniDirectory = FolderBrowserDialog.SelectedPath;
			TextBoxBaseUniDirectory.Text = _baseUniDirectory;
			BusinessFacade.Instance.SetBaseUniversityDirectory(_baseUniDirectory);
		}

		private void ButtonOpenDownloadsDirectory_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog.Description = "Pick the folder where the files are downloaded to";
			var dialogResult = FolderBrowserDialog.ShowDialog();

			if (dialogResult != DialogResult.OK || string.IsNullOrWhiteSpace(FolderBrowserDialog.SelectedPath)) return;
			_downloadsDirectory = FolderBrowserDialog.SelectedPath;
			TextBoxDownloadsDirectory.Text = _downloadsDirectory;
			BusinessFacade.Instance.SetDownloadsDirectory(_downloadsDirectory);
		}

		private void HomeScreen_Enter(object sender, EventArgs e)
		{
			_baseUniDirectory = BusinessFacade.Instance.GetBaseUniversityDirectory();
			_downloadsDirectory = BusinessFacade.Instance.GetDownloadsDirectory();
			TextBoxBaseUniDirectory.Text = _baseUniDirectory;
			TextBoxDownloadsDirectory.Text = _downloadsDirectory;
			((UniDownloader)Parent).MinimumSize = MinimumSize;
		}
	}
}