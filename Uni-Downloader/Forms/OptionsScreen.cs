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
using Business.Commands;
using Business.DTOs;

namespace Forms
{
	public partial class OptionsScreen : BaseControl
	{
		private ISet<FileFormatDTO> _fileFormats;
		public OptionsScreen()
		{
			InitializeComponent();
		}

		private void OptionsScreen_Enter(object sender, EventArgs e)
		{
			CommandsManager.Instance.Notify += (_, _) => { ButtonUndo.Enabled = CommandsManager.Instance.HasUndo;};
			CommandsManager.Instance.Notify += (_, _) => { ButtonRedo.Enabled = CommandsManager.Instance.HasRedo;};
			_fileFormats=BusinessFacade.Instance.GetAllFileFormats().ToHashSet();
			foreach (var fileFormat in _fileFormats)
			{
				ListBoxFileFormats.Items.Add(fileFormat.FileExtension);
			}
		}

		private void ListBoxFileFormats_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedFileFormat = _fileFormats.First(e =>
				e.FileExtension == ListBoxFileFormats.Items[ListBoxFileFormats.SelectedIndex].ToString());
			TextBoxFileFormat.Text = selectedFileFormat.FileExtension;
			TextBoxDescription.Text = selectedFileFormat.Description;
		}

		private void ButtonUndo_Click(object sender, EventArgs e)
		{
			CommandsManager.Instance.Undo();
		}

		private void ButtonRedo_Click(object sender, EventArgs e)
		{
			CommandsManager.Instance.Redo();
		}

		private void ButtonAddChangeFileFormat_Click(object sender, EventArgs e)
		{
			var macroCommand = new MacroCommand();

		}

		private void ListBoxFileFormats_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{

			}
		}
	}
}
