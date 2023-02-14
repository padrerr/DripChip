using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace DripChip
{
    
    class DB
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=DripChipDB;Integrated Security=true");
        public void OpenConnection()
        {
            if(conn.State==System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return conn;
        }
    }
}
