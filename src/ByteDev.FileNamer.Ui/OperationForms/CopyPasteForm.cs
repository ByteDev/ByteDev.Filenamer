using System;
using System.Globalization;
using ByteDev.FileNamer.Core.FileRenameCommands;

namespace ByteDev.FileNamer.Ui.OperationForms
{
	public partial class CopyPasteForm : OperationBaseForm
	{
		private readonly CutCopyPasteCommand _command;
		private readonly int _id;

		public CopyPasteForm(CutCopyPasteCommand command, int id)
		{
			InitializeComponent();

			_command = command;
			_id = id;

			UpdateUiFromOperation();
		}

		public CopyPasteForm() : this(new CutCopyPasteCommand(), -1)
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
				InvokeNewOperationFormEvent(_command);
			}
			else
			{
				InvokeEditOperationFormEvent(_command, _id);
			}
			Dispose();
		}

		private void UpdateOperationFromUi()
		{
			_command.CopyPosition = Int32.Parse(copyStartPosTextBox.Text);
			_command.CopyLength = Int32.Parse(copyLengthTextBox.Text);
			_command.PastePosition = Int32.Parse(pastePosTextBox.Text);
			_command.IsCut = cutCheckBox.Checked;
		}

		private void UpdateUiFromOperation()
		{
			copyStartPosTextBox.Text = _command.CopyPosition.ToString(CultureInfo.InvariantCulture);
			copyLengthTextBox.Text = _command.CopyLength.ToString(CultureInfo.InvariantCulture);
			pastePosTextBox.Text = _command.PastePosition.ToString(CultureInfo.InvariantCulture);
			cutCheckBox.Checked = _command.IsCut;
		}
	}
}
