using System;
using ByteDev.FileNamer.Core.FileRenameCommands;
using ByteDev.FileNamer.Ui.OperationForms;

namespace ByteDev.FileNamer.Ui.Factories
{
    public interface IOperationFormFactory
    {
        OperationBaseForm Create(FileRenameCommand command, int indexId);
    }

    public class OperationFormFactory : IOperationFormFactory
    {
	    public OperationBaseForm Create(FileRenameCommand command, int indexId)
		{
	        if (command.GetType() == typeof (RemoveSearchTextCommand))
	        {
                return new RemoveStringForm((RemoveSearchTextCommand)command, indexId);
	        }

	        if (command.GetType() == typeof (RemovePositionTextCommand))
	        {
                return new RemovePositionTextForm((RemovePositionTextCommand)command, indexId);   
	        }

	        if (command.GetType() == typeof (InsertStringCommand))
	        {
                return new InsertStringForm((InsertStringCommand)command, indexId);
	        }

	        if (command.GetType() == typeof (ReplaceStringCommand))
	        {
                return new CustomReplaceForm((ReplaceStringCommand)command, indexId);
	        }

	        if (command.GetType() == typeof (CutCopyPasteCommand))
	        {
                return new CopyPasteForm((CutCopyPasteCommand)command, indexId);
	        }

            throw new InvalidOperationException(string.Format("No form exists for command: {0}", command.GetType().Name));
		}

        public static bool HasForm(FileRenameCommand command)
        {
            return ((command.GetType() == typeof (RemoveSearchTextCommand)) ||
                    (command.GetType() == typeof (RemovePositionTextCommand)) ||
                    (command.GetType() == typeof (InsertStringCommand)) ||
                    (command.GetType() == typeof (ReplaceStringCommand)) ||
                    (command.GetType() == typeof (CutCopyPasteCommand)));
        }
    }
}
