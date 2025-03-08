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
    public partial class FormEx12 : Form
    {
        public FormEx12()
        {
            InitializeComponent();
        }

        int[] numeros = new int[20];
        int[] pares = new int[0];
        int[] impares = new int[0];
        public int contagem = 0;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            numeros[contagem] = numero;
           
            if (numero % 2 == 0)
            {
                Array.Resize(ref pares, pares.Length + 1);
                pares[contagem] = numero;
            }
            else 
            {
                Array.Resize(ref impares, pares.Length + 1);
                pares[contagem] = numero;
            }
         
            if (contagem == 20) {

                for (int i = 0; i < numeros.Length; i++) {
                    lblNumeros.Text += numeros[i] + ", ";  
                }

                for (int i = 0; i < pares.Length; i++)
                {
                    lblPar.Text += pares[i] + ", ";
                }

                for (int i = 0; i < impares.Length; i++)
                {
                    lblImpar.Text += numeros[i] + " ";
                }
            }
            contagem++;
            lblContador.Text = contagem.ToString();
            txtNumero.Text = "";

        }
    }
}
