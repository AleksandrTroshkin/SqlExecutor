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

namespace SqlExecutor.Forms
{
    public partial class ProcessForm : Form
    {
        private string Server { get; set; }
        private string Login { get; set; }
        private string Password { get; set; }
        private string Database { get; set; }
        private string[] Paths { get; set; }

        public ProcessForm(string server, string database, string login, string password, IReadOnlyList<string> paths)
        {
            InitializeComponent();
            Server = server;
            Database = database;
            Login = login;
            Password = password;
            Paths = paths.ToArray();

            Work();
        }

        private void Work()
        {
            var logger = new ListViewLogger(ProcessingListView);
            var worker = new Worker(Server, Database, Login, Password, logger);
            worker.Execute(Paths);
            StatusLabel.Text = "DONE";
        }
    }
}
