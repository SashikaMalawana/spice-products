using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace appconfigtest
{
    class DBAccess
    {
        SqlConnection conn;

        public DBAccess()
        {
            conn = ConnectionManager.GetConnection();
        }

        //Method for (insert/update/delete)--> q is SQL
        public bool Modify(string q)
        {
            conn.Open();

            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = q;
                cmd.ExecuteNonQuery();

                conn.Close();
                return true; //Success message

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
                conn.Close();

                return false; //return unsucessful execution 
            }
        }

        //Method for DataSet table load
        public DataSet tableLoad(string q)
        {
            conn.Open();

            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = q;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "load");

                conn.Close();
                return ds;

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());

                //returning empty data set
                DataSet g = null;
                return g;
            }
        }
    }
}
