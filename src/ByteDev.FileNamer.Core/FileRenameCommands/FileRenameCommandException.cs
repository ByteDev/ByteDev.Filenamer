using System;

namespace ByteDev.FileNamer.Core.FileRenameCommands
{
	public class FileRenameCommandException : Exception
	{
	    public FileRenameCommand Command { get; private set; }

	    public FileRenameCommandException(string message, Exception innerException, FileRenameCommand command) : base(message, innerException)
		{
			Command = command;
		}

		public FileRenameCommandException(string message, Exception innerException) : base(message, innerException)
		{
		}

		public FileRenameCommandException(string message) : base(message)
		{
		}

		public FileRenameCommandException(string message, FileRenameCommand command) : this(message, null, command)
		{
		}

		public FileRenameCommandException()
		{
		}
	}
}
