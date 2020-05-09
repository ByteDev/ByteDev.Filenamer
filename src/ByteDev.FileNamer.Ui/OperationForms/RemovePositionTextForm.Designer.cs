namespace ByteDev.FileNamer.Ui.OperationForms
{
	partial class RemovePositionTextForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemovePositionTextForm));
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.startTextBox = new System.Windows.Forms.TextBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lengthLabel
            // 
            this.lengthLabel.Location = new System.Drawing.Point(25, 45);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(60, 16);
            this.lengthLabel.TabIndex = 9;
            this.lengthLabel.Text = "Length:";
            this.lengthLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(89, 41);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(88, 20);
            this.lengthTextBox.TabIndex = 6;
            this.lengthTextBox.Text = "1";
            this.lengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // startTextBox
            // 
            this.startTextBox.Location = new System.Drawing.Point(89, 9);
            this.startTextBox.Name = "startTextBox";
            this.startTextBox.Size = new System.Drawing.Size(88, 20);
            this.startTextBox.TabIndex = 5;
            this.startTextBox.Text = "0";
            this.startTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // positionLabel
            // 
            this.positionLabel.Location = new System.Drawing.Point(9, 13);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(76, 16);
            this.positionLabel.TabIndex = 7;
            this.positionLabel.Text = "Start Position:";
            this.positionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(105, 93);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // RemovePositionTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 125);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.startTextBox);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.okButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemovePositionTextForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Position Text";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lengthLabel;
		private System.Windows.Forms.TextBox lengthTextBox;
		private System.Windows.Forms.TextBox startTextBox;
		private System.Windows.Forms.Label positionLabel;
		private System.Windows.Forms.Button okButton;
	}
}