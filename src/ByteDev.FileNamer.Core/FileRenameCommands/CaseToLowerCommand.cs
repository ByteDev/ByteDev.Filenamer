using System;

namespace ByteDev.FileNamer.Core.FileRenameCommands
{
    /// <summary>
    /// Case: File name/Suffix ToLower
    /// </summary>
    [Serializable]
    public class CaseToLowerCommand : FileRenameCommand
    {
        public override void Execute(string fileName)
        {
            try
            {
                var fileNameWithoutExten = GetFileNameWithoutExtension(fileName);

                fileNameWithoutExten = fileNameWithoutExten.ToLower();
                
                SetResult(fileNameWithoutExten + GetFileNameExtension(fileName));
            }
            catch (Exception ex)
            {
                throw new FileRenameCommandException("CaseToLower failed to execute properly", ex, this);
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
