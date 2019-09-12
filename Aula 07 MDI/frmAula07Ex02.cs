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
    public partial class frmAula07Ex02 : Form
    {
        public frmAula07Ex02()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int opcao = Convert.ToInt32(txtOpcao.Text);

            switch (opcao)
            {
                case 1:
                    MessageBox.Show("Janeiro");
                    break;
                case 2:
                    MessageBox.Show("Fevereiro");
                    break;
                case 3:
                    MessageBox.Show("Março");
                    break;
                case 4:
                    MessageBox.Show("Abril");
                    break;
                case 5:
                    MessageBox.Show("Maio");
                    break;
                case 6:
                    MessageBox.Show("Junho");
                    break;
                case 7:
                    MessageBox.Show("Julho");
                    break;
                case 8:
                    MessageBox.Show("Agosto");
                    break;
                case 9:
                    MessageBox.Show("Setembro");
                    break;
                case 10:
                    MessageBox.Show("Outubro");
                    break;
                case 11:
                    MessageBox.Show("Novembro");
                    break;
                case 12:
                    MessageBox.Show("Dezembro");
                    break;
                default:
                    MessageBox.Show("Opção Inválida");
                    break;
            }
        }
    }
}
