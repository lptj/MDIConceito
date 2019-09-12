using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_07_MDI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPessoa objTelaPessoa = new frmCadastroPessoa(); //É necessário estanciar para poder exibir
            objTelaPessoa.MdiParent = this; // this nessa situação significa que o principal vai ser o frmPrincipal

            objTelaPessoa.Show();
        }

        private void carroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCarro objTelaCarro = new frmCadastroCarro();
            objTelaCarro.MdiParent = this;

            objTelaCarro.Show();
        }

        private void iFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExemploIf objTelaIf = new frmExemploIf();
            objTelaIf.MdiParent = this;

            objTelaIf.Show();
        }

        private void switchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExemploSwitch objTela = new frmExemploSwitch();
            objTela.MdiParent = this;

            objTela.Show();
        }
              
        private void aula07Exercício01ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAula07Ex01 objTela = new frmAula07Ex01();
            objTela.MdiParent = this;

            objTela.Show();
        }

        private void aula07Exercício02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAula07Ex02 objTela = new frmAula07Ex02();
            objTela.MdiParent = this;

            objTela.Show();
        }
    }
}
