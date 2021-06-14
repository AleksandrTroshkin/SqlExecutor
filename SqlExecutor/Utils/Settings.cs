using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlExecutor.Utils
{
    public static class Settings
    {
        public static AuthData GetAuthData()
            => new AuthData
            {
                Server = Properties.Settings.Default["server"].ToString(),
                Login = Properties.Settings.Default["login"].ToString(),
                Password = Properties.Settings.Default["password"].ToString()
            };

        public static void SetAuthData(AuthData data)
        {
            Properties.Settings.Default["server"] = data.Server;
            Properties.Settings.Default["login"] = data.Login;
            Properties.Settings.Default["password"] = data.Password;
            Properties.Settings.Default.Save();
        }
    }

    public class AuthData
    {
        public AuthData() { }

        public AuthData(string server, string login, string password)
        {
            Server = server;
            Login = login;
            Password = password;
        }

        public string Server { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
