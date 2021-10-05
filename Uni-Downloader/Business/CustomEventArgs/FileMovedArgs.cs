using System;
using Business.Enums;

namespace Business.CustomEventArgs
{
	public class FileMovedArgs : EventArgs
	{
		public string FilePath { get; set; }
		public FileMovedCondition Condition { get; set; }
	}
}