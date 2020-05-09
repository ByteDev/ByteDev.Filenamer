using System;

namespace ByteDev.FileNamer.Core.FileRenameCommands
{
    [Serializable]
	public class RenameToGuidCommand : FileRenameCommand
	{
		public override void Execute(string fileName)
		{
			var newFileName = Guid.NewGuid().ToString().Replace("-", string.Empty);

            SetResult(newFileName + GetFileNameExtension(fileName));
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
