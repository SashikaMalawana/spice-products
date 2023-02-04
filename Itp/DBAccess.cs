using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Itp
{
    class DBAccess
    {
        SqlConnection conn;
        SqlCommand command;

        public DBAccess()
        {
            conn = ConnectionManager.GetConnection();
        }

        public static void formatQuery()
        {

        }

        //Method for (insert/update/delete)--> q is SQL
        public bool modify(string q)
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
                conn.Close();

                return g;

                
            }
        }

        //get only one column
        public string getString(string q)
        {
            conn.Open();

            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = q;

                string strOut = cmd.ExecuteScalar().ToString();
                conn.Close();

                return strOut;

            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message, "OK");
                conn.Close();
                return "";
            }
        }

        //Login method
        public void Login(string query, Form currentForm, Form loadingForm, Panel login, Panel master)
        {
            
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader loginReader;

                loginReader = cmd.ExecuteReader();
                int userCount = 0;

                while (loginReader.Read())
                {
                    userCount++;
                }
                if (userCount == 1)
                {
                    //MessageBox.Show("Correct User");
                    login.Dispose();
                    master.Controls.Add(loadingForm);
                    loadingForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    loadingForm.Dock = DockStyle.Fill;
                    loadingForm.Show();
                    loadingForm.BringToFront();

                }
                else if (userCount > 1)//if there are duplicate users
                {
                    MessageBox.Show("Dublicates");
                }
                else
                {
                    MessageBox.Show("incorrect");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        public void ComboBoxLoad(string Column, ComboBox cb, String query)
        {
            conn.Open();
            try {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    cb.Items.Add(dr[Column].ToString());
                }
                conn.Close();
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.ToString());
                conn.Close();
            }

        }

        //insert image
        public void insertImage(string sql,Byte[] imgbt)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader;
                cmd.Parameters.Add(new SqlParameter("@IMG", imgbt));
                reader = cmd.ExecuteReader();
                MessageBox.Show("Saved");

                conn.Close();
                
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
                conn.Close();
            }
        }

        //get image
        public void getImage(string sqlQuery, PictureBox picBox, string imageColumnName)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    byte[] imagg = (byte[])(reader[imageColumnName]);

                    if (imagg == null)
                    {
                        picBox.Image = null;
                    }
                    else
                    {
                        MemoryStream mStream = new MemoryStream(imagg);
                        picBox.Image = System.Drawing.Image.FromStream(mStream);
                    }

                }

                conn.Close();

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
                conn.Close();
            }
            
        }
    }
}
