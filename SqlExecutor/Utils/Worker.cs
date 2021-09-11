using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace SqlExecutor.Utils
{
    public class Worker
    {
        private string Server { get; set; }
        private string Login { get; set; }
        private string Password { get; set; }
        private string Database { get; set; }
        private ListViewLogger Logger { get; set; }

        public Worker(string server, string database, string login, string password, ListViewLogger logger)
        {
            Server = server;
            Database = database;
            Login = login;
            Password = password;
            Logger = logger;
        }

        public void Execute(string[] paths)
        {
            foreach (var path in paths)
            {
                var filename = Path.GetFileName(path);
                var index = Logger.New(path, filename);
                DatabaseUtil.Execute(Server, Database, Login, Password, path, out var error);
                if (string.IsNullOrEmpty(error))
                    Logger.Success(index);
                else
                    Logger.Fail(index, error);
            }
        }
    }
}
