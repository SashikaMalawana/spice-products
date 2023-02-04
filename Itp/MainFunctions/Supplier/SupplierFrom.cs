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

namespace Itp.MainFunctions.Supplier
{
    public partial class SupplierFrom : Form
    {
        public SupplierFrom()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Gray, Primary.Gray, Primary.Gray, Accent.WindowsBlue, TextShade.BLACK);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Interfaces.Add a1 = new Interfaces.Add();
            a1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Interfaces.Update u1 = new Interfaces.Update();
            u1.Show();
            u1.button6.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Interfaces.Update u1 = new Interfaces.Update();
            u1.Show();
            u1.button2.Enabled = false;
            u1.button3.Enabled = false;
            u1.button4.Enabled = false;
            u1.button5.Enabled = false;
            u1.button7.Enabled = false;
            u1.button8.Enabled = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Interfaces.ScoreCard sc1 = new Interfaces.ScoreCard();
            sc1.Show();
            sc1.button2.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Interfaces.ScoreCard sc2 = new Interfaces.ScoreCard();
            sc2.Show();
            sc2.button1.Enabled = false;

        }
    }
}
