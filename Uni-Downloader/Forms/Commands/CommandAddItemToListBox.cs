using System.Windows.Forms;
using Business.Commands;
using Business.DTOs;
using Business.Enums;

namespace Forms.Commands
{
	public class CommandAddItemToListBox : ICommand
	{
		private readonly string _item;
		private readonly ListBox _listBox;

		public CommandAddItemToListBox(string item, ListBox listBox)
		{
			_item = item;
			_listBox = listBox;
		}

		public void Execute()
		{
			_listBox.Items.Add(_item);
		}

		public void Undo()
		{
			_listBox.Items.Remove(_item);
		}

		public void Redo() => Execute();
	}
}