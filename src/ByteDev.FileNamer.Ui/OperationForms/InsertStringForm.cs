using System;
using System.Globalization;
using ByteDev.FileNamer.Core.FileRenameCommands;

namespace ByteDev.FileNamer.Ui.OperationForms
{
	public partial class InsertStringForm : OperationBaseForm
	{
		private readonly int _id;
		private readonly InsertStringCommand _insertStringCommand;

		public InsertStringForm(InsertStringCommand insertStringCommand, int id)
		{
			InitializeComponent();

			_insertStringCommand = insertStringCommand;
			_id = id;

			UpdateUiFromOperation();
		}

		public InsertStringForm() : this(new InsertStringCommand(), -1)
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
				InvokeNewOperationFormEvent(_insertStringCommand);
			}
			else
			{
				InvokeEditOperationFormEvent(_insertStringCommand, _id);
			}
			Dispose();
		}

		private void UpdateOperationFromUi()
		{
			_insertStringCommand.Position = Int32.Parse(charPositionTextBox.Text);
			_insertStringCommand.StringToInsert = insertStringTextBox.Text;
		}

		private void UpdateUiFromOperation()
		{
			insertStringTextBox.Text = _insertStringCommand.StringToInsert;
			charPositionTextBox.Text = _insertStringCommand.Position.ToString(CultureInfo.InvariantCulture);
		}
	}
}
