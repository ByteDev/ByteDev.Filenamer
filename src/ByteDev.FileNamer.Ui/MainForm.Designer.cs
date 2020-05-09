using ByteDev.FileNamer.Ui.Controls;

namespace ByteDev.FileNamer.Ui
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		
		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.clearOpsOnRenameCheckBox = new System.Windows.Forms.CheckBox();
            this.opToDoUpButton = new System.Windows.Forms.Button();
            this.opToDoDownButton = new System.Windows.Forms.Button();
            this.editOpToDoButton = new System.Windows.Forms.Button();
            this.autoPreviewCheckBox = new System.Windows.Forms.CheckBox();
            this.previewButton = new System.Windows.Forms.Button();
            this.removeOpButton = new System.Windows.Forms.Button();
            this.opsToDoLabel = new System.Windows.Forms.Label();
            this.opsToDoListBox = new ByteDev.FileNamer.Ui.Controls.OperationsToDoListBox();
            this.opsAvailableLabel = new System.Windows.Forms.Label();
            this.previewLabel = new System.Windows.Forms.Label();
            this.opsAvailableListBox = new ByteDev.FileNamer.Ui.Controls.AvailableOperationsListBox();
            this.addOpButton = new System.Windows.Forms.Button();
            this.statusLabel = new ByteDev.FileNamer.Ui.Controls.StatusLabel();
            this.renameButton = new System.Windows.Forms.Button();
            this.previewTextBox = new System.Windows.Forms.TextBox();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.fileSuffixTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.folderLabel = new System.Windows.Forms.Label();
            this.fileSuffixLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clearOpsOnRenameCheckBox
            // 
            this.clearOpsOnRenameCheckBox.Checked = true;
            this.clearOpsOnRenameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clearOpsOnRenameCheckBox.Location = new System.Drawing.Point(884, 491);
            this.clearOpsOnRenameCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearOpsOnRenameCheckBox.Name = "clearOpsOnRenameCheckBox";
            this.clearOpsOnRenameCheckBox.Size = new System.Drawing.Size(102, 92);
            this.clearOpsOnRenameCheckBox.TabIndex = 48;
            this.clearOpsOnRenameCheckBox.Text = "Clear Ops On Rename";
            this.clearOpsOnRenameCheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // opToDoUpButton
            // 
            this.opToDoUpButton.Location = new System.Drawing.Point(468, 228);
            this.opToDoUpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opToDoUpButton.Name = "opToDoUpButton";
            this.opToDoUpButton.Size = new System.Drawing.Size(72, 35);
            this.opToDoUpButton.TabIndex = 47;
            this.opToDoUpButton.Text = "Up";
            this.opToDoUpButton.Click += new System.EventHandler(this.opToDoUpButton_Click);
            // 
            // opToDoDownButton
            // 
            this.opToDoDownButton.Location = new System.Drawing.Point(468, 277);
            this.opToDoDownButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opToDoDownButton.Name = "opToDoDownButton";
            this.opToDoDownButton.Size = new System.Drawing.Size(72, 35);
            this.opToDoDownButton.TabIndex = 46;
            this.opToDoDownButton.Text = "Down";
            this.opToDoDownButton.Click += new System.EventHandler(this.opToDoDownButton_Click);
            // 
            // editOpToDoButton
            // 
            this.editOpToDoButton.Location = new System.Drawing.Point(468, 348);
            this.editOpToDoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editOpToDoButton.Name = "editOpToDoButton";
            this.editOpToDoButton.Size = new System.Drawing.Size(72, 35);
            this.editOpToDoButton.TabIndex = 45;
            this.editOpToDoButton.Text = "Edit";
            this.editOpToDoButton.Click += new System.EventHandler(this.editOpToDoButton_Click);
            // 
            // autoPreviewCheckBox
            // 
            this.autoPreviewCheckBox.Checked = true;
            this.autoPreviewCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoPreviewCheckBox.Location = new System.Drawing.Point(884, 430);
            this.autoPreviewCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.autoPreviewCheckBox.Name = "autoPreviewCheckBox";
            this.autoPreviewCheckBox.Size = new System.Drawing.Size(96, 55);
            this.autoPreviewCheckBox.TabIndex = 44;
            this.autoPreviewCheckBox.Text = "Auto Preview";
            this.autoPreviewCheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.autoPreviewCheckBox.CheckedChanged += new System.EventHandler(this.autoPreviewCheckBox_CheckedChanged);
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(884, 719);
            this.previewButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(114, 35);
            this.previewButton.TabIndex = 43;
            this.previewButton.Text = "Preview";
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // removeOpButton
            // 
            this.removeOpButton.Image = ((System.Drawing.Image)(resources.GetObject("removeOpButton.Image")));
            this.removeOpButton.Location = new System.Drawing.Point(468, 148);
            this.removeOpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeOpButton.Name = "removeOpButton";
            this.removeOpButton.Size = new System.Drawing.Size(72, 35);
            this.removeOpButton.TabIndex = 42;
            this.removeOpButton.Click += new System.EventHandler(this.removeOpButton_Click);
            // 
            // opsToDoLabel
            // 
            this.opsToDoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.opsToDoLabel.Location = new System.Drawing.Point(548, 54);
            this.opsToDoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.opsToDoLabel.Name = "opsToDoLabel";
            this.opsToDoLabel.Size = new System.Drawing.Size(450, 34);
            this.opsToDoLabel.TabIndex = 41;
            this.opsToDoLabel.Text = "Operations To Do";
            this.opsToDoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // opsToDoListBox
            // 
            this.opsToDoListBox.ItemHeight = 20;
            this.opsToDoListBox.Location = new System.Drawing.Point(548, 98);
            this.opsToDoListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opsToDoListBox.Name = "opsToDoListBox";
            this.opsToDoListBox.Size = new System.Drawing.Size(450, 284);
            this.opsToDoListBox.TabIndex = 40;
            // 
            // opsAvailableLabel
            // 
            this.opsAvailableLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.opsAvailableLabel.Location = new System.Drawing.Point(8, 55);
            this.opsAvailableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.opsAvailableLabel.Name = "opsAvailableLabel";
            this.opsAvailableLabel.Size = new System.Drawing.Size(450, 34);
            this.opsAvailableLabel.TabIndex = 39;
            this.opsAvailableLabel.Text = "Operations Available";
            this.opsAvailableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // previewLabel
            // 
            this.previewLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewLabel.Location = new System.Drawing.Point(8, 400);
            this.previewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(840, 34);
            this.previewLabel.TabIndex = 38;
            this.previewLabel.Text = "Preview";
            this.previewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // opsAvailableListBox
            // 
            this.opsAvailableListBox.ItemHeight = 20;
            this.opsAvailableListBox.Location = new System.Drawing.Point(8, 98);
            this.opsAvailableListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opsAvailableListBox.Name = "opsAvailableListBox";
            this.opsAvailableListBox.Size = new System.Drawing.Size(450, 284);
            this.opsAvailableListBox.TabIndex = 37;
            // 
            // addOpButton
            // 
            this.addOpButton.Image = ((System.Drawing.Image)(resources.GetObject("addOpButton.Image")));
            this.addOpButton.Location = new System.Drawing.Point(468, 98);
            this.addOpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addOpButton.Name = "addOpButton";
            this.addOpButton.Size = new System.Drawing.Size(72, 35);
            this.addOpButton.TabIndex = 36;
            this.addOpButton.Click += new System.EventHandler(this.addOpButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(8, 825);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(606, 25);
            this.statusLabel.TabIndex = 35;
            // 
            // renameButton
            // 
            this.renameButton.Location = new System.Drawing.Point(884, 774);
            this.renameButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(114, 35);
            this.renameButton.TabIndex = 34;
            this.renameButton.Text = "Rename";
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // previewTextBox
            // 
            this.previewTextBox.Location = new System.Drawing.Point(8, 443);
            this.previewTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.previewTextBox.Multiline = true;
            this.previewTextBox.Name = "previewTextBox";
            this.previewTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.previewTextBox.Size = new System.Drawing.Size(840, 367);
            this.previewTextBox.TabIndex = 33;
            this.previewTextBox.WordWrap = false;
            // 
            // folderTextBox
            // 
            this.folderTextBox.Location = new System.Drawing.Point(233, 9);
            this.folderTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(643, 26);
            this.folderTextBox.TabIndex = 29;
            this.folderTextBox.Text = "C:\\";
            this.folderTextBox.TextChanged += new System.EventHandler(this.folderTextBox_TextChanged);
            // 
            // fileSuffixTextBox
            // 
            this.fileSuffixTextBox.Location = new System.Drawing.Point(103, 9);
            this.fileSuffixTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileSuffixTextBox.Name = "fileSuffixTextBox";
            this.fileSuffixTextBox.Size = new System.Drawing.Size(64, 26);
            this.fileSuffixTextBox.TabIndex = 28;
            this.fileSuffixTextBox.Text = "mp3";
            this.fileSuffixTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fileSuffixTextBox.TextChanged += new System.EventHandler(this.fileSuffixTextBox_TextChanged);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(884, 5);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(114, 35);
            this.browseButton.TabIndex = 32;
            this.browseButton.Text = "Browse";
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // folderLabel
            // 
            this.folderLabel.Location = new System.Drawing.Point(170, 12);
            this.folderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(60, 25);
            this.folderLabel.TabIndex = 31;
            this.folderLabel.Text = "Folder:";
            this.folderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fileSuffixLabel
            // 
            this.fileSuffixLabel.Location = new System.Drawing.Point(4, 14);
            this.fileSuffixLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileSuffixLabel.Name = "fileSuffixLabel";
            this.fileSuffixLabel.Size = new System.Drawing.Size(96, 25);
            this.fileSuffixLabel.TabIndex = 30;
            this.fileSuffixLabel.Text = "Suffix Filter:";
            this.fileSuffixLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 857);
            this.Controls.Add(this.clearOpsOnRenameCheckBox);
            this.Controls.Add(this.opToDoUpButton);
            this.Controls.Add(this.opToDoDownButton);
            this.Controls.Add(this.editOpToDoButton);
            this.Controls.Add(this.autoPreviewCheckBox);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.removeOpButton);
            this.Controls.Add(this.opsToDoLabel);
            this.Controls.Add(this.opsToDoListBox);
            this.Controls.Add(this.opsAvailableLabel);
            this.Controls.Add(this.previewLabel);
            this.Controls.Add(this.opsAvailableListBox);
            this.Controls.Add(this.addOpButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.previewTextBox);
            this.Controls.Add(this.folderTextBox);
            this.Controls.Add(this.fileSuffixTextBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.folderLabel);
            this.Controls.Add(this.fileSuffixLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Namer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.CheckBox clearOpsOnRenameCheckBox;
		private System.Windows.Forms.Button opToDoUpButton;
		private System.Windows.Forms.Button opToDoDownButton;
		private System.Windows.Forms.Button editOpToDoButton;
		public System.Windows.Forms.CheckBox autoPreviewCheckBox;
		private System.Windows.Forms.Button previewButton;
		private System.Windows.Forms.Button removeOpButton;
		private System.Windows.Forms.Label opsToDoLabel;
		private OperationsToDoListBox opsToDoListBox;
		private System.Windows.Forms.Label opsAvailableLabel;
		private System.Windows.Forms.Label previewLabel;
		private AvailableOperationsListBox opsAvailableListBox;
		private System.Windows.Forms.Button addOpButton;
        private StatusLabel statusLabel;
		private System.Windows.Forms.Button renameButton;
		private System.Windows.Forms.TextBox previewTextBox;
		public System.Windows.Forms.TextBox folderTextBox;
		public System.Windows.Forms.TextBox fileSuffixTextBox;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.Label folderLabel;
		private System.Windows.Forms.Label fileSuffixLabel;
    }
}