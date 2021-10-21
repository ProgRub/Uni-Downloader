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
using Forms.Commands;

namespace Forms
{
	public partial class OptionsScreen : BaseControl
	{
		private IList<FileFormatDTO> _fileFormats;
		public OptionsScreen()
		{
			InitializeComponent();
		}

		private void OptionsScreen_Enter(object sender, EventArgs e)
		{
			CommandsManager.Instance.Notify += (_, _) => { ButtonUndo.Enabled = CommandsManager.Instance.HasUndo;};
			CommandsManager.Instance.Notify += (_, _) => { ButtonRedo.Enabled = CommandsManager.Instance.HasRedo;};
			_fileFormats=BusinessFacade.Instance.GetAllFileFormats().ToList();
			foreach (var fileFormat in _fileFormats)
			{
				ListBoxFileFormats.Items.Add(fileFormat.FileExtension);
			}
		}

		private void ListBoxFileFormats_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedFileFormat = GetSelectedListBoxFileFormat();
			TextBoxFileFormat.Text = selectedFileFormat.FileExtension;
			TextBoxDescription.Text = selectedFileFormat.Description;
		}

		private FileFormatDTO GetSelectedListBoxFileFormat()
		{
			if (ListBoxFileFormats.SelectedIndex == -1) return null;
			return _fileFormats.First(e =>
				e.FileExtension == ListBoxFileFormats.Items[ListBoxFileFormats.SelectedIndex].ToString());
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
			if (GetSelectedListBoxFileFormat()!=null&&TextBoxFileFormat.Text == GetSelectedListBoxFileFormat().FileExtension)
			{
				macroCommand.Add(new CommandChangeFileFormat(GetSelectedListBoxFileFormat(),TextBoxFileFormat.Text,TextBoxDescription.Text,ref _fileFormats));
				macroCommand.Add(new CommandRenameSelectedListBoxItem(TextBoxFileFormat.Text,ListBoxFileFormats));
			}
			else
			{
				macroCommand.Add(new CommandAddFileFormat(new HashSet<FileFormatDTO>{new() {FileExtension = TextBoxFileFormat.Text,Description = TextBoxDescription.Text}}));
				macroCommand.Add(new CommandAddItemToListBox(TextBoxFileFormat.Text,ListBoxFileFormats));
			}
			CommandsManager.Instance.Execute(macroCommand);
		}

		private void ListBoxFileFormats_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Delete) return;
			var macroCommand = new MacroCommand();
			macroCommand.Add(new CommandDeleteSelectedListBoxItems(ListBoxFileFormats));
			macroCommand.Add(new CommandDeleteFileFormat(new HashSet<FileFormatDTO>{GetSelectedListBoxFileFormat()}));
			CommandsManager.Instance.Execute(macroCommand);
		}
	}
}
