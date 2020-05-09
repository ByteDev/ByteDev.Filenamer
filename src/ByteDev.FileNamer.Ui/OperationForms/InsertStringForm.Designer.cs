namespace ByteDev.FileNamer.Ui.OperationForms
{
	partial class InsertStringForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertStringForm));
            this.okButton = new System.Windows.Forms.Button();
            this.charPositionTextBox = new System.Windows.Forms.TextBox();
            this.insertStringTextBox = new System.Windows.Forms.TextBox();
            this.atPositionLabel = new System.Windows.Forms.Label();
            this.insertLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(219, 49);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 16;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // charPositionTextBox
            // 
            this.charPositionTextBox.Location = new System.Drawing.Point(259, 9);
            this.charPositionTextBox.Name = "charPositionTextBox";
            this.charPositionTextBox.Size = new System.Drawing.Size(32, 20);
            this.charPositionTextBox.TabIndex = 15;
            this.charPositionTextBox.Text = "0";
            this.charPositionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // insertStringTextBox
            // 
            this.insertStringTextBox.Location = new System.Drawing.Point(44, 9);
            this.insertStringTextBox.Name = "insertStringTextBox";
            this.insertStringTextBox.Size = new System.Drawing.Size(151, 20);
            this.insertStringTextBox.TabIndex = 14;
            // 
            // atPositionLabel
            // 
            this.atPositionLabel.Location = new System.Drawing.Point(199, 13);
            this.atPositionLabel.Name = "atPositionLabel";
            this.atPositionLabel.Size = new System.Drawing.Size(60, 16);
            this.atPositionLabel.TabIndex = 18;
            this.atPositionLabel.Text = "@ position";
            // 
            // insertLabel
            // 
            this.insertLabel.Location = new System.Drawing.Point(7, 13);
            this.insertLabel.Name = "insertLabel";
            this.insertLabel.Size = new System.Drawing.Size(44, 16);
            this.insertLabel.TabIndex = 17;
            this.insertLabel.Text = "Insert";
            // 
            // InsertStringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 81);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.charPositionTextBox);
            this.Controls.Add(this.insertStringTextBox);
            this.Controls.Add(this.atPositionLabel);
            this.Controls.Add(this.insertLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertStringForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert String";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.TextBox charPositionTextBox;
		private System.Windows.Forms.TextBox insertStringTextBox;
		private System.Windows.Forms.Label atPositionLabel;
		private System.Windows.Forms.Label insertLabel;
	}
}