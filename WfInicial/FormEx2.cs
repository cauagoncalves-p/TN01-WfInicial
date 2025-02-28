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
    public partial class FormEx2 : Form
    {
        public FormEx2()
        {
            InitializeComponent();
        }

        private void FormEx2_Load(object sender, EventArgs e)
        {

        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            byte opcao = byte.Parse(txtDiaSemana.Text!);

            switch (opcao)
            {
                case 1:
                    MessageBox.Show("Domingo");
                    break;
                case 2:
                    MessageBox.Show("Segunda-feira");
                    break;
                case 3:
                    MessageBox.Show("Terça-feira");
                    break;
                case 4:
                    MessageBox.Show("Quarta-feira");
                    break;
                case 5:
                    MessageBox.Show("Quinta-feira");
                    break;
                case 6:
                    MessageBox.Show("Sexta-feira");
                    break;
                case 7:
                    MessageBox.Show("Sabado");
                    break;
                default:
                    MessageBox.Show("Dia inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}