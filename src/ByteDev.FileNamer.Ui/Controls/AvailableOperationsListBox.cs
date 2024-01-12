using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ByteDev.FileNamer.Core.FileRenameCommands;

namespace ByteDev.FileNamer.Ui.Controls
{
	public class AvailableOperationsListBox : ListBox
	{
		public void LoadOperations(IEnumerable<FileRenameCommand> operations)
		{
			foreach (var op in operations)
			{
				Items.Add(op);
			}
		}

        public FileRenameCommand GetCloneFromSelected()
        {
            var command = SelectedItem as FileRenameCommand;

            if(command == null)
                throw new NullReferenceException("No operation is selected");

            return command.CloneSerializable();
        }
    }
}
