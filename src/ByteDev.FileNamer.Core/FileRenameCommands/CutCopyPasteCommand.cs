using System;

namespace ByteDev.FileNamer.Core.FileRenameCommands
{
    /// <summary>
    /// Find the selected text and copy it to a specific location.  Cut if required.
    /// </summary>
    [Serializable]
    public class CutCopyPasteCommand : FileRenameCommand
    {
        public int CopyPosition { get; set; }
        public int CopyLength { get; set; }
        public int PastePosition { get; set; }
        public bool IsCut { get; set; }

        public CutCopyPasteCommand() : this(0, 1, 0, false)
        {
        }

        public CutCopyPasteCommand(int copyPosition, int copyLength, int pastePosition, bool isCut)
        {
            CopyPosition = copyPosition;
            CopyLength = copyLength;
            PastePosition = pastePosition;
            IsCut = isCut;
        }

        public override void Execute(string fileName)
        {
			ValidateParameters(fileName);
            var newFileNameWithNoExten = GetFileNameWithoutExtension(fileName);

            try
            {
                var s1 = Copy(newFileNameWithNoExten);		                    
                newFileNameWithNoExten = Paste(newFileNameWithNoExten, s1);						    

                if (IsCut)
                {
                    newFileNameWithNoExten = Cut(newFileNameWithNoExten);
                }
            }
            catch (Exception ex)
            {
                throw new FileRenameCommandException(ex.Message, ex);
            }

            SetResult(newFileNameWithNoExten + GetFileNameExtension(fileName));
        }

        private string Copy(string text)
        {
            return text.Substring(CopyPosition, CopyLength);
        }

        private string Paste(string text, string textToPaste)
        {
            return text.Insert(PastePosition, textToPaste);
        }

        private string Cut(string text)
        {
            return text.Remove(CopyPosition, CopyLength);
        }

        private void ValidateParameters(string fileName)
        {
            if (CopyPosition < 0)
            {
                CopyPosition = 0;
            }

            if (CopyLength < 1)
            {
                throw new FileRenameCommandValidationException("Copy length must be 1 or greater");
            }

            if (CopyLength > GetFileNameWithoutExtension(fileName).Length)
            {
                throw new FileRenameCommandValidationException(string.Format("Copy length must be equal to or less than {0}", fileName.Length));
            }

            if(PastePosition > fileName.Length)
            {
                PastePosition = fileName.Length;									// position is off the end so just append to end
            }
        }

        public override string ToString()
        {
            if ((CopyPosition < 1) &&
                (CopyLength < 2) &&
                (PastePosition < 1) &&
                (!IsCut))
            {
                return GetDisplayName();
            }
            return GetDisplayName() + " { " + CopyPosition + ", " +
                                    CopyLength + ", " +
                                    PastePosition + ", " +
                                    IsCut + " }";
        }

        private string GetDisplayName()
        {
            return GetType().Name.Replace("Command", string.Empty);
        }
    }
}
