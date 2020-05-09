using System;
using ByteDev.FileNamer.Core.FileRenameCommands;

namespace ByteDev.FileNamer.Ui.OperationForms
{
	public partial class RemoveStringForm : OperationBaseForm
	{
		private readonly RemoveSearchTextCommand _removeSearchTextCommand;
		private readonly int _id;

		public RemoveStringForm(RemoveSearchTextCommand removeSearchTextCommand, int id)
		{
			InitializeComponent();

            _removeSearchTextCommand = removeSearchTextCommand;
			_id = id;
			
            UpdateUiFromOperation();
		}

		public RemoveStringForm() : this(new RemoveSearchTextCommand(), -1)
		{
		}
		
		private void okButton_Click(object sender, EventArgs e)
		{
			Done();
		}

	    public override void Done()
		{
			UpdateOperationFromUi();

			if (_id < 0)
			{
				InvokeNewOperationFormEvent(_removeSearchTextCommand);
			}
			else
			{
				InvokeEditOperationFormEvent(_removeSearchTextCommand, _id);
			}
			Dispose();
		}

		private void UpdateOperationFromUi()
		{
			_removeSearchTextCommand.SearchText = removeTextBox.Text;
		}

		private void UpdateUiFromOperation()
		{
			removeTextBox.Text = _removeSearchTextCommand.SearchText;
		}
	}
}
