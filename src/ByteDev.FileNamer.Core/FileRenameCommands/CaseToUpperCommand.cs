using System;

namespace ByteDev.FileNamer.Core.FileRenameCommands
{
    /// <summary>
    /// Case: File name/Suffix ToUpper
    /// </summary>
    [Serializable]
    public class CaseToUpperCommand : FileRenameCommand
    {
        public override void Execute(string fileName)
        {
            try
            {
                var fileNameWithoutExten = GetFileNameWithoutExtension(fileName);

                fileNameWithoutExten = fileNameWithoutExten.ToUpper();
                
                SetResult(fileNameWithoutExten + GetFileNameExtension(fileName));
            }
            catch (Exception ex)
            {
                throw new FileRenameCommandException("CaseToUpper failed to execute properly", ex, this);
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
