using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appconfigtest
{
    class ConnectionManager
    {
        public static SqlConnection Ncon;
        public static String ConSt = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            Ncon = new SqlConnection(ConSt);
            return Ncon;
        }
    }
}
