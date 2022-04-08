using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Business.Enums;

namespace Forms
{
	public partial class DownloadScreen : BaseControl
	{
		private string _currentFile;

		public DownloadScreen()
		{
			InitializeComponent();
		}

		private void DownloadScreen_Enter(object sender, EventArgs e)
		{
			((UniDownloader)Parent).MinimumSize = MinimumSize;
			var baseUniversityDirectory = BusinessFacade.Instance.GetBaseUniversityDirectory();
			ComboBoxDirectories.Items.Add("");
			foreach (var subDirectory in BusinessFacade.Instance.GetUniSubDirectories())
			{
				ComboBoxDirectories.Items.Add(subDirectory.Replace(baseUniversityDirectory, "").Substring(1));
			}

			ComboBoxDirectories.Items.Add("Skip File");
			ComboBoxDirectories.Items.Add("Delete File");

			BusinessFacade.Instance.NotifyNewDownloadedFile += (_, args) =>
			{
				TextBoxOriginFilename.Invoke(
					new MethodInvoker(delegate
					{
						TextBoxOriginFilename.AppendText(args.Filename + Environment.NewLine);
					}));
				_currentFile = Path.Join(BusinessFacade.Instance.GetDownloadsDirectory(), args.Filename);
				TextBoxRenameFilename.Invoke(
					new MethodInvoker(delegate { TextBoxRenameFilename.Text = args.Filename.Replace(' ', '_').Replace("_-_", "-"); }));
			};
			BusinessFacade.Instance.NotifyFileMoved += (_, args) =>
			{
				TextBoxDestinationFilename.Invoke(
					new MethodInvoker(delegate
					{
						TextBoxDestinationFilename.AppendText(
							(args.Condition switch
							{
								FileMovedCondition.Replaced => args.FilePath.Replace(baseUniversityDirectory, "")
									.Substring(1) + " REPLACED",
								FileMovedCondition.Skipped => Path.GetFileName(args.FilePath) + " SKIPPED",
								FileMovedCondition.Deleted => Path.GetFileName(args.FilePath) + " DELETED",
								FileMovedCondition.NoProblem => args.FilePath.Replace(baseUniversityDirectory, "")
									.Substring(1),
								_ => ""
							}) + Environment.NewLine);
					}));
			};
			BusinessFacade.Instance.NotifyNewDirectory += (_, args) =>
			{
				ComboBoxDirectories.Invoke(
					new MethodInvoker(delegate
					{
						ComboBoxDirectories.Items.Insert(ComboBoxDirectories.Items.IndexOf("Skip File"),
							args.Directory);
					}));
			};
			SetFormAcceptButton(ButtonMoveFile);
			BusinessFacade.Instance.StartGettingNewFiles();
		}

		private void DownloadScreen_Leave(object sender, EventArgs e)
		{
			BusinessFacade.Instance.StopGettingNewFiles();
		}

		private void ButtonMoveFile_Click(object sender, EventArgs e)
		{
			if (ComboBoxDirectories.Text == "Skip File")
			{
				BusinessFacade.Instance.SkipFile(_currentFile);
				return;
			}

			if (ComboBoxDirectories.Text == "Delete File")
			{
				BusinessFacade.Instance.DeleteFile(_currentFile);
				return;
			}

			BusinessFacade.Instance.MoveFile(ComboBoxDirectories.Text, TextBoxRenameFilename.Text);
		}
	}
}