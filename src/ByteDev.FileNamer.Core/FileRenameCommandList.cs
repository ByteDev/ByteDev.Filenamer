using System;
using System.Collections;
using System.Collections.Generic;
using ByteDev.FileNamer.Core.FileRenameCommands;

namespace ByteDev.FileNamer.Core
{
    /// <summary>
    /// Class represents a collection of FileNameCommands
    /// </summary>
	public class FileRenameCommandList : IEnumerable<FileRenameCommand>
	{
		private IList<FileRenameCommand> _commands;

		private IList<FileRenameCommand> Commands
		{
			get { return _commands ?? (_commands = new List<FileRenameCommand>()); }
		}

		public FileRenameCommand this[int index]
		{
			get { return Commands[index]; }
			set { Commands[index] = value; }
		}

		public int Count
		{
			get { return Commands.Count; }
		}

		public void Add(FileRenameCommand op)
		{
			Commands.Add(op);
		}

		public void Fill()
		{
			Clear();
			Commands.Add(new RemoveSearchTextCommand());
			Commands.Add(new RemovePositionTextCommand());
			Commands.Add(new ReplaceCharSpaceCommand(Char.Parse("-")));
			Commands.Add(new ReplaceCharSpaceCommand(Char.Parse("_")));
			Commands.Add(new ReplaceStringCommand());
			Commands.Add(new CaseToLowerCommand());
			Commands.Add(new CaseToUpperCommand());
			Commands.Add(new CaseToCapitalCommand());
			Commands.Add(new InsertStringCommand());
			Commands.Add(new CutCopyPasteCommand());
			Commands.Add(new RenameToGuidCommand());
            Commands.Add(new ExtensionCaseToLowerCommand());
		}

		public void Clear()
		{
			Commands.Clear();
		}

		public IEnumerator<FileRenameCommand> GetEnumerator()
		{
			return Commands.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}