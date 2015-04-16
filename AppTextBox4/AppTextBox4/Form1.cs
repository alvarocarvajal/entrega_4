using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTextBox4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Text = " ";

            if (chkOpcion1.Checked == true)
            {
                Text = Text + " Amarillo ";
            }

            if (chkOpcion2.Checked == true)
            {
                Text = Text + " Rojo ";
            }

            if (chkOpcion3.Checked == true)
            {
                Text = Text + " Azul ";
            }

            if (chkOpcion4.Checked == true)
            {
                Text = Text + " Negro ";
            }
        }
    }
}
