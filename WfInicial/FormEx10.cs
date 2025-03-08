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
    public partial class FormEx10 : Form
    {
        public FormEx10()
        {
            InitializeComponent();
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            string tabuada = "";

            for (int i = 1; i <= 10; i++)
            {
                tabuada = tabuada + $"{numero} x {i} = {numero * i}\n";
                txtResultado.Text = tabuada;
            }
        }
    }
}
