namespace ByteDev.FileNamer.Ui.OperationForms
{
	partial class CustomReplaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomReplaceForm));
            this.okButton = new System.Windows.Forms.Button();
            this.replaceLabel = new System.Windows.Forms.Label();
            this.replaceStringTextBox = new System.Windows.Forms.TextBox();
            this.findStringTextBox = new System.Windows.Forms.TextBox();
            this.findLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(175, 83);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 13;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // replaceLabel
            // 
            this.replaceLabel.Location = new System.Drawing.Point(11, 43);
            this.replaceLabel.Name = "replaceLabel";
            this.replaceLabel.Size = new System.Drawing.Size(52, 24);
            this.replaceLabel.TabIndex = 15;
            this.replaceLabel.Text = "Replace:";
            this.replaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // replaceStringTextBox
            // 
            this.replaceStringTextBox.Location = new System.Drawing.Point(67, 43);
            this.replaceStringTextBox.Name = "replaceStringTextBox";
            this.replaceStringTextBox.Size = new System.Drawing.Size(180, 20);
            this.replaceStringTextBox.TabIndex = 12;
            // 
            // findStringTextBox
            // 
            this.findStringTextBox.Location = new System.Drawing.Point(67, 11);
            this.findStringTextBox.Name = "findStringTextBox";
            this.findStringTextBox.Size = new System.Drawing.Size(180, 20);
            this.findStringTextBox.TabIndex = 11;
            // 
            // findLabel
            // 
            this.findLabel.Location = new System.Drawing.Point(19, 11);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(44, 24);
            this.findLabel.TabIndex = 14;
            this.findLabel.Text = "Find:";
            this.findLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustomReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 117);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.replaceLabel);
            this.Controls.Add(this.replaceStringTextBox);
            this.Controls.Add(this.findStringTextBox);
            this.Controls.Add(this.findLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomReplaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Label replaceLabel;
		private System.Windows.Forms.TextBox replaceStringTextBox;
		private System.Windows.Forms.TextBox findStringTextBox;
		private System.Windows.Forms.Label findLabel;
	}
}