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
    public partial class FormEx7 : Form
    {
        public string[] ListaNomeProdutos = new string[6];
        public double[] ListaValoresProdutos = new double[6];
        public int Contador = 0;
        public FormEx7()
        {
            InitializeComponent();
        }
       


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Contador += 1;
            ListaNomeProdutos[Contador - 1] = txtProduto.Text;
            ListaValoresProdutos[Contador - 1] = Convert.ToDouble(txtValor.Text);

            txtProduto.Text = "";
            txtValor.Text = "";

            if (Contador == 6)
            {
                double menor = ListaValoresProdutos.Min();
                int posicaoMenor = Array.IndexOf(ListaValoresProdutos, menor);
                string mensagem = $"O produto mais Barato é {ListaNomeProdutos[posicaoMenor]}" +
                    $"De valor {menor}";
                MessageBox.Show(mensagem);           
            }

        }
    }
}
