﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTextBox
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

        private void btnSumar_Click(object sender, EventArgs e)
        {
            double numero1, numero2, suma;
            numero1 = double.Parse(txtNumero1.Text);
            numero2 = double.Parse(txtNumero2.Text);
            suma = numero1 + numero2;

            lblResultado.Text = "El Resultado De La Suma Es: " + suma;
        }
    }
}
