using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfInicial
{
    public class Usuario
    {
        public string? Nome { get; set; }
        public string? Senha { get; set; }

        public bool efetuarLogin() 
        {
            if (Nome == Senha)
            {
                MessageBox.Show("A senha não pode ser igual ao nome de usuario!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            else {
                return true;
            } 
        }
    }
}
