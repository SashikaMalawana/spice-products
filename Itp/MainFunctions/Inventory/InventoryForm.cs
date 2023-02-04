using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itp.MainFunctions.Inventory
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Gray, Primary.Gray, Primary.Gray, Accent.WindowsBlue, TextShade.BLACK);
        }
        DBAccess db;
        
        //Display all the tables when inventory page loads
        private void InventoryForm_Load(object sender, EventArgs e)
        {
            DBAccess db= new DBAccess();

            //materialId, materialName, description, category, supplierId, available
            DataSet ds1 = db.tableLoad("select materialId, materialName, description, category, supplierId, available from inventoryMaterial where status = 'on'");
            page1dataGridView1.DataSource = ds1.Tables["load"].DefaultView;

            //productId, ProductName, description, category, unitprice, available
            DataSet ds2 = db.tableLoad("select productId, ProductName, description, category, unitprice, available from inventoryProduct where status = 'on'");
            page2dataGridView1.DataSource = ds2.Tables["load"].DefaultView;

            //transactionId, materialId, materialName, description, category, supplierId, quantity, date
            DataSet ds3 = db.tableLoad("select transactionId, materialId, materialName, description, category, supplierId, quantity, date from transactionMaterial where status = 'on'");
            page3dataGridView1.DataSource = ds3.Tables["load"].DefaultView;

            //transactionId, productId, ProductName, description, category, deliveryId, unitPrice, quantity, date
            DataSet ds4 = db.tableLoad("select transactionId, productId, ProductName, description, category, deliveryId, unitPrice, quantity, date from transactionProduct where status = 'on'");
            page4dataGridView1.DataSource = ds4.Tables["load"].DefaultView;

            //productId, ProductName, available, safeQuantity
            DataSet ds5 = db.tableLoad("select productId, ProductName, available, safeQuantity from inventoryProduct where status = 'on'");
            page5dataGridView1.DataSource = ds5.Tables["load"].DefaultView;

            //materialId, materialName, available
            DataSet ds6 = db.tableLoad("select materialId, materialName, available from inventoryMaterial where status = 'on'");
            page1dataGridView2.DataSource = ds6.Tables["load"].DefaultView;

            //productId, ProductName, available
            DataSet ds7 = db.tableLoad("select productId, ProductName, available from inventoryProduct where status = 'on'");
            page2dataGridView2.DataSource = ds7.Tables["load"].DefaultView;
        }

        //inventoryMaterial page fill textfield from selected row
        private void page1dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = page1dataGridView1.Rows[index];

            page1textBox1.Text = row.Cells[0].Value.ToString();
            page1textBox2.Text = row.Cells[1].Value.ToString();
            page1textBox3.Text = row.Cells[2].Value.ToString();
            page1textBox4.Text = row.Cells[3].Value.ToString();
            page1textBox5.Text = row.Cells[4].Value.ToString();
            page1textBox6.Text = row.Cells[5].Value.ToString();
        }

        //inventoryProduct page fill textfield from selected row
        private void page2dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = page2dataGridView1.Rows[index];

            page2textBox1.Text = row.Cells[0].Value.ToString();
            page2textBox2.Text = row.Cells[1].Value.ToString();
            page2textBox3.Text = row.Cells[2].Value.ToString();
            page2textBox4.Text = row.Cells[3].Value.ToString();
            page2textBox5.Text = row.Cells[4].Value.ToString();
            page2textBox6.Text = row.Cells[5].Value.ToString();
        }

        //transactionMaterial page fill textfield from selected row
        private void page3dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = page3dataGridView1.Rows[index];

            page3textBox1.Text = row.Cells[0].Value.ToString();
            page3textBox2.Text = row.Cells[1].Value.ToString();
            page3textBox3.Text = row.Cells[2].Value.ToString();
            page3textBox4.Text = row.Cells[3].Value.ToString();
            page3textBox5.Text = row.Cells[4].Value.ToString();
            page3textBox6.Text = row.Cells[5].Value.ToString();
            page3textBox7.Text = row.Cells[6].Value.ToString();
            page3dateTimePicker1.Text = row.Cells[7].Value.ToString();
        }

        //transactionProduct page fill textfield from selected row
        private void page4dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = page4dataGridView1.Rows[index];

            page4textBox1.Text = row.Cells[0].Value.ToString();
            page4textBox2.Text = row.Cells[1].Value.ToString();
            page4textBox3.Text = row.Cells[2].Value.ToString();
            page4textBox4.Text = row.Cells[3].Value.ToString();
            page4textBox5.Text = row.Cells[4].Value.ToString();
            page4textBox6.Text = row.Cells[5].Value.ToString();
            page4textBox7.Text = row.Cells[6].Value.ToString();
            page4textBox8.Text = row.Cells[7].Value.ToString();
            page4dateTimePicker1.Text = row.Cells[8].Value.ToString();
        }

        //safetyStock page fill textfield from selected row
        private void page5dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = page5dataGridView1.Rows[index];

            page5textBox1.Text = row.Cells[0].Value.ToString();
            page5textBox2.Text = row.Cells[1].Value.ToString();
        }

        //inventoryMaterial page insert button
        private void page1button1_Click(object sender, EventArgs e)
        {
            db = new DBAccess();

            string materialId = page1textBox1.Text;
            string materialName = page1textBox2.Text;
            string description = page1textBox3.Text;
            string category = page1textBox4.Text;
            string supplierId = page1textBox5.Text;
            string available = page1textBox6.Text;

            //Validate whether text field is field
            if (page1textBox2.Text == "" || page1textBox3.Text == "" || page1textBox4.Text == "" || page1textBox5.Text == "" || page1textBox6.Text == "")
            {
                MessageBox.Show("Empty field, Please enter something in the textbox");
            }

            else
            {
                db.modify("insert into inventoryMaterial values ('" + materialName + "','" + description + "','" + category + "'," + supplierId + "," + available + ",default, default)");
                MessageBox.Show("inserted");

                //Refresh inventoryMaterial table after insert data
                DataSet ds = db.tableLoad("select materialId, materialName, description, category, supplierId, available from inventoryMaterial where status = 'on'");
                page1dataGridView1.DataSource = ds.Tables["load"].DefaultView;
            }
        }

        //inventoryMaterial page update button
        private void page1button2_Click(object sender, EventArgs e)
        {
            db = new DBAccess();

            string materialId = page1textBox1.Text;
            string materialName = page1textBox2.Text;
            string description = page1textBox3.Text;
            string category = page1textBox4.Text;
            string supplierId = page1textBox5.Text;
            string available = page1textBox6.Text;

            //db.modify("update inventoryMaterial set category = 'Liquid' where materialId = 1");
            //db.modify("update inventoryMaterial set materialName='a',description='s',category='d',supplierId=1,available=2,status='on' where materialId=5");
            db.modify("update inventoryMaterial set materialName='" +materialName +"',description='" +description +"',category='" +category +"',supplierId=" +supplierId +",available=" +available +",status='on', safeQuantity=100 where materialId=" +materialId +"");
            MessageBox.Show("Updated");

            //Refresh inventoryMaterial table after update data
            DataSet ds = db.tableLoad("select materialId, materialName, description, category, supplierId, available from inventoryMaterial where status = 'on'");
            page1dataGridView1.DataSource = ds.Tables["load"].DefaultView;
        }

        //inventoryMaterial page remove button
        private void page1button3_Click(object sender, EventArgs e)
        {
            db = new DBAccess();

            string materialId = page1textBox1.Text;
            string materialName = page1textBox2.Text;
            string description = page1textBox3.Text;
            string category = page1textBox4.Text;
            string supplierId = page1textBox5.Text;
            string available = page1textBox6.Text;

            //db.modify("update inventoryMaterial set status = 'off' where materialId = 2");
            db.modify("update inventoryMaterial set status='off' where materialId=" +materialId + "");
            MessageBox.Show("Deleted");

            //Refresh inventoryMaterial table after remove data
            DataSet ds = db.tableLoad("select materialId, materialName, description, category, supplierId, available from inventoryMaterial where status = 'on'");
            page1dataGridView1.DataSource = ds.Tables["load"].DefaultView;

            //Clear text field after remove data
            page1textBox1.Text = null;
            page1textBox2.Text = null;
            page1textBox3.Text = null;
            page1textBox4.Text = null;
            page1textBox5.Text = null;
            page1textBox6.Text = null;
        }

        //inventoryMaterial page clear button
        private void page1button4_Click(object sender, EventArgs e)
        {
            db = new DBAccess();

            page1textBox1.Text = null;
            page1textBox2.Text = null;
            page1textBox3.Text = null;
            page1textBox4.Text = null;
            page1textBox5.Text = null;
            page1textBox6.Text = null;
            page1textBox7.Text = null;
            page1textBox8.Text = null;
            page1textBox9.Text = null;

            //Refresh inventoryMaterial table after clear data
            DataSet ds1 = db.tableLoad("select materialId, materialName, description, category, supplierId, available from inventoryMaterial where status = 'on'");
            page1dataGridView1.DataSource = ds1.Tables["load"].DefaultView;
            //MessageBox.Show("Clear");

            //Refresh inventoryMaterialAvailble table after clear data
            DataSet ds2 = db.tableLoad("select materialId, materialName, available from inventoryMaterial where status = 'on'");
            page1dataGridView2.DataSource = ds2.Tables["load"].DefaultView;
        }

        //inventoryMaterial page search button
        private void page1button5_Click(object sender, EventArgs e)
        {
            db = new DBAccess();

            //string materialId = page1textBox1.Text;
            //string materialName = page1textBox2.Text;
            //string description = page1textBox3.Text;
            //string category = page1textBox4.Text;
            //string supplierId = page1textBox5.Text;
            //string available = page1textBox6.Text;
            string materialId = page1textBox7.Text;
            string materialName = page1textBox8.Text;

            //Display specific row of inventoryMaterial table after search data
            //db.modify("select * from inventoryMaterial where materialId=5");
            DataSet ds = db.tableLoad("select materialId, materialName, description, category, supplierId, available from inventoryMaterial where (materialId='" + materialId +"' or materialName='" +materialName +"') and status='on'");
            page1dataGridView1.DataSource = ds.Tables["load"].DefaultView;
            //MessageBox.Show("Search");
        }

        //inventoryMaterial page refresh button
        private void page1button6_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();

            DataSet ds1 = db.tableLoad("select materialId, materialName, description, category, supplierId, available from inventoryMaterial where status = 'on'");
            page1dataGridView1.DataSource = ds1.Tables["load"].DefaultView;

            DataSet ds2 = db.tableLoad("select materialId, materialName, available from inventoryMaterial where status = 'on'");
            page1dataGridView2.DataSource = ds2.Tables["load"].DefaultView;
        }

        //inventoryMaterial page check button
        private void page1button7_Click(object sender, EventArgs e)
        {
            db = new DBAccess();

            string materialName = page1textBox9.Text;

            DataSet ds = db.tableLoad("select materialId, materialName, available from inventoryMaterial where materialName='" + materialName + "'");
            page1dataGridView2.DataSource = ds.Tables["load"].DefaultView;
            //MessageBox.Show("Search");
        }

        //inventoryProduct page insert button
        private void page2button1_Click(object sender, EventArgs e)
        {
            db = new DBAccess();

            string productId = page2textBox1.Text;
            string productName = page2textBox2.Text;
            string description = page2textBox3.Text;
            string category = page2textBox4.Text;
            string unitprice = page2textBox5.Text;
            string available = page2textBox6.Text;

            //Validate whether text field is field
            if (page2textBox2.Text == "" || page2textBox3.Text == "" || page2textBox4.Text == "" || page2textBox5.Text == "" || page2textBox6.Text == "")
            {
                MessageBox.Show("Empty field, Please enter something in the textbox");
            }

            else
            {
                db.modify("insert into inventoryProduct values ('" + productName + "','" + description + "','" + category + "'," + unitprice + "," + available + ",default)");
                MessageBox.Show("inserted");

                //Refresh inventoryProduct table after insert data
                DataSet dd = db.tableLoad("select productId, ProductName, description, category, unitPrice, available from inventoryProduct where status = 'on'");
                page2dataGridView1.DataSource = dd.Tables["load"].DefaultView;
            }
        }

        //inventoryProduct page update button
        private void page2button2_Click(object sender, EventArgs e)
        {
            db = new DBAccess();

            string productId = page2textBox1.Text;
            string productName = page2textBox2.Text;
            string description = page2textBox3.Text;
            string category = page2textBox4.Text;
            string unitprice = page2textBox5.Text;
            string available = page2textBox6.Text;

            db.modify("update inventoryProduct set productName='" +productName +"',description='" +description +"',category='" +category +"',unitPrice=" +unitprice +",available=" +available +",status='on' where productId=" +productId +"");
            MessageBox.Show("Updated");

            //Refresh inventoryProduct table after update data
            DataSet dd = db.tableLoad("select productId, ProductName, description, category, unitPrice, available from inventoryProduct where status = 'on'");
            page2dataGridView1.DataSource = dd.Tables["load"].DefaultView;
        }

        //inventoryProduct page remove button
        private void page2button3_Click(object sender, EventArgs e)
        {
            db = new DBAccess();

            string productId = page2textBox1.Text;
            string productName = page2textBox2.Text;
            string description = page2textBox3.Text;
            string category = page2textBox4.Text;
            string unitprice = page2textBox5.Text;
            string available = page2textBox6.Text;

            db.modify("update inventoryProduct set status='off' where productId=" +productId + "");
            MessageBox.Show("Deleted");

            //Refresh inventoryProduct table after remove data
            DataSet dd = db.tableLoad("select productId, ProductName, description, category, unitPrice, available from inventoryProduct where status = 'on'");
            page2dataGridView1.DataSource = dd.Tables["load"].DefaultView;

            //Clear text field after remove data
            page2textBox1.Text = null;
            page2textBox2.Text = null;
            page2textBox3.Text = null;
            page2textBox4.Text = null;
            page2textBox5.Text = null;
            page2textBox6.Text = null;
        }

        //inventoryProduct page clear button
        private void page2button4_Click(object sender, EventArgs e)
        {
            db = new DBAccess();

            page2textBox1.Text = null;
            page2textBox2.Text = null;
            page2textBox3.Text = null;
            page2textBox4.Text = null;
            page2textBox5.Text = null;
            page2textBox6.Text = null;
            page2textBox7.Text = null;
            page2textBox8.Text = null;
            page2textBox9.Text = null;

            //Refresh inventoryProduct table after clear data
            DataSet ds1 = db.tableLoad("select productId, ProductName, description, category, unitPrice, available from inventoryProduct where status = 'on'");
            page2dataGridView1.DataSource = ds1.Tables["load"].DefaultView;
            //MessageBox.Show("Clear");

            //Refresh inventoryProductAvailable table after clear data
            DataSet ds2 = db.tableLoad("select productId, ProductName, available from inventoryProduct where status = 'on'");
            page2dataGridView2.DataSource = ds2.Tables["load"].DefaultView;
        }

        //inventoryProduct page search button
        private void page2button5_Click(object sender, EventArgs e)
        {
            db = new DBAccess();

            //string productId = page2textBox1.Text;
            //string productName = page2textBox2.Text;
            //string description = page2textBox3.Text;
            //string category = page2textBox4.Text;
            //string unitprice = page2textBox5.Text;
            //string available = page2textBox6.Text;
            string productId = page2textBox7.Text;
            string productName = page2textBox8.Text;

            //Display specific row of inventoryProduct table after search data
            DataSet ds = db.tableLoad("select productId, ProductName, description, category, unitPrice, available from inventoryProduct where (productId='" + productId + "' or productName='" + productName + "') and status='on'");
            page2dataGridView1.DataSource = ds.Tables["load"].DefaultView;
            //MessageBox.Show("Search");
        }

        //inventoryProduct page refresh button
        private void page2button6_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();

            DataSet ds1 = db.tableLoad("select productId, ProductName, description, category, unitPrice, available from inventoryProduct where status = 'on'");
            page2dataGridView1.DataSource = ds1.Tables["load"].DefaultView;

            //productId, ProductName, available
            DataSet ds2 = db.tableLoad("select productId, ProductName, available from inventoryProduct where status = 'on'");
            page2dataGridView2.DataSource = ds2.Tables["load"].DefaultView;
        }

        //inventoryProduct page check button
        private void page2button7_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();

            string productName = page2textBox9.Text;

            DataSet ds = db.tableLoad("select productId, ProductName, available from inventoryProduct where productName='" + productName + "'");
            page2dataGridView2.DataSource = ds.Tables["load"].DefaultView;
            //MessageBox.Show("Search");
        }

        //transactionMaterial page insert button
        private void page3button1_Click(object sender, EventArgs e)
        {
            db = new DBAccess();

            string transactionId = page3textBox1.Text;
            string materialId = page3textBox2.Text;
            string materialName = page3textBox3.Text;
            string description = page3textBox4.Text;
            string category = page3textBox5.Text;
            string supplierId = page3textBox6.Text;
            string quantity = page3textBox7.Text;
            //string cal = (page3monthCalendar1.SelectionRange.Start.ToString("yyyy/MM/dd"));
            string date = page3dateTimePicker1.Text;

            //Validate whether text field is field
            if (page3textBox2.Text == "" || page3textBox3.Text == "" || page3textBox4.Text == "" || page3textBox5.Text == "" || page3textBox6.Text == "" || page3textBox7.Text == "" || date == "")
            {
                MessageBox.Show("Empty field, Please enter something in the textbox");
            }
            else
            {
                db.modify("insert into transactionMaterial values (" + materialId + ",'" + materialName + "','" + description + "','" + category + "'," + supplierId + "," + quantity + ",'" + date + "',default)");
                MessageBox.Show("inserted");

                //update material transactions with quantity and available
                try
                {
                    //add material to stock ('stock in' type transaction)
                    if (page3radioButton1.Checked == true)
                    {
                        //Calculate availability after add material
                        DBAccess db1 = new DBAccess();
                        string availableString = db1.getString("select available from inventoryMaterial where materialId='" + materialId + "'");
                        int availableInteger = int.Parse(availableString);
                        MessageBox.Show("Value is " + availableString);
                        int available = availableInteger + int.Parse(quantity);
                        MessageBox.Show("Total is " + available);

                        //add updated availability to inventoryMaterial table
                        DBAccess db2 = new DBAccess();
                        db2.modify("update inventoryMaterial set available=" + available + " where materialId=" + materialId + "");
                    }
                    //remove material from stock ('stock out' type transaction)
                    if (page3radioButton2.Checked == true)
                    {
                        //Calculate availability after remove material
                        DBAccess db1 = new DBAccess();
                        //int availability = displaysal.getString("SELECT empRate FROM TableStdSalary WHERE empPosition = '" + erComboBoxAddPosition.Text + "'");
                        string availableString = db1.getString("select available from inventoryMaterial where materialId='" + materialId + "'");
                        int availableInteger = int.Parse(availableString);
                        MessageBox.Show("Value is " + availableString);
                        int available = availableInteger - int.Parse(quantity);
                        MessageBox.Show("Total is " + available);

                        //add updated availability to inventoryMaterial table
                        DBAccess db2 = new DBAccess();
                        db2.modify("update inventoryMaterial set available=" + available + " where materialId=" + materialId + "");
                    }

                    //Refresh inventoryMaterial table after insert quantity in transactionMaterial page
                    DataSet ds1 = db.tableLoad("select materialId, materialName, description, category, supplierId, available from inventoryMaterial where status = 'on'");
                    page1dataGridView1.DataSource = ds1.Tables["load"].DefaultView;

                    DataSet ds2 = db.tableLoad("select materialId, materialName, available from inventoryMaterial where status = 'on'");
                    page1dataGridView2.DataSource = ds2.Tables["load"].DefaultView;

                    //int x = Int32.Parse(TextBoxD1.Text);
                }
                catch (Exception ex)
                {

                    throw ex;
                }

                //Refresh transactionMaterial table after insert data
                DataSet ds = db.tableLoad("select transactionId, materialId, materialName, description, category, supplierId, quantity, date from transactionMaterial where status = 'on'");
                page3dataGridView1.DataSource = ds.Tables["load"].DefaultView;
            }
        }

        //transactionMaterial page update button
        private void page3button2_Click(object sender, EventArgs e)
        {
            db = new DBAccess();

            string transactionId = page3textBox1.Text;
            string materialId = page3textBox2.Text;
            string materialName = page3textBox3.Text;
            string description = page3textBox4.Text;
            string category = page3textBox5.Text;
            string supplierId = page3textBox6.Text;
            string quantity = page3textBox7.Text;
            //string cal = (page3monthCalendar1.SelectionRange.Start.ToString("yyyy/MM/dd"));
            string date = page3dateTimePicker1.Text;

            db.modify("update transactionMaterial set materialId='" + materialId + "',materialName='" + materialName + "',description='" + description + "',category='" + category + "',supplierId='" + supplierId + "',quantity='" + quantity +"',date='" +date + "',status='on' where transactionId='" + transactionId + "' ");
            MessageBox.Show("Updated");

            //Refresh transactionMaterial table after update data
            DataSet ds = db.tableLoad("select transactionId, materialId, materialName, description, category, supplierId, quantity, date from transactionMaterial where status = 'on'");
            page3dataGridView1.DataSource = ds.Tables["load"].DefaultView;
        }

        //transactionMaterial page remove button
        private void page3button3_Click(object sender, EventArgs e)
        {
            db = new DBAccess();

            string transactionId = page3textBox1.Text;
            string materialId = page3textBox2.Text;
            string materialName = page3textBox3.Text;
            string description = page3textBox4.Text;
            string category = page3textBox5.Text;
            string supplierId = page3textBox6.Text;
            string quantity = page3textBox7.Text;
            //string cal = (page3monthCalendar1.SelectionRange.Start.ToString("yyyy/MM/dd"));
            string date = page3dateTimePicker1.Text;

            db.modify("update transactionMaterial set status='off' where transactionId='" + transactionId + "' ");
            MessageBox.Show("deleted");

            //Refresh transactionMaterial table after remove data
            DataSet ds = db.tableLoad("select transactionId, materialId, materialName, description, category, supplierId, quantity, date from transactionMaterial where status = 'on'");
            page3dataGridView1.DataSource = ds.Tables["load"].DefaultView;

            //Clear text field after remove data
            page3textBox1.Text = null;
            page3textBox2.Text = null;
            page3textBox3.Text = null;
            page3textBox4.Text = null;
            page3textBox5.Text = null;
            page3textBox6.Text = null;
            page3textBox7.Text = null;
            page3dateTimePicker1.Text = null;
        }

        //transactionMaterial page clear button
        private void page3button4_Click(object sender, EventArgs e)
        {
            db = new DBAccess();

            page3textBox1.Text = null;
            page3textBox2.Text = null;
            page3textBox3.Text = null;
            page3textBox4.Text = null;
            page3textBox5.Text = null;
            page3textBox6.Text = null;
            page3textBox7.Text = null;
            page3textBox8.Text = null;
            page3textBox9.Text = null;
            page3textBox10.Text = null;
            page3dateTimePicker1.Text = null;

            //Refresh transactionMaterial table after clear data
            //(page3monthCalendar1.SelectionRange.Start.ToString("yyyy/MM/dd")) = null;
            DataSet ds = db.tableLoad("select transactionId, materialId, materialName, description, category, supplierId, quantity, date from transactionMaterial where status = 'on'");
            page3dataGridView1.DataSource = ds.Tables["load"].DefaultView;
            //MessageBox.Show("clear");
        }

        //transactionMaterial page search button
        private void page3button5_Click(object sender, EventArgs e)
        {
            db = new DBAccess();

            //string transactionId = page3textBox1.Text;
            //string materialId = page3textBox2.Text;
            //string materialName = page3textBox3.Text;
            //string description = page3textBox4.Text;
            //string category = page3textBox5.Text;
            //string supplierId = page3textBox6.Text;
            //string quantity = page3textBox7.Text;
            string transactionId = page3textBox8.Text;
            string materialId = page3textBox9.Text;
            string materialName = page3textBox10.Text;

            //Display specific row of transactionMaterial table after search data
            //db.modify("select * from transactionMaterial where materialId=5");
            DataSet ds = db.tableLoad("select transactionId, materialId, materialName, description, category, supplierId, quantity, date from transactionMaterial where (transactionId='" + transactionId + "'or materialId='" + materialId + "' or materialName='" + materialName + "') and status='on'");
            page3dataGridView1.DataSource = ds.Tables["load"].DefaultView;
            //MessageBox.Show("Search");
        }

        //transactionMaterial page refresh button
        private void page3button6_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();

            DataSet ds = db.tableLoad("select transactionId, materialId, materialName, description, category, supplierId, quantity, date from transactionMaterial where status = 'on'");
            page3dataGridView1.DataSource = ds.Tables["load"].DefaultView;
        }

        //transactionProduct page insert button
        private void page4button1_Click(object sender, EventArgs e)
        {
            db = new DBAccess();

            string transactionId = page4textBox1.Text;
            string productId = page4textBox2.Text;
            string productName = page4textBox3.Text;
            string description = page4textBox4.Text;
            string category = page4textBox5.Text;
            string deliveryId = page4textBox6.Text;
            string unitPrice = page4textBox7.Text;
            string quantity = page4textBox8.Text;
            //string cal = (page4monthCalendar1.SelectionRange.Start.ToString("yyyy/MM/dd"));
            string date = page4dateTimePicker1.Text;

            //Validate whether text field is field
            if (page4textBox2.Text == "" || page4textBox3.Text == "" || page4textBox4.Text == "" || page4textBox5.Text == "" || page4textBox6.Text == "" || page4textBox7.Text == "" || page4textBox8.Text == "" || date == "")
            {
                MessageBox.Show("Empty field, Please enter something in the textbox");
            }
            else
            {
                db.modify("insert into transactionProduct values (" + productId + ",'" + productName + "','" + description + "','" + category + "'," + deliveryId + "," + unitPrice + "," + quantity + ",'" + date + "',default)");
                MessageBox.Show("inserted");

                //update product transactions with quantity and available
                try
                {
                    //add product to stock ('stock in' type transaction)
                    if (page4radioButton1.Checked == true)
                    {
                        //Calculate availability after add product
                        DBAccess db1 = new DBAccess();
                        string availableString = db1.getString("select available from inventoryProduct where productId='" + productId + "'");
                        int availableInteger = int.Parse(availableString);
                        MessageBox.Show("Value is " + availableString);
                        int available = availableInteger + int.Parse(quantity);
                        MessageBox.Show("Total is " + available);

                        //add updated availability to inventoryProduct table
                        DBAccess db2 = new DBAccess();
                        db2.modify("update inventoryProduct set available=" + available + " where productId=" + productId + "");
                    }
                    //remove product from stock ('stock out' type transaction)
                    if (page4radioButton2.Checked == true)
                    {
                        //Calculate availability after remove product
                        DBAccess db1 = new DBAccess();
                        string availableString = db1.getString("select available from inventoryProduct where productId='" + productId + "'");
                        int availableInteger = int.Parse(availableString);
                        MessageBox.Show("Value is " + availableString);
                        int available = availableInteger - int.Parse(quantity);
                        MessageBox.Show("Total is " + available);

                        //add updated availability to inventoryProduct table
                        DBAccess db2 = new DBAccess();
                        db2.modify("update inventoryProduct set available=" + available + " where productId=" + productId + "");
                    }

                    //Refresh inventoryProduct table after insert quantity in transactionProduct page
                    DataSet ds1 = db.tableLoad("select productId, ProductName, description, category, unitprice, available from inventoryProduct where status = 'on'");
                    page2dataGridView1.DataSource = ds1.Tables["load"].DefaultView;

                    DataSet ds2 = db.tableLoad("select productId, ProductName, available from inventoryProduct where status = 'on'");
                    page2dataGridView2.DataSource = ds2.Tables["load"].DefaultView;

                    //Refresh safetySock page table after insert quantity intransactionProduct page
                    DataSet ds3 = db.tableLoad("select productId, ProductName, available, safeQuantity from inventoryProduct where status = 'on'");
                    page5dataGridView1.DataSource = ds3.Tables["load"].DefaultView;

                    //int x = Int32.Parse(TextBoxD1.Text);
                }
                catch (Exception ex)
                {

                    throw ex;
                }

                //Refresh transactionProduct table after insert data
                DataSet ds = db.tableLoad("select transactionId, productId, ProductName, description, category, deliveryId, unitPrice, quantity, date from transactionProduct where status = 'on'");
                page4dataGridView1.DataSource = ds.Tables["load"].DefaultView;
            }
        }

        //transactionProduct page update button
        private void page4button2_Click(object sender, EventArgs e)
        {
            db = new DBAccess();

            string transactionId = page4textBox1.Text;
            string productId = page4textBox2.Text;
            string productName = page4textBox3.Text;
            string description = page4textBox4.Text;
            string category = page4textBox5.Text;
            string deliveryId = page4textBox6.Text;
            string unitPrice = page4textBox7.Text;
            string quantity = page4textBox8.Text;
            //string cal = (page4monthCalendar1.SelectionRange.Start.ToString("yyyy/MM/dd"));
            string date = page4dateTimePicker1.Text;

            db.modify("update transactionProduct set productId='" + productId + "',productName='" + productName + "',description='" + description + "',category='" + category + "',deliveryId='" + deliveryId + "',quantity='" + quantity + "',date='" + date + "',status='on' where transactionId='" + transactionId + "' ");
            MessageBox.Show("Updated");

            //Refresh transactionProduct table after update data
            DataSet ds = db.tableLoad("select transactionId, productId, ProductName, description, category, deliveryId, unitPrice, quantity, date from transactionProduct where status = 'on'");
            page4dataGridView1.DataSource = ds.Tables["load"].DefaultView;
        }

        //transactionProduct page remove button
        private void page4button3_Click(object sender, EventArgs e)
        {
            db = new DBAccess();

            string transactionId = page4textBox1.Text;
            string productId = page4textBox2.Text;
            string productName = page4textBox3.Text;
            string description = page4textBox4.Text;
            string category = page4textBox5.Text;
            string deliveryId = page4textBox6.Text;
            string unitPrice = page4textBox7.Text;
            string quantity = page4textBox8.Text;
            //string cal = (page4monthCalendar1.SelectionRange.Start.ToString("yyyy/MM/dd"));

            db.modify("update transactionProduct set status='off' where transactionId='" + transactionId + "' ");
            MessageBox.Show("deleted");

            //Refresh transactionProduct table after remove data
            DataSet ds = db.tableLoad("select transactionId, productId, ProductName, description, category, deliveryId, unitPrice, quantity, date from transactionProduct where status = 'on'");
            page4dataGridView1.DataSource = ds.Tables["load"].DefaultView;

            //Clear text field after remove data
            page4textBox1.Text = null;
            page4textBox2.Text = null;
            page4textBox3.Text = null;
            page4textBox4.Text = null;
            page4textBox5.Text = null;
            page4textBox6.Text = null;
            page4textBox7.Text = null;
            page4textBox8.Text = null;
            page4dateTimePicker1.Text = null;
        }

        //transactionProduct page clear button
        private void page4button4_Click(object sender, EventArgs e)
        {
            db = new DBAccess();

            page4textBox1.Text = null;
            page4textBox2.Text = null;
            page4textBox3.Text = null;
            page4textBox4.Text = null;
            page4textBox5.Text = null;
            page4textBox6.Text = null;
            page4textBox7.Text = null;
            page4textBox8.Text = null;
            page4textBox9.Text = null;
            page4textBox10.Text = null;
            page4textBox11.Text = null;
            page4dateTimePicker1.Text = null;

            //Refresh transactionProduct table after clear data
            DataSet ds = db.tableLoad("select transactionId, productId, ProductName, description, category, deliveryId, unitPrice, quantity, date from transactionProduct where status = 'on'");
            page4dataGridView1.DataSource = ds.Tables["load"].DefaultView;
            //MessageBox.Show("clear");
        }

        //transactionProduct page search button
        private void page4button5_Click(object sender, EventArgs e)
        {
            db = new DBAccess();

            //string transactionId = page4textBox1.Text;
            //string productId = page4textBox2.Text;
            //string productName = page4textBox3.Text;
            string description = page4textBox4.Text;
            string category = page4textBox5.Text;
            string deliveryId = page4textBox6.Text;
            string unitPrice = page4textBox7.Text;
            string quantity = page4textBox8.Text;
            string transactionId = page4textBox9.Text;
            string productId = page4textBox10.Text;
            string productName = page4textBox11.Text;

            //Display specific row of transactionProduct table after search data
            DataSet ds = db.tableLoad("select transactionId, productId, ProductName, description, category, deliveryId, unitPrice, quantity, date from transactionProduct where (transactionId='" + transactionId +"' or productId='" + productId + "'or productName='" +productName + "') and status='on'");
            page4dataGridView1.DataSource = ds.Tables["load"].DefaultView;
            //MessageBox.Show("Search");
        }

        //transactionProduct page refresh button
        private void page4button6_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();

            DataSet ds = db.tableLoad("select transactionId, productId, ProductName, description, category, deliveryId, unitPrice, quantity, date from transactionProduct where status = 'on'");
            page4dataGridView1.DataSource = ds.Tables["load"].DefaultView;
        }

        //safetyStock page search button
        private void page5button1_Click(object sender, EventArgs e)
        {
            db = new DBAccess();

            string productId = page5textBox1.Text;
            string productName = page5textBox2.Text;

            //Display specific row of safetyStock table after search data
            DataSet ds = db.tableLoad("select productId, ProductName, available, safeQuantity from inventoryProduct where (productId='" + productId + "'or productName='" + productName + "') and status='on'");
            page5dataGridView1.DataSource = ds.Tables["load"].DefaultView;
            //MessageBox.Show("Search");
        }

        //safetyStock page clear button
        private void page5button2_Click_1(object sender, EventArgs e)
        {
            db = new DBAccess();

            page5textBox1.Text = null;
            page5textBox2.Text = null;

            //Refresh safetyStock table after remove data
            DataSet ds = db.tableLoad("select productId, ProductName, available, safeQuantity from inventoryProduct where status = 'on'");
            page5dataGridView1.DataSource = ds.Tables["load"].DefaultView;
            //MessageBox.Show("clear");
        }

        //safetyStock page refresh button
        private void page5button3_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();

            DataSet ds = db.tableLoad("select productId, ProductName, available, safeQuantity from inventoryProduct where status = 'on'");
            page5dataGridView1.DataSource = ds.Tables["load"].DefaultView;
        }

        //inventoryMaterial page textfield validation
        private void page1textBox1_TextChanged(object sender, EventArgs e)
        {
            string eng = page1textBox1.Text;
            if (eng.All(char.IsDigit))
            {
                page1textBox1.BackColor = Color.Gainsboro;
            }
            else
            {
                page1textBox1.BackColor = Color.Red;
            }
        }

        private void page1textBox2_TextChanged(object sender, EventArgs e)
        {
            string eng = page1textBox2.Text;
            string txt= eng.Replace(" ","");
            if (txt.All(char.IsLetter))
            {
                page1textBox2.BackColor = Color.Gainsboro;
            }
            else
            {
                page1textBox2.BackColor = Color.Red;
            }
        }

        private void page1textBox3_TextChanged(object sender, EventArgs e)
        {
            //string eng = page1textBox3.Text;
            //string txt = eng.Replace(" ", "");
            //if (txt.All(char.IsLetter))
            //{
            //    page1textBox3.BackColor = Color.Gainsboro;
            //}
            //else
            //{
            //    page1textBox3.BackColor = Color.Red;
            //}
        }

        private void page1textBox4_TextChanged(object sender, EventArgs e)
        {
            string eng = page1textBox4.Text;
            string txt = eng.Replace(" ", "");
            if (txt.All(char.IsLetter))
            {
                page1textBox4.BackColor = Color.Gainsboro;
            }
            else
            {
                page1textBox4.BackColor = Color.Red;
            }
        }

        private void page1textBox5_TextChanged(object sender, EventArgs e)
        {
            string eng = page1textBox5.Text;
            if (eng.All(char.IsDigit))
            {
                page1textBox5.BackColor = Color.Gainsboro;
            }
            else
            {
                page1textBox5.BackColor = Color.Red;
            }
        }

        private void page1textBox6_TextChanged(object sender, EventArgs e)
        {
            string eng = page1textBox6.Text;
            if (eng.All(char.IsDigit))
            {
                page1textBox6.BackColor = Color.Gainsboro;
            }
            else
            {
                page1textBox6.BackColor = Color.Red;
            }
        }

        private void page1textBox7_TextChanged(object sender, EventArgs e)
        {
            string eng = page1textBox7.Text;
            if (eng.All(char.IsDigit))
            {
                page1textBox7.BackColor = Color.Gainsboro;
            }
            else
            {
                page1textBox7.BackColor = Color.Red;
            }
        }

        private void page1textBox8_TextChanged(object sender, EventArgs e)
        {
            string eng = page1textBox8.Text;
            string txt = eng.Replace(" ", "");
            if (txt.All(char.IsLetter))
            {
                page1textBox8.BackColor = Color.Gainsboro;
            }
            else
            {
                page1textBox8.BackColor = Color.Red;
            }
        }

        private void page1textBox9_TextChanged(object sender, EventArgs e)
        {
            string eng = page1textBox9.Text;
            string txt = eng.Replace(" ", "");
            if (txt.All(char.IsLetter))
            {
                page1textBox9.BackColor = Color.Gainsboro;
            }
            else
            {
                page1textBox9.BackColor = Color.Red;
            }
        }

        //inventoryProduct page textfield validation
        private void page2textBox1_TextChanged(object sender, EventArgs e)
        {
            string eng = page2textBox1.Text;
            if (eng.All(char.IsDigit))
            {
                page2textBox1.BackColor = Color.Gainsboro;
            }
            else
            {
                page2textBox1.BackColor = Color.Red;
            }
        }

        private void page2textBox2_TextChanged(object sender, EventArgs e)
        {
            string eng = page2textBox2.Text;
            string txt = eng.Replace(" ", "");
            if (txt.All(char.IsLetter))
            {
                page2textBox2.BackColor = Color.Gainsboro;
            }
            else
            {
                page2textBox2.BackColor = Color.Red;
            }
        }

        private void page2textBox3_TextChanged(object sender, EventArgs e)
        {
            //string eng = page2textBox3.Text;
            //if (eng.All(char.IsLetter))
            //{
            //    page2textBox3.BackColor = Color.Gainsboro;
            //}
            //else
            //{
            //    page2textBox3.BackColor = Color.Red;
            //}
        }

        private void page2textBox4_TextChanged(object sender, EventArgs e)
        {
            string eng = page2textBox4.Text;
            string txt = eng.Replace(" ", "");
            if (txt.All(char.IsLetter))
            {
                page2textBox4.BackColor = Color.Gainsboro;
            }
            else
            {
                page2textBox4.BackColor = Color.Red;
            }
        }

        private void page2textBox5_TextChanged(object sender, EventArgs e)
        {
            string eng = page2textBox5.Text;
            if (eng.All(char.IsDigit))
            {
                page2textBox5.BackColor = Color.Gainsboro;
            }
            else
            {
                page2textBox5.BackColor = Color.Red;
            }
        }

        private void page2textBox6_TextChanged(object sender, EventArgs e)
        {
            string eng = page2textBox6.Text;
            if (eng.All(char.IsDigit))
            {
                page2textBox6.BackColor = Color.Gainsboro;
            }
            else
            {
                page2textBox6.BackColor = Color.Red;
            }
        }

        private void page2textBox7_TextChanged(object sender, EventArgs e)
        {
            string eng = page2textBox7.Text;
            if (eng.All(char.IsDigit))
            {
                page2textBox7.BackColor = Color.Gainsboro;
            }
            else
            {
                page2textBox7.BackColor = Color.Red;
            }
        }

        private void page2textBox8_TextChanged(object sender, EventArgs e)
        {
            string eng = page2textBox8.Text;
            string txt = eng.Replace(" ", "");
            if (txt.All(char.IsLetter))
            {
                page2textBox8.BackColor = Color.Gainsboro;
            }
            else
            {
                page2textBox8.BackColor = Color.Red;
            }
        }

        private void page2textBox9_TextChanged(object sender, EventArgs e)
        {
            string eng = page2textBox9.Text;
            string txt = eng.Replace(" ", "");
            if (txt.All(char.IsLetter))
            {
                page2textBox9.BackColor = Color.Gainsboro;
            }
            else
            {
                page2textBox9.BackColor = Color.Red;
            }
        }

        //transactionMaterial page textfield validation
        private void page3textBox1_TextChanged(object sender, EventArgs e)
        {
            string eng = page3textBox1.Text;
            if (eng.All(char.IsDigit))
            {
                page3textBox1.BackColor = Color.Gainsboro;
            }
            else
            {
                page3textBox1.BackColor = Color.Red;
            }
        }

        private void page3textBox2_TextChanged(object sender, EventArgs e)
        {
            string eng = page3textBox2.Text;
            if (eng.All(char.IsDigit))
            {
                page3textBox2.BackColor = Color.Gainsboro;
            }
            else
            {
                page3textBox2.BackColor = Color.Red;
            }
        }

        private void page3textBox3_TextChanged(object sender, EventArgs e)
        {
            string eng = page3textBox3.Text;
            string txt = eng.Replace(" ", "");
            if (txt.All(char.IsLetter))
            {
                page3textBox3.BackColor = Color.Gainsboro;
            }
            else
            {
                page3textBox3.BackColor = Color.Red;
            }
        }

        private void page3textBox4_TextChanged(object sender, EventArgs e)
        {
            //string eng = page3textBox4.Text;
            //if (eng.All(char.IsLetter))
            //{
            //    page3textBox4.BackColor = Color.Gainsboro;
            //}
            //else
            //{
            //    page3textBox4.BackColor = Color.Red;
            //}
        }

        private void page3textBox5_TextChanged(object sender, EventArgs e)
        {
            string eng = page3textBox5.Text;
            string txt = eng.Replace(" ", "");
            if (txt.All(char.IsLetter))
            {
                page3textBox5.BackColor = Color.Gainsboro;
            }
            else
            {
                page3textBox5.BackColor = Color.Red;
            }
        }

        private void page3textBox6_TextChanged(object sender, EventArgs e)
        {
            string eng = page3textBox6.Text;
            if (eng.All(char.IsDigit))
            {
                page3textBox6.BackColor = Color.Gainsboro;
            }
            else
            {
                page3textBox6.BackColor = Color.Red;
            }
        }

        private void page3textBox7_TextChanged(object sender, EventArgs e)
        {
            string eng = page3textBox7.Text;
            if (eng.All(char.IsDigit))
            {
                page3textBox7.BackColor = Color.Gainsboro;
            }
            else
            {
                page3textBox7.BackColor = Color.Red;
            }
        }

        private void page3textBox8_TextChanged(object sender, EventArgs e)
        {
            string eng = page3textBox8.Text;
            if (eng.All(char.IsDigit))
            {
                page3textBox8.BackColor = Color.Gainsboro;
            }
            else
            {
                page3textBox8.BackColor = Color.Red;
            }
        }

        private void page3textBox9_TextChanged(object sender, EventArgs e)
        {
            string eng = page3textBox9.Text;
            if (eng.All(char.IsDigit))
            {
                page3textBox9.BackColor = Color.Gainsboro;
            }
            else
            {
                page3textBox9.BackColor = Color.Red;
            }
        }

        private void page3textBox10_TextChanged(object sender, EventArgs e)
        {
            string eng = page3textBox10.Text;
            string txt = eng.Replace(" ", "");
            if (txt.All(char.IsLetter))
            {
                page3textBox10.BackColor = Color.Gainsboro;
            }
            else
            {
                page3textBox10.BackColor = Color.Red;
            }
        }

        //transactionProduct page textfield validation
        private void page4textBox1_TextChanged(object sender, EventArgs e)
        {
            string eng = page4textBox1.Text;
            if (eng.All(char.IsDigit))
            {
                page4textBox1.BackColor = Color.Gainsboro;
            }
            else
            {
                page4textBox1.BackColor = Color.Red;
            }
        }

        private void page4textBox2_TextChanged(object sender, EventArgs e)
        {
            string eng = page4textBox2.Text;
            if (eng.All(char.IsDigit))
            {
                page4textBox2.BackColor = Color.Gainsboro;
            }
            else
            {
                page4textBox2.BackColor = Color.Red;
            }
        }

        private void page4textBox3_TextChanged(object sender, EventArgs e)
        {
            string eng = page4textBox3.Text;
            string txt = eng.Replace(" ", "");
            if (txt.All(char.IsLetter))
            {
                page4textBox3.BackColor = Color.Gainsboro;
            }
            else
            {
                page4textBox3.BackColor = Color.Red;
            }
        }

        private void page4textBox4_TextChanged(object sender, EventArgs e)
        {
            //string eng = page4textBox4.Text;
            //if (eng.All(char.IsLetter))
            //{
            //    page4textBox4.BackColor = Color.Gainsboro;
            //}
            //else
            //{
            //    page4textBox4.BackColor = Color.Red;
            //}
        }

        private void page4textBox5_TextChanged(object sender, EventArgs e)
        {
            string eng = page4textBox5.Text;
            string txt = eng.Replace(" ", "");
            if (txt.All(char.IsLetter))
            {
                page4textBox5.BackColor = Color.Gainsboro;
            }
            else
            {
                page4textBox5.BackColor = Color.Red;
            }
        }

        private void page4textBox6_TextChanged(object sender, EventArgs e)
        {
            string eng = page4textBox6.Text;
            if (eng.All(char.IsDigit))
            {
                page4textBox6.BackColor = Color.Gainsboro;
            }
            else
            {
                page4textBox6.BackColor = Color.Red;
            }
        }

        private void page4textBox7_TextChanged(object sender, EventArgs e)
        {
            string eng = page4textBox7.Text;
            if (eng.All(char.IsDigit))
            {
                page4textBox7.BackColor = Color.Gainsboro;
            }
            else
            {
                page4textBox7.BackColor = Color.Red;
            }
        }

        private void page4textBox8_TextChanged(object sender, EventArgs e)
        {
            string eng = page4textBox8.Text;
            if (eng.All(char.IsDigit))
            {
                page4textBox8.BackColor = Color.Gainsboro;
            }
            else
            {
                page4textBox8.BackColor = Color.Red;
            }
        }

        private void page4textBox9_TextChanged(object sender, EventArgs e)
        {
            string eng = page4textBox9.Text;
            if (eng.All(char.IsDigit))
            {
                page4textBox9.BackColor = Color.Gainsboro;
            }
            else
            {
                page4textBox9.BackColor = Color.Red;
            }
        }

        private void page4textBox10_TextChanged(object sender, EventArgs e)
        {
            string eng = page4textBox10.Text;
            if (eng.All(char.IsDigit))
            {
                page4textBox10.BackColor = Color.Gainsboro;
            }
            else
            {
                page4textBox10.BackColor = Color.Red;
            }
        }

        private void page4textBox11_TextChanged(object sender, EventArgs e)
        {
            string eng = page4textBox11.Text;
            string txt = eng.Replace(" ", "");
            if (txt.All(char.IsLetter))
            {
                page4textBox11.BackColor = Color.Gainsboro;
            }
            else
            {
                page4textBox11.BackColor = Color.Red;
            }
        }

        //safetyStock page textfield validation
        private void page5textBox1_TextChanged(object sender, EventArgs e)
        {
            string eng = page5textBox1.Text;
            if (eng.All(char.IsDigit))
            {
                page5textBox1.BackColor = Color.Gainsboro;
            }
            else
            {
                page5textBox1.BackColor = Color.Red;
            }
        }

        private void page5textBox2_TextChanged(object sender, EventArgs e)
        {
            string eng = page5textBox2.Text;
            string txt = eng.Replace(" ", "");
            if (txt.All(char.IsLetter))
            {
                page5textBox2.BackColor = Color.Gainsboro;
            }
            else
            {
                page5textBox2.BackColor = Color.Red;
            }
        }
    }
}