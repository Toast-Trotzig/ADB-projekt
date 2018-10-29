using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADB_projekt
{
    class DBsecurity
    {
        private static readonly string Login = "Integrated Security = True;server=localhost;" +
                                      "Trusted_Connection=yes;" +
                                      "database=adb;";

        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(Login);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
