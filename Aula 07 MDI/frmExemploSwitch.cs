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
    public partial class frmExemploSwitch : Form
    {
        public frmExemploSwitch()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int opcao = Convert.ToInt32(txtOpcao.Text);

            switch (opcao)
            {
                case 1:
                    MessageBox.Show("Escolheu a opção 1");
                    break;
                case 2:
                    MessageBox.Show("Escolheu a opção 2");
                    break;
                case 3:
                    MessageBox.Show("Escolheu a opção 3");
                    break;
                case 4:
                    MessageBox.Show("Escolheu a opção 4");
                    break;
                case 5:
                    MessageBox.Show("Escolheu a opção 5");
                    break;
                default:
                    MessageBox.Show("Opção Inválida");
                    break;
            }
        }
    }
}
