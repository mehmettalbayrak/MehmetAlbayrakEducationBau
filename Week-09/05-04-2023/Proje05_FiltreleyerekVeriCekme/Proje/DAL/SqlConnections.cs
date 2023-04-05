using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DAL
{
    public static class SqlConnections
    {
        public static SqlConnection GetSqlConnection()
        {
            string connectionString = "Server=DESKTOP-E30TBPJ;Database=Northwind;User=sa;Password=123";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
