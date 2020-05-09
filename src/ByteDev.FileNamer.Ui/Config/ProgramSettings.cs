using System;
using System.Drawing;
using System.Windows.Forms;

namespace ByteDev.FileNamer.Ui.Config
{
    [Serializable]
    public class ProgramSettings
    {
		public string SettingsFileName { get; set; }
		public Point WindowLocation { get; set; }
		public Size WindowSize { get; set; }
		public FormWindowState WindowState { get; set; }
		public string FileSuffix { get; set; }
		public string Folder { get; set; }
		public bool AutoPreview { get; set; }
		public bool ClearOpsOnRename { get; set; }

        public void UpdateFrom(MainForm form)
        {
            WindowLocation = form.Location;
            WindowSize = form.ClientSize;
            WindowState = form.WindowState;

            FileSuffix = form.fileSuffixTextBox.Text;
            Folder = form.folderTextBox.Text;
            AutoPreview = form.autoPreviewCheckBox.Checked;
            ClearOpsOnRename = form.clearOpsOnRenameCheckBox.Checked;
        }
	}
}
