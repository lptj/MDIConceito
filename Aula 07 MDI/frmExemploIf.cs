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
    public partial class frmExemploIf : Form
    {
        public frmExemploIf()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int opcao = Convert.ToInt32(txtOpcao.Text);

            if (opcao == 1)
            {
                MessageBox.Show("Escolheu a opção 1");
            }
            else if (opcao == 2)
            {
                MessageBox.Show("Escolheu a opção 2");
            }
            else if (opcao == 3)
            {
                MessageBox.Show("Escolheu a opção 3");
            }
            else if (opcao == 4)
            {
                MessageBox.Show("Escolheu a opção 4");
            }
            else if (opcao == 5)
            {
                MessageBox.Show("Escolheu a opção 5");
            }
            else
            {
                MessageBox.Show("Opção inválida");
            }
        }
    }
}
