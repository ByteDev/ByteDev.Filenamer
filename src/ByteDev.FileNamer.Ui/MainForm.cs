using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ByteDev.FileNamer.Core;
using ByteDev.FileNamer.Core.FileRenameCommands;
using ByteDev.FileNamer.Ui.Config;
using ByteDev.FileNamer.Ui.Factories;
using ByteDev.FileNamer.Ui.OperationForms;
using ByteDev.WinForms.Dialogs;
using ByteDev.WinForms.Forms;

namespace ByteDev.FileNamer.Ui
{
	public partial class MainForm : Form
	{
	    private readonly IOperationFormFactory _operationFormFactory;
	    private readonly IProgramSettingsService _settingsService;

	    private FileRenameCommandList _commandList;

	    private IEnumerable<FileRenameCommand> FileRenameCommands
		{
			get
			{
				if (_commandList == null)
				{
					_commandList = new FileRenameCommandList();
					_commandList.Fill();
				}
				return _commandList;
			}
		}

        public MainForm(IOperationFormFactory operationFormFactory,
            IProgramSettingsService programSettingsService)
        {
            _operationFormFactory = operationFormFactory;
            _settingsService = programSettingsService;

            InitializeComponent();
        }

		#region Startup / Shut down

	    private void MainForm_Load(object sender, EventArgs e)
		{
			try
			{
				SetupApp();
			}
			catch (Exception ex)
			{
				HandleException(ex);
			}
		}

		private void SetupApp()
		{
			SetupMainForm();

            _settingsService.Load();
            UpdateFrom(_settingsService.ProgramSettings);

			opsAvailableListBox.LoadOperations(FileRenameCommands);

			PreviewRenameFiles();
		}

	    private void SetupMainForm()
	    {
	        Text = $"File Namer {Application.ProductVersion}";
	        WindowState = FormWindowState.Normal;
	    }

	    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveConfig();
		}

		#endregion

		private void UpdateFrom(ProgramSettings settings)
		{
			StartPosition = FormStartPosition.Manual;							// dont let auto position
            Location = settings.WindowLocation;

            if ((settings.WindowSize.Width != 0) && (settings.WindowSize.Height != 0))
			{
                ClientSize = settings.WindowSize;
			}

            WindowState = settings.WindowState;

            fileSuffixTextBox.Text = settings.FileSuffix;
            folderTextBox.Text = settings.Folder;
            autoPreviewCheckBox.Checked = settings.AutoPreview;
            clearOpsOnRenameCheckBox.Checked = settings.ClearOpsOnRename;
		}

		private void SaveConfig()
		{
            _settingsService.ProgramSettings.UpdateFrom(this);
			_settingsService.Save();
		}

		#region Event Handlers

		private void browseButton_Click(object sender, EventArgs e)
		{
			try
			{
				folderTextBox.Text = FolderDialog.SelectFolder(folderTextBox.Text);
				PreviewRenameFilesIfEnabled();
			}
			catch (Exception ex)
			{
				HandleException(ex);
			}
		}

		private void previewButton_Click(object sender, EventArgs e)
		{
			try
			{
				PreviewRenameFiles();
			}
			catch (Exception ex)
			{
				HandleException(ex);
			}
		}

		private void renameButton_Click(object sender, EventArgs e)
		{
			try
			{
				RenameFiles();

				if (clearOpsOnRenameCheckBox.Checked)
				{
					opsToDoListBox.Items.Clear();
				}
				PreviewRenameFiles();
			}
			catch (Exception ex)
			{
				HandleException(ex);
			}
		}

		private void addOpButton_Click(object sender, EventArgs e)
		{
			try
			{
			    var command = opsAvailableListBox.GetCloneFromSelected();
                
				AddCommand(command);
				PreviewRenameFilesIfEnabled();
			}
			catch (Exception ex)
			{
				HandleException(ex);
			}
		}

		private void removeOpButton_Click(object sender, EventArgs e)
		{
			try
			{
				RemoveCommand();
			}
			catch (Exception ex)
			{
				HandleException(ex);
			}
		}

		private void editOpToDoButton_Click(object sender, EventArgs e)
		{
			try
			{
				EditCommand(opsToDoListBox.SelectedCommand);
			}
			catch (Exception ex)
			{
				HandleException(ex);
			}
		}

		private void opToDoUpButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (opsToDoListBox.MoveSelectedUp())
				{
					PreviewRenameFilesIfEnabled();
				}
			}
			catch (Exception ex)
			{
				HandleException(ex);
			}
		}

		private void opToDoDownButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (opsToDoListBox.MoveSelectedDown())
				{
					PreviewRenameFilesIfEnabled();
				}
			}
			catch (Exception ex)
			{
				HandleException(ex);
			}
		}

		private void autoPreviewCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				PreviewRenameFilesIfEnabled();
			}
			catch (Exception ex)
			{
				HandleException(ex);
			}
		}

		private void fileSuffixTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				PreviewRenameFilesIfEnabled();
			}
			catch (Exception ex)
			{
				HandleException(ex);
			}
		}

		private void folderTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				PreviewRenameFilesIfEnabled();
			}
			catch (Exception ex)
			{
				HandleException(ex);
			}
		}

		private void ExceptionForm_Closed(object sender, EventArgs e)
		{
			RemoveCommand();
		}

		#endregion

		#region UI

	    private void EnableUi()
	    {
	        EnableOrDisableUi(true);
	    }

	    private void DisableUi()
	    {
	        EnableOrDisableUi(false);
	    }

		private void EnableOrDisableUi(bool enable)
		{
			addOpButton.Enabled = enable;
			browseButton.Enabled = enable;
			editOpToDoButton.Enabled = enable;
			opToDoDownButton.Enabled = enable;
			opToDoUpButton.Enabled = enable;
			previewButton.Enabled = enable;
			removeOpButton.Enabled = enable;
			renameButton.Enabled = enable;

			autoPreviewCheckBox.Enabled = enable;
			clearOpsOnRenameCheckBox.Enabled = enable;

			fileSuffixTextBox.Enabled = enable;
			folderTextBox.Enabled = enable;
		}

		private void HandleException(Exception ex)
		{
			EnableUi();
			var exceptionForm = new ExceptionForm(ex);
			exceptionForm.Closed += ExceptionForm_Closed;
			exceptionForm.Show();
		}

		#endregion

		#region Rename Files

		private void PreviewRenameFilesIfEnabled()
		{
			if (autoPreviewCheckBox.Checked)
			{
				PreviewRenameFiles();
			}
		}

		private void PreviewRenameFiles()
		{
			DoModify(folderTextBox.Text, fileSuffixTextBox.Text, false);
		}

		private void RenameFiles()
		{
			DoModify(folderTextBox.Text, fileSuffixTextBox.Text, true);
		}

		private void DoModify(string folderPath, string suffix, bool doFileRename)
		{
			previewTextBox.Clear();
			var directoryInfo = new DirectoryInfo(folderPath);

            if (!directoryInfo.Exists)
			{
                statusLabel.DisplayFolderPathIsInvalidMessage(doFileRename);
				return;
			}

			int counter = ExecuteCommandsToDo(directoryInfo, suffix, doFileRename, folderPath);

			if (doFileRename)
			{
                statusLabel.DisplayRenameSummary(counter);
			}
			else
			{
                statusLabel.DisplayPreviewSummary(counter);
			}

			previewTextBox.SelectionStart = 0;
			previewTextBox.ScrollToCaret();
		}

		private int ExecuteCommandsToDo(DirectoryInfo directoryInfo, string suffix, bool doFileRename, string folderPath)
		{
			var counter = 0;

			if (string.IsNullOrEmpty(suffix))
			{
				suffix = "*";
			}

			foreach (FileInfo file in directoryInfo.GetFiles("*." + suffix))
			{
				var originalFileName = file.Name;
				var newFileName = GetNewFileNameFor(file);

			    if (doFileRename)
				{
					File.Move(Path.Combine(folderPath, originalFileName), Path.Combine(folderPath, newFileName));
					statusLabel.Display("Renamed: '" + Path.Combine(folderPath, newFileName) + "'");
				}

				previewTextBox.AppendText(newFileName + Environment.NewLine);
				counter++;
			}

			return counter;
		}

	    private string GetNewFileNameFor(FileInfo file)
	    {
	        var newFileName = file.Name;

	        // Apply each command to the file name
	        foreach (FileRenameCommand command in opsToDoListBox.Items)
	        {
	            command.Execute(newFileName);
	            newFileName = command.Result;
	        }
	        return newFileName;
	    }

	    #endregion

		#region Add / Edit / Remove

	    private void AddCommand(FileRenameCommand command)
		{
	        if (command.GetType() == typeof (RemoveSearchTextCommand))
	        {
	            ShowNewOperationForm(new RemoveStringForm());
	        }
            else if (command.GetType() == typeof (RemovePositionTextCommand))
            {
                ShowNewOperationForm(new RemovePositionTextForm());
            }
            else if (command.GetType() == typeof(ReplaceStringCommand))
            {
                ShowNewOperationForm(new CustomReplaceForm());
            }
            else if (command.GetType() == typeof(InsertStringCommand))
            {
                ShowNewOperationForm(new InsertStringForm());
            }
            else if (command.GetType() == typeof(CutCopyPasteCommand))
            {
                ShowNewOperationForm(new CopyPasteForm());
            }
            else
            {
                opsToDoListBox.Add(command);
            }

            opsToDoListBox.SetLastSelected();
		}

		private void EditCommand(FileRenameCommand command)
		{
		    if (OperationFormFactory.HasForm(command))
		    {
		        ShowEditOperationForm(command);
		    }
		    else
		    {
		        MessageBox.Show("Operation is not editable", "Not editable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		    }
		}

		private void RemoveCommand()
		{
			opsToDoListBox.RemoveSelected();
			PreviewRenameFilesIfEnabled();
		}

		#endregion

		private void ShowNewOperationForm(OperationBaseForm form)
		{
			form.NewOperationFormEvent += newOperationDoneEventHandler;
			form.Show();
		}

		private void ShowEditOperationForm(FileRenameCommand command)
		{
            var form = _operationFormFactory.Create(command, opsToDoListBox.SelectedIndex);

			form.EditOperationFormEvent += editOperationDoneEventHandler;
			form.Show();
		}

		private void newOperationDoneEventHandler(FileRenameCommand command)
		{
			opsToDoListBox.Add(command);
			PreviewRenameFilesIfEnabled();
		}

		private void editOperationDoneEventHandler(FileRenameCommand command, int id)
		{
			opsToDoListBox.SetSelected(id);
			opsToDoListBox.Update(command, id);
			PreviewRenameFilesIfEnabled();
		}
	}
}
