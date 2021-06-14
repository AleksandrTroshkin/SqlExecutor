using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SqlExecutor.Database
{
    public static class DatabaseUtil
    {
        private const string ConnectionString = "Data Source ={0}; Initial Catalog ={1}; User ID ={2}; Password={3}";

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
    }
}
