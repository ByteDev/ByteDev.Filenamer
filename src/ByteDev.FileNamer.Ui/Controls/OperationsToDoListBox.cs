using System.Windows.Forms;
using ByteDev.FileNamer.Core.FileRenameCommands;

namespace ByteDev.FileNamer.Ui.Controls
{
	public class OperationsToDoListBox : ListBox
	{
		public FileRenameCommand SelectedCommand
		{
			get { return (FileRenameCommand) SelectedItem; }
		}

	    private bool IsSelectedAtTop
	    {
	        get { return SelectedIndex <= 0; }
	    }

	    private bool IsSelectedAtBottom
	    {
	        get { return SelectedIndex >= (Items.Count - 1); }
	    }

	    /// <summary>
		/// Move the selected operation in the to do list up 1 position
		/// </summary>
		/// <returns>True, operation was moved. False, it wasnt.</returns>
		public bool MoveSelectedUp()
		{
			if (IsSelectedAtTop)
			{
				return false;
			}

			// Swap the previous with selected
			int selectedIndex = SelectedIndex;

			var prev = (FileRenameCommand)Items[selectedIndex - 1];
			Items[selectedIndex - 1] = Items[selectedIndex];
			Items[selectedIndex] = prev;

			SelectedIndex = selectedIndex - 1;
			return true;
		}

	    /// <summary>
		/// Move the selected operation in the to do list down 1 position
		/// </summary>
		/// <returns>True, operation was moved. False, it wasnt.</returns>
		public bool MoveSelectedDown()
		{
			if (IsSelectedAtBottom)
			{
				return false;
			}

			// Swap the next with selected
			int selectedIndex = SelectedIndex;

			var next = (FileRenameCommand)Items[selectedIndex + 1];
			Items[selectedIndex + 1] = Items[selectedIndex];
			Items[selectedIndex] = next;

			SelectedIndex = selectedIndex + 1;
			return true;
		}

	    /// <summary>
		/// Remove the selected operation
		/// </summary>
		public void RemoveSelected()
		{
			Items.Remove(SelectedItem);

			if (Items.Count > 0)
			{
				SelectedIndex = Items.Count - 1;
			}
		}

		/// <summary>
		/// Add operation to end of list
		/// </summary>
		public void Add(FileRenameCommand command)
		{
			Items.Add(command);
			SetLastSelected();
		}

		/// <summary>
		/// Set the selected index
		/// </summary>
		public void SetSelected(int index)
		{
			SelectedIndex = index;
		}

		/// <summary>
		/// Set the last operation to be selected
		/// </summary>
		public void SetLastSelected()
		{
			SetSelected(Items.Count - 1);
		}

		/// <summary>
		/// Update the operation at the specified index position
		/// </summary>
		public void Update(FileRenameCommand command, int index)
		{
			Items[index] = command;
		}

		/// <summary>
		/// Retrieve the operation at the specified index
		/// </summary>
		public FileRenameCommand GetByIndex(int index)
		{
			return (FileRenameCommand)Items[index];
		}
	}
}
