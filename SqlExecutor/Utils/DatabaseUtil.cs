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
    public static class DatabaseUtil
    {
        public static IReadOnlyList<string> DatabesesList(string dataSource)
        {
            var connectionString = $"Data Source={dataSource}; Integrated Security=True;";
            var list = new List<string>();
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using var cmd = new SqlCommand("SELECT name from sys.databases", con);
                using var dr = cmd.ExecuteReader();
                while (dr.Read())
                    list.Add(dr[0].ToString());
            }
            return list;
        }

        private const string ConnectionString = "Data Source ={0}; Initial Catalog ={1}; User ID ={2}; Password={3}";
        public static bool Check(string server, string databese, string name, string password, out string error)
        {
            error = null;
            var connectionString = string.Format(ConnectionString, server, databese, name, password);
            try
            {
                using (var con = new SqlConnection(connectionString))
                    con.Open();

                return true;
            }
            catch (SqlException se)
            {
                error = se.Message;
                return false;
            }
        }

        public static void Execute(string server, string databese, string name, string password, string filename,
            out string error)
        {
            error = null;
            var connectionString = string.Format(ConnectionString, server, databese, name, password);
            try
            {
                var sql = File.ReadAllText(filename);
                var query = PrepareQuery(sql);
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (var command = new SqlCommand(query, con))
                        command.ExecuteNonQuery();
                }
            }
            catch (SqlException se)
            {
                error = se.Message;
                return;
            }
        }

        private static string PrepareQuery(string sql)
        {
            var usePattern = "use [";
            var goPattern = "go\r\n";

            // remove "USE [...] GO"
            var toLower = sql.ToLower();
            if (toLower.StartsWith(usePattern))
            {
                var goIndex = toLower.IndexOf(goPattern);
                sql = sql.Remove(0, goIndex + 2);
            }

            // remove all "GO"
            sql = sql.Replace("GO", string.Empty);
            sql = sql.Replace("go", string.Empty);

            return sql;
        }
    }
}
