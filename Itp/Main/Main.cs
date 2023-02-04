using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itp.Main
{
    public partial class Main : Form
    {
        public Main()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
                this.panel1.Dispose();
                this.TopLevel = false;

                //this.WindowState = FormWindowState.Maximized;
                timer1.Start();


                //Set these parameters
                int tabIndex = 0;

                //load form
                if (SubFormManager.formSet[tabIndex] == null)//first time creation(consider about the array index)
                {
                    MainFunctions.Sales.SalesForm subform = new MainFunctions.Sales.SalesForm();//This is the Form that you gonna load
                    SubFormManager.formSet[tabIndex] = subform;

                    subform.TopLevel = false;
                    formContainerPanel.Controls.Add(subform);
                    subform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    subform.Dock = DockStyle.Fill;
                    subform.Show();
                }

                SubFormManager.formSet[tabIndex].BringToFront();
            }
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.timeLabel.Text = dateTime.ToString();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;

            //Set these parameters
            int tabIndex = 1;

            //load form
            if (SubFormManager.formSet[tabIndex] == null)//first time creation(consider about the array index)
            {
                MainFunctions.Employee.EmployeeForm subform = new MainFunctions.Employee.EmployeeForm();//This is the Form that you gonna load
                SubFormManager.formSet[tabIndex] = subform;//(consider about the array index)

                subform.TopLevel = false;
                formContainerPanel.Controls.Add(subform);
                subform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                subform.Dock = DockStyle.Fill;
                subform.Show();
            }

            SubFormManager.formSet[tabIndex].BringToFront();//(consider about the array index)

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;

            //Set these parameters
            int tabIndex = 0;

            //load form
            if (SubFormManager.formSet[tabIndex] == null)//first time creation(consider about the array index)
            {
                MainFunctions.Sales.SalesForm subform = new MainFunctions.Sales.SalesForm();//This is the Form that you gonna load
                SubFormManager.formSet[tabIndex] = subform;

                subform.TopLevel = false;
                formContainerPanel.Controls.Add(subform);
                subform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                subform.Dock = DockStyle.Fill;
                subform.Show();
            }

            SubFormManager.formSet[tabIndex].BringToFront();


        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;

            //Set these parameters
            int tabIndex = 2;

            //load form
            if (SubFormManager.formSet[tabIndex] == null)//first time creation(consider about the array index)
            {
                MainFunctions.Inventory.InventoryForm subform = new MainFunctions.Inventory.InventoryForm();//This is the Form that you gonna load
                SubFormManager.formSet[tabIndex] = subform;

                subform.TopLevel = false;
                formContainerPanel.Controls.Add(subform);
                subform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                subform.Dock = DockStyle.Fill;
                subform.Show();
            }

            SubFormManager.formSet[tabIndex].BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;

            //Set these parameters
            int tabIndex = 3;

            //load form
            if (SubFormManager.formSet[tabIndex] == null)//first time creation(consider about the array index)
            {
                MainFunctions.Repair.RepairForm subform = new MainFunctions.Repair.RepairForm();//This is the Form that you gonna load
                SubFormManager.formSet[tabIndex] = subform;

                subform.TopLevel = false;
                formContainerPanel.Controls.Add(subform);
                subform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                subform.Dock = DockStyle.Fill;
                subform.Show();
            }

            SubFormManager.formSet[tabIndex].BringToFront();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;

            //Set these parameters
            int tabIndex = 4;

            //load form
            if (SubFormManager.formSet[tabIndex] == null)//first time creation(consider about the array index)
            {
                MainFunctions.Finance.FinanceForm subform = new MainFunctions.Finance.FinanceForm();//This is the Form that you gonna load
                SubFormManager.formSet[tabIndex] = subform;

                subform.TopLevel = false;
                formContainerPanel.Controls.Add(subform);
                subform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                subform.Dock = DockStyle.Fill;
                subform.Show();
            }

            SubFormManager.formSet[tabIndex].BringToFront();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;

            //Set these parameters
            int tabIndex = 5;

            //load form
            if (SubFormManager.formSet[tabIndex] == null)//first time creation(consider about the array index)
            {
                MainFunctions.Delivery.DeliveryForm subform = new MainFunctions.Delivery.DeliveryForm();//This is the Form that you gonna load
                SubFormManager.formSet[tabIndex] = subform;

                subform.TopLevel = false;
                formContainerPanel.Controls.Add(subform);
                subform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                subform.Dock = DockStyle.Fill;
                subform.Show();
            }

            SubFormManager.formSet[tabIndex].BringToFront();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;

            //Set these parameters
            int tabIndex = 6;

            //load form
            if (SubFormManager.formSet[tabIndex] == null)//first time creation(consider about the array index)
            {
                MainFunctions.Supplier.SupplierFrom subform = new MainFunctions.Supplier.SupplierFrom();//This is the Form that you gonna load
                SubFormManager.formSet[tabIndex] = subform;

                subform.TopLevel = false;
                formContainerPanel.Controls.Add(subform);
                subform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                subform.Dock = DockStyle.Fill;
                subform.Show();
            }

            SubFormManager.formSet[tabIndex].BringToFront();
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
