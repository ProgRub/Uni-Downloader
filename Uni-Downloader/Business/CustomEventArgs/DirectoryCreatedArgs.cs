using System;
using Business.Enums;

namespace Business.CustomEventArgs
{
	public class DirectoryCreatedArgs : EventArgs
	{
		public string Directory { get; set; }
	}
}