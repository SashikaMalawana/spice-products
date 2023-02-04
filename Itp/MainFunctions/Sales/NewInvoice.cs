using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itp.MainFunctions.Sales
{
    public partial class NewInvoice : Form
    {
        public NewInvoice()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewClient clientForm = new NewClient();//This is the Form that you gonna load      
            clientForm.ShowDialog();
            clientForm.BringToFront();
        }
    }
}
