using ByteDev.FileNamer.Core.FileRenameCommands;

namespace ByteDev.FileNamer.Ui.OperationForms
{
	public partial class CustomReplaceForm : OperationBaseForm
	{
		private readonly int _id;
		private readonly ReplaceStringCommand _replaceStringCommand;

		public CustomReplaceForm(ReplaceStringCommand replaceStringCommand, int id)
		{
			InitializeComponent();
			
            _replaceStringCommand = replaceStringCommand;
			_id = id;

			UpdateUiFromOperation();
		}

		public CustomReplaceForm() : this(new ReplaceStringCommand(), -1)
		{
		}

		private void okButton_Click(object sender, System.EventArgs e)
		{
			Done();
		}

	    public override void Done()
		{
			UpdateOperationFromUi();

			if (_id < 0)
			{
				InvokeNewOperationFormEvent(_replaceStringCommand);
			}
			else
			{
				InvokeEditOperationFormEvent(_replaceStringCommand, _id);
			}
			Dispose();
		}

		private void UpdateOperationFromUi()
		{
			_replaceStringCommand.FindText = findStringTextBox.Text;
			_replaceStringCommand.ReplacementText = replaceStringTextBox.Text;
		}

		private void UpdateUiFromOperation()
		{
			findStringTextBox.Text = _replaceStringCommand.FindText;
			replaceStringTextBox.Text = _replaceStringCommand.ReplacementText;
		}
	}
}
