﻿using System.Windows.Forms;
using Business.Commands;

namespace Forms.Commands
{
	public class CommandRenameSelectedListBoxItem : ICommand
	{
		private readonly string _newText;
		private readonly string _oldText;
		private readonly ListBox _listBox;
		private readonly int _itemIndex;

		public CommandRenameSelectedListBoxItem(string newText, ListBox listBox)
		{
			_listBox = listBox;
			_itemIndex = _listBox.SelectedIndex;
			_oldText = _listBox.Items[_itemIndex].ToString();
			_newText = newText;
		}

		public void Execute()  {
			_listBox.Items[_itemIndex] = _newText;
			_listBox.SelectedIndex = _itemIndex;
		}

		public void Undo() {
			_listBox.Items[_itemIndex] = _oldText;
			_listBox.SelectedIndex = _itemIndex;
		}

		public void Redo() => Execute();
	}
}