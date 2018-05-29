using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_PetShop
{
    public partial class CadastroDeClientes : Form
    {


        public CadastroDeClientes()
        {
            InitializeComponent();
        }

        private void btnRegistrar(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNomeCliente.Text;
            }
            catch 
            {
                MessageBox.Show("Só letra no nome");
                txtNomeCliente.Focus();
                return;
            }
            try
            {
                string cidade = txtCidadeCliente.Text;
            }
            catch 
            {
                MessageBox.Show("Só letra na cidade");
                txtCidadeCliente.Focus();
                return;
            }

        }
    }
}
    
