/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;


namespace Itp
{
    class databaseAccess
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=itpdb");
        MySqlCommand cmd;

        public void InsertData(string Query)
        {
            con.Open();
             
            try
            {

                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = Query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Succesfully", "OK");
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"OK");
                con.Close();
                //MessageBox.Show(ex.Message);
            }

            
        }
        public void deleteData(string query)
        {
            con.Open();

            try
            {
                

                cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cancellation was successfull","OK");

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"OK");
                con.Close();
            }
           
      }
       
	   //load a data in a datagridview

        public void displayData(string query,DataGridView dw)
        {
            con.Open();
            try
            {

                
                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();


                DataTable dt = new DataTable();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dw.DataSource = dt;
                con.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"OK");
                con.Close();

            }
            
        }
       public void deleteSelectedRow(DataGridView dw)
        {
            int rowIndex = dw.CurrentCell.RowIndex;
            dw.Rows.RemoveAt(rowIndex);

        }
        public void deleterow(string query)
       {
           con.Open();
           cmd = con.CreateCommand();
           cmd.CommandType = System.Data.CommandType.Text;
           cmd.CommandText = query;
           cmd.ExecuteNonQuery();
           con.Close();

       }
	   
	   // get maximum ,minimum ,count
        public int getValue(string query)
        {
            con.Open();

            try
            {
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                int x = Convert.ToInt32(cmd.ExecuteScalar());
                 con.Close();
                return x;
               



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OK");
                con.Close();
                return 0;
            }
           
        }

		//get only one column 
        public string getString(string query)
        {
            con.Open();

            try
            {
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                string x=cmd.ExecuteScalar().ToString();
                con.Close();
                return x;   




            }
            catch (Exception ex)
            {
                string charc=" ";
                MessageBox.Show(ex.Message, "OK");
                con.Close();
                return charc ;
            }

        }


        public void AutoCompleteText(TextBox text,string query,string colu)
        {
            text.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            text.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            cmd = new MySqlCommand(query, con);
            MySqlDataReader myReader;

            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                while(myReader.Read())
                {
                    string cName = myReader.GetString(myReader.GetOrdinal(colu));
                    coll.Add(cName);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              
            }
            text.AutoCompleteCustomSource = coll;
            con.Close();

        }
      

        public void ComboBoxLoad(string Column,ComboBox cb,String query)
        {
            con.Open();
            

            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cb.Items.Add(dr[Column].ToString());
            }
            con.Close();

        }


        //Login method
        public void Login(string query, Form currentForm, Form loadingForm, Panel login, Panel master)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                MySqlDataReader loginReader;

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

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }

}


*/