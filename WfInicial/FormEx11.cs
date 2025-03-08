using System;
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
   
    public partial class FormEx11 : Form
    {
        public double[] salariosBruto = new double[5];
        public int contador = 0;
        public FormEx11()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (contador < 5)
            {
                double salarioBruto = double.Parse(txtSalario.Text);
                double salarioLiquido = salarioBruto * 0.88;
                salariosBruto[contador] = salarioLiquido;

                txtResultado.Text +=
                    $"Salario bruto: {salarioBruto} \n" +
                    $"Salario Liquido: {salarioLiquido}\n" + "\n";

                txtSalario.Text = "";

            }
            else 
            {
                MessageBox.Show("Quantidade Maxima!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            contador++;
        }
    }
}
