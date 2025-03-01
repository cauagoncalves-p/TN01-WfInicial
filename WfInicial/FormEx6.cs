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
    public partial class FormEx6 : Form
    {
        public FormEx6()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int horasTrabalhadas = Convert.ToInt32(txtHoraTrabalhada.Text);
            double salario = Convert.ToDouble(txtSalario.Text);

            double resultado = horasTrabalhadas * salario;

            MessageBox.Show($"A renda total de {nome} foi de R${resultado:F2}", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
