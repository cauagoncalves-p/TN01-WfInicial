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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            FormEx1 form = new FormEx1();
            form.ShowDialog();
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            FormEx2 form = new FormEx2();
            form.ShowDialog();
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            FormEx3 form = new FormEx3();
            form.ShowDialog();
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            FormEx4 form = new FormEx4();
            form.ShowDialog();
        }

        private void btnEx5_Click(object sender, EventArgs e)
        {
            FormEx5 form = new FormEx5();
            form.ShowDialog();
        }

        private void btnEx6_Click(object sender, EventArgs e)
        {
            FormEx6 form = new FormEx6();
            form.ShowDialog();
        }

        private void btnEx7_Click(object sender, EventArgs e)
        {
            FormEx7 form = new FormEx7();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEx8 form = new FormEx8();
            form.ShowDialog();
        }
    }
}
