using System;
using System.Globalization;
using ByteDev.FileNamer.Core.FileRenameCommands;

namespace ByteDev.FileNamer.Ui.OperationForms
{
	public partial class RemovePositionTextForm : OperationBaseForm
	{
		private readonly RemovePositionTextCommand _removePositionTextCommand;
		private readonly int _id;

		public RemovePositionTextForm(RemovePositionTextCommand removePositionTextCommand, int id)
		{
			InitializeComponent();
			_removePositionTextCommand = removePositionTextCommand;
			_id = id;
			UpdateUiFromOperation();
		}

		public RemovePositionTextForm() : this(new RemovePositionTextCommand(), -1)
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
				InvokeNewOperationFormEvent(_removePositionTextCommand);
			}
			else
			{
				InvokeEditOperationFormEvent(_removePositionTextCommand, _id);
			}
			Dispose();
		}

		private void UpdateOperationFromUi()
		{
			_removePositionTextCommand.Position = Int32.Parse(startTextBox.Text);
			_removePositionTextCommand.Length = Int32.Parse(lengthTextBox.Text);
		}

		private void UpdateUiFromOperation()
		{
			startTextBox.Text = _removePositionTextCommand.Position.ToString(CultureInfo.InvariantCulture);
			lengthTextBox.Text = _removePositionTextCommand.Length.ToString(CultureInfo.InvariantCulture);
		}
	}
}
