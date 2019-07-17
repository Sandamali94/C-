using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentRegDatabase
{
    class DBConnection
    {
        private static SqlConnection conn = null;

        public static SqlConnection getConnection()
        {
            string connectionString = @"Data Source=LAPTOP-DIL0FP61\SQLEXPRESS;Initial Catalog=StudentManSystem;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            return conn;

        }
    }
}
