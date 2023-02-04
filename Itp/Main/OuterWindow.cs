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
    public partial class OuterWindow : Form
    {
        public OuterWindow()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            timer1.Start();

        }
        
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DBAccess dAcc = new DBAccess();
            dAcc.Login("SELECT * FROM Login WHERE username = '" + textBoxUserName.Text + "' and password = '" + textBoxPass.Text + "'", this, new Main(), panelLogin, panel5);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.timeLabel.Text = dateTime.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loadLastUser()
        {
           
        }

        private void OuterWindow_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
