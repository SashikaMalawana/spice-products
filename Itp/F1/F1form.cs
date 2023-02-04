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

namespace Itp.F1
{
    public partial class F1form : Form
    {
        public F1form()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Gray, Primary.Gray, Primary.Gray, Accent.WindowsBlue, TextShade.BLACK);
        }
    }
}
