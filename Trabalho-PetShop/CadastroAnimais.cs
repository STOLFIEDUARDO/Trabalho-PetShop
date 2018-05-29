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
    public partial class CadastroAnimais : Form
    {

        private int posicao = -1;

        public CadastroAnimais()
        {
            InitializeComponent();
        }
        public CadastroAnimais(Animal anima, int posicao)
        {
           
            this.posicao = posicao;
            txtNomeAnimal.Text = anima.NomeDono;
            txtAnilha.Text = Convert.ToString(anima.Codigo);
            cbCor.SelectedItem = anima.Cor;
            cbRacao.SelectedItem = anima.Racao;
            txtObs.Text = anima.Observa;
            txtNomeDono.Text = anima.NomeAnimal;
            txtCodigo.Text = Convert.ToString(anima.CodigoAnimal);
            dtpIdade.Value = anima.Idade;
            cbRACA.SelectedItem = anima.raca;
            txtPeso.Text = Convert.ToString(anima.peso);
            txtDoenca.Text = anima.Doenca;
            txtTamanho.Text = anima.Tamanho;
                
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNomeAnimal.Text.Length < 4)
            {
                MessageBox.Show("Nome deve conter no mínimo 4 caracteres");
                txtNomeAnimal.Focus();
                return;
            }
            if (txtAnilha.Text.Length == 0)
            {
                MessageBox.Show("Valor deve ser preenchido");
                txtAnilha.Focus();
                return;
            }
            try
            {
                double Anilha = Convert.ToDouble(txtAnilha.Text);
            }
            catch
            {
                MessageBox.Show("Valor deve conter somente números reais");
                txtAnilha.Focus();
                return;
            }
        }

        
    }
}
