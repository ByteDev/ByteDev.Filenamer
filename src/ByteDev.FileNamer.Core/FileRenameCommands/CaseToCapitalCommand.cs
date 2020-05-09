using System;

namespace ByteDev.FileNamer.Core.FileRenameCommands
{
    /// <summary>
    /// File name/Suffix to capital
    /// </summary>
    [Serializable]
    public class CaseToCapitalCommand : FileRenameCommand
    {
        public override void Execute(string fileName)
        {
            try
            {
                var fileNameWithoutExtension = GetFileNameWithoutExtension(fileName);

                fileNameWithoutExtension = fileNameWithoutExtension.ToCapitalCase();

                SetResult(fileNameWithoutExtension + GetFileNameExtension(fileName));
            }
            catch (Exception ex)
            {
                throw new FileRenameCommandException("CaseToCapital failed to execute properly", ex, this);
            }
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
