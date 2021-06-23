
namespace SqlExecutor
{
    partial class FilesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectFilesLabel = new System.Windows.Forms.Label();
            this.SelectFolderLabel = new System.Windows.Forms.Label();
            this.OpenFilesDialog = new System.Windows.Forms.OpenFileDialog();
            this.FilesTextBox = new System.Windows.Forms.TextBox();
            this.FilesButton = new System.Windows.Forms.Button();
            this.FolderButton = new System.Windows.Forms.Button();
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.IncludeCheckBox = new System.Windows.Forms.CheckBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DatabaseLabel = new System.Windows.Forms.Label();
            this.DatabaseComboBox = new System.Windows.Forms.ComboBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectFilesLabel
            // 
            this.SelectFilesLabel.AutoSize = true;
            this.SelectFilesLabel.Location = new System.Drawing.Point(12, 109);
            this.SelectFilesLabel.Name = "SelectFilesLabel";
            this.SelectFilesLabel.Size = new System.Drawing.Size(83, 20);
            this.SelectFilesLabel.TabIndex = 0;
            this.SelectFilesLabel.Text = "Select files:";
            // 
            // SelectFolderLabel
            // 
            this.SelectFolderLabel.AutoSize = true;
            this.SelectFolderLabel.Location = new System.Drawing.Point(12, 204);
            this.SelectFolderLabel.Name = "SelectFolderLabel";
            this.SelectFolderLabel.Size = new System.Drawing.Size(114, 20);
            this.SelectFolderLabel.TabIndex = 1;
            this.SelectFolderLabel.Text = "Or select folder:";
            // 
            // OpenFilesDialog
            // 
            this.OpenFilesDialog.FileName = "openFileDialog1";
            this.OpenFilesDialog.Filter = "SQL files|*.sql";
            this.OpenFilesDialog.Multiselect = true;
            // 
            // FilesTextBox
            // 
            this.FilesTextBox.Location = new System.Drawing.Point(12, 149);
            this.FilesTextBox.Name = "FilesTextBox";
            this.FilesTextBox.Size = new System.Drawing.Size(223, 27);
            this.FilesTextBox.TabIndex = 2;
            // 
            // FilesButton
            // 
            this.FilesButton.Location = new System.Drawing.Point(241, 148);
            this.FilesButton.Name = "FilesButton";
            this.FilesButton.Size = new System.Drawing.Size(94, 29);
            this.FilesButton.TabIndex = 4;
            this.FilesButton.Text = "Select";
            this.FilesButton.UseVisualStyleBackColor = true;
            this.FilesButton.Click += new System.EventHandler(this.FilesButton_Click);
            // 
            // FolderButton
            // 
            this.FolderButton.Location = new System.Drawing.Point(241, 237);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(94, 29);
            this.FolderButton.TabIndex = 6;
            this.FolderButton.Text = "Select";
            this.FolderButton.UseVisualStyleBackColor = true;
            this.FolderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.Location = new System.Drawing.Point(12, 238);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.Size = new System.Drawing.Size(223, 27);
            this.FolderTextBox.TabIndex = 5;
            // 
            // IncludeCheckBox
            // 
            this.IncludeCheckBox.AutoSize = true;
            this.IncludeCheckBox.Location = new System.Drawing.Point(12, 282);
            this.IncludeCheckBox.Name = "IncludeCheckBox";
            this.IncludeCheckBox.Size = new System.Drawing.Size(152, 24);
            this.IncludeCheckBox.TabIndex = 7;
            this.IncludeCheckBox.Text = "Include subfolders";
            this.IncludeCheckBox.UseVisualStyleBackColor = true;
            this.IncludeCheckBox.CheckedChanged += new System.EventHandler(this.IncludeCheckBox_CheckedChanged);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(122, 363);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(94, 29);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // DatabaseLabel
            // 
            this.DatabaseLabel.AutoSize = true;
            this.DatabaseLabel.Location = new System.Drawing.Point(12, 18);
            this.DatabaseLabel.Name = "DatabaseLabel";
            this.DatabaseLabel.Size = new System.Drawing.Size(117, 20);
            this.DatabaseLabel.TabIndex = 9;
            this.DatabaseLabel.Text = "Select database:";
            // 
            // DatabaseComboBox
            // 
            this.DatabaseComboBox.FormattingEnabled = true;
            this.DatabaseComboBox.Location = new System.Drawing.Point(12, 56);
            this.DatabaseComboBox.Name = "DatabaseComboBox";
            this.DatabaseComboBox.Size = new System.Drawing.Size(323, 28);
            this.DatabaseComboBox.TabIndex = 10;
            this.DatabaseComboBox.SelectedIndexChanged += new System.EventHandler(this.DatabaseComboBox_SelectedIndexChanged);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(12, 322);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.ErrorLabel.TabIndex = 11;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 363);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(94, 29);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 409);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.DatabaseComboBox);
            this.Controls.Add(this.DatabaseLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.IncludeCheckBox);
            this.Controls.Add(this.FolderButton);
            this.Controls.Add(this.FolderTextBox);
            this.Controls.Add(this.FilesButton);
            this.Controls.Add(this.FilesTextBox);
            this.Controls.Add(this.SelectFolderLabel);
            this.Controls.Add(this.SelectFilesLabel);
            this.Name = "FilesForm";
            this.Text = "FIles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectFilesLabel;
        private System.Windows.Forms.Label SelectFolderLabel;
        private System.Windows.Forms.OpenFileDialog OpenFilesDialog;
        private System.Windows.Forms.TextBox FilesTextBox;
        private System.Windows.Forms.Button FilesButton;
        private System.Windows.Forms.Button FolderButton;
        private System.Windows.Forms.TextBox FolderTextBox;
        private System.Windows.Forms.CheckBox IncludeCheckBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label DatabaseLabel;
        private System.Windows.Forms.ComboBox DatabaseComboBox;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button BackButton;
    }
}

