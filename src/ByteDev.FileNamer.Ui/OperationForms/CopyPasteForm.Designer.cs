namespace ByteDev.FileNamer.Ui.OperationForms
{
	partial class CopyPasteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyPasteForm));
            this.pastePosLabel = new System.Windows.Forms.Label();
            this.cutCheckBox = new System.Windows.Forms.CheckBox();
            this.pastePosTextBox = new System.Windows.Forms.TextBox();
            this.copyLengthTextBox = new System.Windows.Forms.TextBox();
            this.copyStartPosTextBox = new System.Windows.Forms.TextBox();
            this.copyLengthLabel = new System.Windows.Forms.Label();
            this.copyStartPosLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pastePosLabel
            // 
            this.pastePosLabel.Location = new System.Drawing.Point(19, 127);
            this.pastePosLabel.Name = "pastePosLabel";
            this.pastePosLabel.Size = new System.Drawing.Size(100, 16);
            this.pastePosLabel.TabIndex = 16;
            this.pastePosLabel.Text = "Paste Position:";
            this.pastePosLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // cutCheckBox
            // 
            this.cutCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cutCheckBox.Location = new System.Drawing.Point(11, 87);
            this.cutCheckBox.Name = "cutCheckBox";
            this.cutCheckBox.Size = new System.Drawing.Size(128, 24);
            this.cutCheckBox.TabIndex = 11;
            this.cutCheckBox.Text = "Cut Original Text?";
            this.cutCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pastePosTextBox
            // 
            this.pastePosTextBox.Location = new System.Drawing.Point(123, 127);
            this.pastePosTextBox.Name = "pastePosTextBox";
            this.pastePosTextBox.Size = new System.Drawing.Size(72, 20);
            this.pastePosTextBox.TabIndex = 12;
            this.pastePosTextBox.Text = "0";
            this.pastePosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // copyLengthTextBox
            // 
            this.copyLengthTextBox.Location = new System.Drawing.Point(123, 47);
            this.copyLengthTextBox.Name = "copyLengthTextBox";
            this.copyLengthTextBox.Size = new System.Drawing.Size(72, 20);
            this.copyLengthTextBox.TabIndex = 10;
            this.copyLengthTextBox.Text = "1";
            this.copyLengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // copyStartPosTextBox
            // 
            this.copyStartPosTextBox.Location = new System.Drawing.Point(123, 15);
            this.copyStartPosTextBox.Name = "copyStartPosTextBox";
            this.copyStartPosTextBox.Size = new System.Drawing.Size(72, 20);
            this.copyStartPosTextBox.TabIndex = 9;
            this.copyStartPosTextBox.Text = "0";
            this.copyStartPosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // copyLengthLabel
            // 
            this.copyLengthLabel.Location = new System.Drawing.Point(19, 47);
            this.copyLengthLabel.Name = "copyLengthLabel";
            this.copyLengthLabel.Size = new System.Drawing.Size(100, 16);
            this.copyLengthLabel.TabIndex = 14;
            this.copyLengthLabel.Text = "Copy Length:";
            this.copyLengthLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // copyStartPosLabel
            // 
            this.copyStartPosLabel.Location = new System.Drawing.Point(11, 15);
            this.copyStartPosLabel.Name = "copyStartPosLabel";
            this.copyStartPosLabel.Size = new System.Drawing.Size(104, 16);
            this.copyStartPosLabel.TabIndex = 13;
            this.copyStartPosLabel.Text = "Copy Start Position:";
            this.copyStartPosLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(123, 175);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 15;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // CopyPasteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 213);
            this.Controls.Add(this.pastePosLabel);
            this.Controls.Add(this.cutCheckBox);
            this.Controls.Add(this.pastePosTextBox);
            this.Controls.Add(this.copyLengthTextBox);
            this.Controls.Add(this.copyStartPosTextBox);
            this.Controls.Add(this.copyLengthLabel);
            this.Controls.Add(this.copyStartPosLabel);
            this.Controls.Add(this.okButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CopyPasteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copy/Cut & Paste";
            this.ResumeLayout(false);
            this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label pastePosLabel;
		private System.Windows.Forms.CheckBox cutCheckBox;
		private System.Windows.Forms.TextBox pastePosTextBox;
		private System.Windows.Forms.TextBox copyLengthTextBox;
		private System.Windows.Forms.TextBox copyStartPosTextBox;
		private System.Windows.Forms.Label copyLengthLabel;
		private System.Windows.Forms.Label copyStartPosLabel;
		private System.Windows.Forms.Button okButton;
	}
}