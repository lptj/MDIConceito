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
    public partial class frmAula07Ex01 : Form
    {
        public frmAula07Ex01()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int opcao = Convert.ToInt32(txtOpcao.Text);

            switch (opcao)
            {
                case 1:
                    MessageBox.Show("Domingo");
                    break;
                case 2:
                    MessageBox.Show("Segunda");
                    break;
                case 3:
                    MessageBox.Show("Terça");
                    break;
                case 4:
                    MessageBox.Show("Quarta");
                    break;
                case 5:
                    MessageBox.Show("Quinta");
                    break;
                case 6:
                    MessageBox.Show("Sexta");
                    break;
                case 7:
                    MessageBox.Show("Sabado");
                    break;
                default:
                    MessageBox.Show("Opção Inválida");
                    break;
            }
        }
    }
}
