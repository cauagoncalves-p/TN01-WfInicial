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
    public partial class FormEx5 : Form
    {
        public FormEx5()
        {
            InitializeComponent();
        }

        private void btnNumeros_Click_1(object sender, EventArgs e)
        {

            int num1 = int.Parse(txtNumero1.Text);
            int num2 = int.Parse(txtNumero2.Text);
            int num3 = int.Parse(txtNumero3.Text);

            if (num1 == num2 && num1 == num3)
            {
              MessageBox.Show("Os números são iguais", "EPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            else
            {
                int maior = Math.Max(num1, num2);
                maior = Math.Max(maior, num3);

                int menor = Math.Min(num1, num2);
                menor = Math.Min(menor, num3);

                string resposta = $" O numero maior é: {maior}";
                resposta += $"\nO menor numero é o {menor}";

                MessageBox.Show(resposta, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
    }
}
