using SqlExecutor.Forms;
using SqlExecutor.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlExecutor
{
    public partial class FilesForm : Form
    {
        private string Server { get; set; }
        private string Login { get; set; }
        private string Password { get; set; }

        private string Database { get; set; }
        private string[] FileNames { get; set; }
        private string Folder { get; set; }
        private bool Subfolders { get; set; }

        public FilesForm(string server, string login, string password, IReadOnlyList<string> databeses)
        {
            Server = server;
            Login = login;
            Password = password;

            InitializeComponent();
            DatabaseComboBox.Items.AddRange(databeses.ToArray());
            DatabaseComboBox.SelectedItem = DatabaseComboBox.Items
                .Cast<string>()
                .FirstOrDefault();
        }

        private void DatabaseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database = DatabaseComboBox.SelectedItem.ToString();
        }

        private void FilesButton_Click(object sender, EventArgs e)
        {
            if (OpenFilesDialog.ShowDialog() != DialogResult.Cancel)
            {
                FileNames = OpenFilesDialog.FileNames;
                FilesTextBox.Text = string.Join(",", FileNames);
            }
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() != DialogResult.Cancel)
            {
                Folder = FolderBrowserDialog.SelectedPath;
                FolderTextBox.Text = Folder;
            }
        }

        private void IncludeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Subfolders = IncludeCheckBox.Checked;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!DatabaseUtil.Check(Server, Database, Login, Password, out var error))
            {
                ErrorLabel.Text = error;
                return;
            }

            var paths = Files.GetPaths(FileNames, Folder, Subfolders);

            this.Hide();
            var form = new ProcessForm(Server, Database, Login, Password, paths);
            form.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var form = new AuthForm();
            form.Show();
            this.Close();
        }
    }
}
