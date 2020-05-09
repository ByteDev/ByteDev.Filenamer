using System;

namespace ByteDev.FileNamer.Core.FileRenameCommands
{
    /// <summary>
    /// Remove string from start position to length
    /// </summary>
    [Serializable]
    public class RemovePositionTextCommand : FileRenameCommand
    {
        public int Position { get; set; }
        public int Length { get; set; }

        public RemovePositionTextCommand(int position, int length)
        {
			Position = position;
			Length = length;
        }

        public RemovePositionTextCommand() : this(0, 0)
        {
        }

        public override void Execute(string fileName)
        {
            var fileNameWithoutExten = GetFileNameWithoutExtension(fileName);

			if(Length < 1)
			{
				SetResult(fileName);
				return;
			}

            var startPos = Position;

            if (startPos < 0)
            {
                startPos = 0;
            }
            else if (startPos > fileNameWithoutExten.Length)
            {
                SetResult(fileNameWithoutExten + GetFileNameExtension(fileName));
            	return;
            }

            try
            {
                var left = fileNameWithoutExten.Substring(0, startPos);     
                var right = fileNameWithoutExten.Substring(startPos + Length);

                SetResult(left + right + GetFileNameExtension(fileName));
            }
            catch (Exception ex)
            {
                throw new FileRenameCommandException(ex.Message, ex);
            }
        }

        public override string ToString()
        {
        	if ((Position < 1) && (Length < 1))
        	{
        	    return GetDisplayName();
        	}
        	return GetDisplayName() + " { " + Position + ", " + Length + " }";
        }

        private string GetDisplayName()
        {
            return GetType().Name.Replace("Command", string.Empty);
        }
    }
}
