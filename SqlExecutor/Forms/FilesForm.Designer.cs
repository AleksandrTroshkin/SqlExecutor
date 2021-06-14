
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FilesTextBox = new System.Windows.Forms.TextBox();
            this.FilesButton = new System.Windows.Forms.Button();
            this.FolderButton = new System.Windows.Forms.Button();
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.IncludeCheckBox = new System.Windows.Forms.CheckBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DatabaseLabel = new System.Windows.Forms.Label();
            this.DatabaseComboBox = new System.Windows.Forms.ComboBox();
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            // 
            // FolderButton
            // 
            this.FolderButton.Location = new System.Drawing.Point(241, 237);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(94, 29);
            this.FolderButton.TabIndex = 6;
            this.FolderButton.Text = "Select";
            this.FolderButton.UseVisualStyleBackColor = true;
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
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(120, 324);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(94, 29);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
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
            // 
            // FilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 372);
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox FilesTextBox;
        private System.Windows.Forms.Button FilesButton;
        private System.Windows.Forms.Button FolderButton;
        private System.Windows.Forms.TextBox FolderTextBox;
        private System.Windows.Forms.CheckBox IncludeCheckBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label DatabaseLabel;
        private System.Windows.Forms.ComboBox DatabaseComboBox;
    }
}

