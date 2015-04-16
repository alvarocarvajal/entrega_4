using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppText2
{
    public partial class From : Form
    {
        public From()
        {
            InitializeComponent();

            txtClave.MaxLength = 10;
            txtClave.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btbVerificar_Click(object sender, EventArgs e)
        {

           MessageBox.Show(txtClave.Text);
            
        }
    }
}
