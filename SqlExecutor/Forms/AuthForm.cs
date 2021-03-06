using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlExecutor.Utils;

namespace SqlExecutor
{
    public partial class AuthForm : Form
    {
        private string Server { get; set; }
        private string Login { get; set; }
        private string Password { get; set; }

        public AuthForm()
        {
            InitializeComponent();

            var authData = Settings.GetAuthData();
            ServerTextBox.Text = authData.Server;
            LoginTextBox.Text = authData.Login;
            PasswordTextBox.Text = authData.Password;
        }

        private void ServerTextBox_TextChanged(object sender, EventArgs e)
        {
            Server = ServerTextBox.Text.Trim();
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            Login = LoginTextBox.Text;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            Password = PasswordTextBox.Text;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            Settings.SetAuthData(new AuthData(Server, Login, Password));
            var databases = DatabaseUtil.DatabesesList(Server);

            this.Hide();
            var form = new FilesForm(Server, Login, Password, databases);
            form.Show();
        }
    }
}
