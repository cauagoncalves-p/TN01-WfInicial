﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfInicial
{
    public partial class FormEx3 : Form
    {
        public FormEx3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNumero1.Text);
            int num2 = int.Parse(txtNumero2.Text);

            if (num1 == num2) {
                MessageBox.Show("Os numeros são iguais", "EPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                int maior = Math.Max(num1, num2);

                string resposta = $" O numero maior é: {maior}";

                MessageBox.Show(resposta, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
