using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entra21_trabalho_02
{
    public partial class CadastroVeterinario : Form
    {
        int posicao = -1;
        public CadastroVeterinario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeDaPessoa.Text.Length < 4)
            {
                MessageBox.Show("Nome da pessoa deve conter no mínimo 4 caracteres");
                txtNomeDaPessoa.Focus();
                return;
            }
            if (txtEndereco.Text.Length < 4)
            {
                MessageBox.Show("Endereço deve conter no mínimo 4 caracteres");
                txtEndereco.Focus();
                return;
            }
            if (txtIdadeAnimal.Text.Length == 0)
            {
                MessageBox.Show("idade do animal deve ser preenchido");
                txtIdadeAnimal.Focus();
                return;
            }
            if (txtCep.Text.Length == 0)
            {
                MessageBox.Show("CEP deve ser preenchido");
                txtCep.Focus();
                return;
            }
           
            if (cbEstado.Text.Length == 0)
            {
                MessageBox.Show("Informe o estado");
                cbEstado.Focus();
                return;
            }
         
           
            if (txtRaca.Text.Length == 0)
            {
                MessageBox.Show("Informe a raça");
                txtRaca.Focus();
                return;
            }
         
            if (txtSintomas.Text.Length == 0)
            {
                MessageBox.Show("Diga os sintomas");
                txtSintomas.Focus();
                return;
            }

            if (txtNomeAnimal.Text.Length == 0)
            {
                MessageBox.Show("Informe o nome do animal");
                txtNomeAnimal.Focus();
                return;
            }

            if (rbSim.Checked)
            {
                MessageBox.Show("Informe se prescisa ser buscado");
                rbSim.Focus();
                return;
            }


            if (txtEndereco.Text.Length == 0)
            {
                MessageBox.Show("Informe o endereço");
                txtEndereco.Focus();
                return;
            }
          







            try
            {
                string NomeDaPessoa = txtNomeDaPessoa.Text;
            }
            catch
            {
                MessageBox.Show("Nome da pessoa deve conter somente letras");
                txtNomeDaPessoa.Focus();
                return;
            }


            try
            {
                int IdadeAnimal = Convert.ToInt32(txtIdadeAnimal.Text);
            }
            catch
            {
                MessageBox.Show("Idade deve conter somente número");
                txtIdadeAnimal.Focus();
                return;
            }
            try
            {
                int Cep = Convert.ToInt32(txtCep.Text);
            }
            catch
            {
                MessageBox.Show("CEP deve conter números");
                txtCep.Focus();
                return;
            }
            try
            {
                string Raca = txtRaca.Text;
            }
            catch
            {
                MessageBox.Show("Raça deve conter somente letras");
                txtRaca.Focus();
                return;
            }
            
            try
            {
                string Sintomas = txtSintomas.Text;
            }
            catch
            {
                MessageBox.Show("Sintomas deve conter somente letras");
                txtSintomas.Focus();
                return;
            }
           
            try
            {
                string Endereco = txtEndereco.Text;
            }
            catch
            {
                MessageBox.Show("Endereço deve conter somente letras");
                txtEndereco.Focus();
                return;
            }
           
            try
            {
                string Estado = cbEstado.Text;
            }
            catch
            {
                MessageBox.Show("Estado deve conter somente letras");
                cbEstado.Focus();
                return;
            }
           
            try
            {
                
                string NomeAnimal = txtNomeAnimal.Text;

            }
            catch
            {
                MessageBox.Show("Nome do animal deve conter somente letras");
                txtNomeAnimal.Focus();
                return;
            }

            try 
	        {	        
		        int DiasAssim = Convert.ToInt32(txtDiasAssim.Text);
	        }
	        catch (Exception)
	        {
		        MessageBox.Show("Quantidade de dias assim deve conter somente números");
                txtDiasAssim.Focus();
		        throw;
	        }

            
            Veterinario veterinario = new Veterinario()
            {
                Nome = txtNomeDaPessoa.Text,
                Estado = cbEstado.Text,
                Sim = rbSim.Checked,
                Raca = txtRaca.Text,
                NomeAnimal = txtNomeAnimal.Text,
                Sintoma = txtSintomas.Text,
                IdadeAnimal = Convert.ToInt32(txtIdadeAnimal.Text),
                DiasAssim = Convert.ToInt32(txtDiasAssim.Text),
                Cep = Convert.ToInt32(txtCep.Text),
                Endereco = txtEndereco.Text,

            };

            if (posicao >= 0)
            {
                Program.veterinario[posicao] = veterinario;
                MessageBox.Show("Você foi cadastrado");
            }
            else
            {
                Program.veterinario.Add(veterinario);
                MessageBox.Show("Você foi cadastrado");
            }

            LimparCampos();

        }
        private void LimparCampos()
        {
            txtNomeDaPessoa.Text = "";
            txtIdadeAnimal.Text = "";
            cbEstado.Text = "";
            txtEndereco.Text = "";
            txtCep.Text = "";
            rbSim.Checked = true;
            txtNomeAnimal.Text = "";
            txtDiasAssim.Text = "";
            txtRaca.Text = "";
            txtSintomas.Text = "";


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

