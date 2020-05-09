using System;

namespace ByteDev.FileNamer.Core.FileRenameCommands
{
    public class FileRenameCommandValidationException : FileRenameCommandException
    {
        public FileRenameCommandValidationException()
        {
        }

        public FileRenameCommandValidationException(string message) : base(message)
        {
        }

        public FileRenameCommandValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}