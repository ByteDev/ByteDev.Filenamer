using System;
using System.Globalization;

namespace ByteDev.FileNamer.Core.FileRenameCommands
{
    /// <summary>
    /// Replace given char for space
    /// </summary>
    [Serializable]
    public class ReplaceCharSpaceCommand : ReplaceStringCommand
    {
        public ReplaceCharSpaceCommand(char findChar) : base(findChar.ToString(CultureInfo.InvariantCulture), " ")
        {
        }

        public ReplaceCharSpaceCommand() : this(Char.Parse(string.Empty))
        {
        }

        public override string ToString()
        {
        	if (string.IsNullOrEmpty(FindText))
            {
                return GetDisplayName();
            }
        	return GetDisplayName() + " { " + FindText + " }";
        }

        private string GetDisplayName()
        {
            return GetType().Name.Replace("Command", string.Empty);
        }
    }
}
