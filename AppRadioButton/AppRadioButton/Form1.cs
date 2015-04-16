using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float numero1, numero2, suma, resta, multiplicacion, division;

            numero1 = float.Parse(txtNumero1.Text);
            numero2 = float.Parse(txtNumero2.Text);

            suma = numero1 + numero2;
            resta = numero1 - numero2;
            multiplicacion = numero1 * numero2;
            division = numero1 / numero2;



            if (rdbOpcion1.Checked == true)
            {
                txtResultado.Text = suma.ToString();
            }

            if (rdbOpcion2.Checked == true)
            {
                txtResultado.Text = resta.ToString();
            }

            if (rdbOpcion3.Checked == true)
            {
                txtResultado.Text = multiplicacion.ToString();
            }

            if (rdbOpcion4.Checked == true)
            {
                txtResultado.Text = division.ToString();
            }
        }
    }
}
