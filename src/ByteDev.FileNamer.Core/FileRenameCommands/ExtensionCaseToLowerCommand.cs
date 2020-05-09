using System;
using System.IO;

namespace ByteDev.FileNamer.Core.FileRenameCommands
{
    [Serializable]
    public class ExtensionCaseToLowerCommand : FileRenameCommand
    {
        public override void Execute(string fileName)
        {
            try
            {
                var extension = Path.GetExtension(fileName);

                SetResult(GetFileNameWithoutExtension(fileName) + ExtensionToLower(extension));
            }
            catch (Exception ex)
            {
                throw new FileRenameCommandException("ExtensionCaseToLower failed to execute properly", ex, this);
            }
        }

        private static string ExtensionToLower(string extension)
        {
            if (string.IsNullOrEmpty(extension))
            {
                return string.Empty;
            }
            return extension.ToLower();
        }

        public override string ToString()
        {
            return GetDisplayName();
        }

        private string GetDisplayName()
        {
            return GetType().Name.Replace("Command", string.Empty);
        }
    }
}