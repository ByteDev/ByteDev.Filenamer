using System;

namespace ByteDev.FileNamer.Core.FileRenameCommands
{
    /// <summary>
    /// Replace: set string for another string
    /// </summary>
    [Serializable]
    public class ReplaceStringCommand : FileRenameCommand
    {
        public string FindText { get; set; }
        public string ReplacementText { get; set; }

        public ReplaceStringCommand(string findText, string replacementText)
        {
            FindText = findText;
            ReplacementText = replacementText;
        }

        public ReplaceStringCommand() : this(string.Empty, string.Empty)
        {
        }

        public override void Execute(string fileName)
        {
            var fileNameWithoutExten = GetFileNameWithoutExtension(fileName);

			if(string.IsNullOrEmpty(FindText))
			{
				SetResult(fileNameWithoutExten + GetFileNameExtension(fileName));
				return;
			}

            fileNameWithoutExten = fileNameWithoutExten.Replace(FindText, ReplacementText);

            SetResult(fileNameWithoutExten + GetFileNameExtension(fileName));
        }

        public override string ToString()
        {
        	if ((FindText == string.Empty) && (ReplacementText == string.Empty))
            {
                return GetDisplayName();
            }
        	return GetDisplayName() + " { " + FindText + ", " + ReplacementText + " }";
        }

        private string GetDisplayName()
        {
            return GetType().Name.Replace("Command", string.Empty);
        }
    }
}
