using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using Itp.MainFunctions.Sales.Views;
using Itp.MainFunctions.Sales.Presenters;


namespace Itp.MainFunctions.Sales
{
    public partial class SalesForm : Form,IItemDetails
    {
        string itemNo;
        string itemName;
        string description;
        string unitPrice;
        string quantity;
        string totalPrice;

        public string ItemNoText
        {
            get
            {
                return textBoxItemNo.Text;
            }

            set
            {
                textBoxItemNo.Text = value;
            }
        }

        public string ItemNameText
        {
            get
            {
                return textBoxItemName.Text;
            }

            set
            {
                textBoxItemName.Text = value;
            }
        }

        public string DescriptionText
        {
            get
            {
                return textBoxDescription.Text;
            }

            set
            {
                textBoxDescription.Text = value;
            }
        }

        public string UnitPriceText
        {
            get
            {
                return labelUnitPriceValue.Text;
            }

            set
            {
                labelUnitPriceValue.Text = value;
            }
        }

        public string QuantityText
        {
            get
            {
                return textBoxQty.Text;
            }

            set
            {
                textBoxQty.Text = value;
            }
        }

        public string TotalPriceText
        {
            get
            {
                return labelTotalPriceVal.Text;
            }

            set
            {
                labelTotalPriceVal.Text = value;
            }
        }

        public SalesForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Gray, Primary.Gray, Primary.Gray, Accent.WindowsBlue, TextShade.BLACK);

            //foreach (Control c in this.materialTabControl1.TabPages)
            //{
            //    c.BackColor = ColorTheme.tabPageBack;
            //    if (c is TabPage)
            //}

            tableLoad();

            //fill comboBox
            new DBAccess().ComboBoxLoad("status_name", comboBoxStatus, "SELECT * FROM Invc_status");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewClient clientForm = new NewClient();//This is the Form that you gonna load      
            clientForm.ShowDialog();
            clientForm.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewInvoice invoiceForm = new NewInvoice();//This is the Form that you gonna load      
            invoiceForm.ShowDialog();
            invoiceForm.BringToFront();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewClient clientForm = new NewClient();//This is the Form that you gonna load      
            clientForm.ShowDialog();
            clientForm.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string doi          = dateTimePickerDOI.Text;
            string cus_id       = findClientID(comboBoxBillTo.Text);
            string status       = comboBoxStatus.Text;
            string sub          = textBoxSubTotal.Text; // calcSubTot().ToString();
            string discount     = textBoxDiscount.Text;
            string end_total    = labelEndTotalValue.Text;
            //string approve    = ; //Not expexted to pass from here
            string item_list    = getListId().ToString();   

            string sql = "INSERT INTO Invoice (doi,cus_id,status,sub,discount,end_total,item_list)"+
                         "VALUES('"+doi+"',"+cus_id+",'"+status+"',"+sub+","+discount+","+end_total+");";
            DBAccess db = new DBAccess();
            db.modify(sql);

            MessageBox.Show("Saved Successfully!");

        }

        private string findClientID(string name)
        {

            DBAccess db = new DBAccess();

            return db.getString("SELECT cus_id FROM Customer WHERE cus_name ='" + name + "'");
           
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewItemList.Rows[0].Clone();
            row.Cells[0].Value = textBoxItemNo.Text;
            row.Cells[1].Value = textBoxItemName.Text;
            row.Cells[2].Value = labelUnitPriceValue.Text;
            row.Cells[3].Value = textBoxQty.Text;
            row.Cells[4].Value = labelTotalPriceVal.Text;
            dataGridViewItemList.Rows.Add(row);

        }

        private void tableLoad()
        {
            try
            {
                DBAccess db = new DBAccess();
                DataSet ds = db.tableLoad("select * from Invoice");
                ds.Tables["load"].Columns[1].ColumnName = "sdff";

                dataGridViewInvoices.Columns.Clear();//clears initially added colums to table
                dataGridViewInvoices.DataSource = ds.Tables["load"].DefaultView;
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }

        }

        private void buttonSearchInvoice_Click(object sender, EventArgs e)
        {
            tableLoad();
        }

        public double calcSubTot()
        {
            //need to implement
            return 123.3;
        }

        public int getListId()
        {
            
            //List id should get from --> Items List
            return 23;
        }

        private void textBoxQty_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
            if (new Validation().isNumeric(((TextBox)sender).Text))
            {

                new ItemDetailsPresenter(this).updateTotalPrice();

            }
            else
            {
                ((TextBox)sender).BackColor = Color.Red;
                MessageBox.Show("please enter numeric:");
            }
            
        }
    }
}
