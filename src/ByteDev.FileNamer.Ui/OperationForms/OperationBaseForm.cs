using System.Windows.Forms;
using ByteDev.FileNamer.Core.FileRenameCommands;

namespace ByteDev.FileNamer.Ui.OperationForms
{
	public abstract class OperationBaseForm : Form
	{
		public delegate void NewOperationDelegate(FileRenameCommand removeSearchText);
		public delegate void EditOperationDelegate(FileRenameCommand removeSearchText, int id);

		public event NewOperationDelegate NewOperationFormEvent;
		public event EditOperationDelegate EditOperationFormEvent;

	    public abstract void Done();

	    protected OperationBaseForm()
	    {
            KeyDown += Form_KeyDown;
            KeyPreview = true;
	    }

	    protected void InvokeNewOperationFormEvent(FileRenameCommand command)
		{
			NewOperationDelegate handler = NewOperationFormEvent;
			if (handler != null)
			{
			    handler(command);
			}
		}

	    protected void InvokeEditOperationFormEvent(FileRenameCommand command, int id)
		{
			EditOperationDelegate handler = EditOperationFormEvent;
			if (handler != null)
			{
			    handler(command, id);
			}
		}
		
	    private void Form_KeyDown(object sender, KeyEventArgs e)
        {
	        switch (e.KeyCode)
	        {
	            case Keys.Escape:
                    Dispose();
	                break;

                case Keys.Return:
	                Done();
	                break;
	        }
        }
	}
}
