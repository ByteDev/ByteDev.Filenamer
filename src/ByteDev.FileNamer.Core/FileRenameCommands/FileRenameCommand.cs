using System;
using System.IO;

namespace ByteDev.FileNamer.Core.FileRenameCommands
{
    [Serializable]
    public abstract class FileRenameCommand
    {
        public abstract void Execute(string fileName);

        public string Result { get; private set; }

        protected void SetResult(string newFileName)
        {
            Result = newFileName;
        }

        protected string GetFileNameWithoutExtension(string fileName)
        {
            fileName = Path.GetFileNameWithoutExtension(fileName);

            if (fileName == null)
            {
                throw new InvalidOperationException("FileName without extension is null");
            }
            return fileName;
        }

        protected string GetFileNameExtension(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                return string.Empty;
            }
            return Path.GetExtension(fileName);
        }
    }
}
