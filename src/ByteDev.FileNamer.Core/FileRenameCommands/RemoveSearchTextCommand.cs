using System;

namespace ByteDev.FileNamer.Core.FileRenameCommands
{
    /// <summary>
    /// Remove find selected text and remove
    /// </summary>
    [Serializable]
    public class RemoveSearchTextCommand : FileRenameCommand
    {
        public string SearchText { get; set; }

        public RemoveSearchTextCommand() : this(string.Empty)
        {
        }

        public RemoveSearchTextCommand(string searchText)
        {
            SearchText = searchText;
        }

        public override void Execute(string fileName)
        {
            var fileNameWithoutExten = GetFileNameWithoutExtension(fileName);

			if(string.IsNullOrEmpty(SearchText))
			{
				SetResult(fileName);
				return;
			}

			try
            {
                fileNameWithoutExten = fileNameWithoutExten.Replace(SearchText, string.Empty);
            }
            catch (Exception ex)
            {
                throw new FileRenameCommandException(ex.Message, ex);
            }

            SetResult(fileNameWithoutExten + GetFileNameExtension(fileName));
        }

        public override string ToString()
        {
        	if (SearchText == string.Empty)
        	{
        	    return GetDisplayName();
        	}
        	return GetDisplayName() + " { " + SearchText + " }";
        }

        private string GetDisplayName()
        {
            return GetType().Name.Replace("Command", string.Empty);
        }
    }
}
