using System;

namespace ByteDev.FileNamer.Core.FileRenameCommands
{
    /// <summary>
    /// Insert string at set position
    /// </summary>
    [Serializable]
    public class InsertStringCommand : FileRenameCommand
    {
        public int Position { get; set; }
        public string StringToInsert { get; set; }

        public InsertStringCommand() : this(0, string.Empty)
        {
        }

        public InsertStringCommand(int position, string stringToInsert)
        {
            Position = position;
            StringToInsert = stringToInsert;
        }

        public override void Execute(string fileName)
        {
            try
            {
                var fileNameWithoutExten = GetFileNameWithoutExtension(fileName);

				if (Position < 0)											
				{
                    fileNameWithoutExten = StringToInsert + fileName;
				}
				else if (Position <= fileName.Length)
				{
                    fileNameWithoutExten = fileNameWithoutExten.Insert(Position, StringToInsert);
				}
				else
				{
                    fileNameWithoutExten = fileNameWithoutExten + StringToInsert;
				}

                SetResult(fileNameWithoutExten + GetFileNameExtension(fileName));
            }
            catch (Exception ex)
            {
                throw new FileRenameCommandException("Exception occured while executing InsertString operation", ex, this);
            }
        }

        public override string ToString()
        {
            if ((Position < 1) && (string.IsNullOrEmpty(StringToInsert)))
            {
                return GetDisplayName();
            }
			return GetDisplayName() + " { " + Position + ", " + StringToInsert + " }";
        }

        private string GetDisplayName()
        {
            return GetType().Name.Replace("Command", string.Empty);
        }
    }
}
