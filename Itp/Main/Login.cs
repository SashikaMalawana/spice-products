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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBAccess dAcc = new DBAccess();
            dAcc.Login("SELECT username, password FROM Login WHERE username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'",this,new Main(),panel1,panel1); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
