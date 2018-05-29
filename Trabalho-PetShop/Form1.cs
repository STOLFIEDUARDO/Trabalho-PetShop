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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrar1_Click(object sender, EventArgs e)
        {
            new CadastroAnimaisBanhoEtosa().ShowDialog();
        }

        private void btCadastrar2_Click(object sender, EventArgs e)
        {
            new CadastroDeProdutos().ShowDialog();
        }

        private void btCadastrar3_Click(object sender, EventArgs e)
        {
            new CadastroFuncionario().ShowDialog();
        }

        private void btCadastrar4_Click(object sender, EventArgs e)
        {
            new CadastroDeClientes().ShowDialog();
        }

        private void btCadastrar5_Click(object sender, EventArgs e)
        {
            new Veterinario().ShowDialog();
        }

        private void btCadastrar6_Click(object sender, EventArgs e)
        {
            new CadastroAnimais().ShowDialog();
        }

        private void btCadastrar7_Click(object sender, EventArgs e)
        {
            new ZooPet().ShowDialog();
        }

        private void btCadastrar8_Click(object sender, EventArgs e)
        {
            new Adotar_pet().ShowDialog();
        }
    }
}
