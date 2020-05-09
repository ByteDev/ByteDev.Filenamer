using System.Windows.Forms;

namespace ByteDev.FileNamer.Ui.Controls
{
    public class StatusLabel : Label
    {
        public void Display(string message)
        {
            Text = message;
            Update();
        }

        public void DisplayRenameSummary(int counter)
        {
            if (counter == 1)
            {
                Text = "1 file renamed";
            }
            else
            {
                Text = counter + " files renamed";
            }
            Update();
        }

        public void DisplayPreviewSummary(int counter)
        {
            if (counter == 1)
            {
                Text = "Preview (1 file)";
            }
            else
            {
                Text = "Preview (" + counter + " files)";
            }
            Update();
        }

        public void DisplayFolderPathIsInvalidMessage(bool doFileRename)
        {
            if (doFileRename)
            {
                Text = "Folder path is invalid";
            }
        }
    }
}