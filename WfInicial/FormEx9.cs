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
    public partial class FormEx9 : Form
    {
        public FormEx9()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario us1 = new Usuario();
            bool entrou = true;
            us1.Nome = txtUsuario.Text;
            us1.Senha = txtSenha.Text;

            entrou = us1.efetuarLogin();

            if (entrou == false)
            {
                txtSenha.Text = "";
                txtUsuario.Text = "";
            }
            else {
                MessageBox.Show("Bem vindo ao sistema", "OLá", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Fecha a janela que abre depois que a senha é diferente do usuario
                this.Dispose();
            }
        }
    }
}
