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
    public partial class CadastroFuncionario : Form
    {
        private int posicao = -1;
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Veterinario_Load(object sender, EventArgs e)
        {

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
            if (txtIdade.Text.Length == 0)
            {
                MessageBox.Show("idade deve ser preenchido");
                txtIdade.Focus();
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
         
           
            if (txtRg.Text.Length == 0)
            {
                MessageBox.Show("RG deve conter 7 números");
                txtRg.Focus();
                return;
            }
         
            if (txtCpf.Text.Length == 0)
            {
                MessageBox.Show("CPF deve conter 11 números");
                txtCpf.Focus();
                return;
            }

            if (txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Informe o E-Mail");
                txtEmail.Focus();
                return;
            }

            if (rbMasculino.Checked)
            {
                MessageBox.Show("Informe o sexo");
                rbMasculino.Focus();
                return;
            }

            if (txtTelefone.Text.Length == 0)
            {
                MessageBox.Show("Telefone deve conter 10 números");
                txtTelefone.Focus();
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
                int idade = Convert.ToInt32(txtIdade.Text);
            }
            catch
            {
                MessageBox.Show("Idade deve conter somente número");
                txtIdade.Focus();
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
                int Rg = Convert.ToInt32(txtRg.Text);
            }
            catch
            {
                MessageBox.Show("RG deve conter somente número");
                txtRg.Focus();
                return;
            }
            
            try
            {
                int Cpf = Convert.ToInt32(txtCpf.Text);
            }
            catch
            {
                MessageBox.Show("CPF deve conter somente números");
                txtCpf.Focus();
                return;
            }
           
            try
            {
                string Cidade = txtCidade.Text;
            }
            catch
            {
                MessageBox.Show("Cidade deve conter somente letras");
                txtCidade.Focus();
                return;
            }
           
            try
            {
                int Telefone = Convert.ToInt32(txtTelefone.Text);
            }
            catch
            {
                MessageBox.Show("Telefone deve conter somente números");
                txtTelefone.Focus();
                return;
            }
           
            try
            {
                
                string Setor = cbSetor.Text;

            }
            catch
            {
                MessageBox.Show("informe o setor");
                cbSetor.Focus();
                return;
            }


            Funcionario funcionarios = new Funcionario()
            {
                Nome = txtNomeDaPessoa.Text,
                Idade = Convert.ToInt32(txtIdade.Text),
                Estado = cbEstado.Text,
                Cidade = txtCidade.Text,
                Telefone = Convert.ToInt32(txtTelefone.Text),
                Setor = cbSetor.Text,          
                Endereco = txtEndereco.Text,
                Cep = Convert.ToInt32(txtCep.Text),
                Rg = Convert.ToInt32(txtRg.Text),
                Cpf = Convert.ToInt32(txtCpf.Text),
                Email = txtEmail.Text,
                Masculino = rbMasculino.Checked,
                Feminino = rbFeminino.Checked,

            };

            if (posicao >= 0)
            {
                Program.funcionario[posicao] = funcionarios;
                MessageBox.Show("Você foi cadastrado");
            }
            else
            {
                Program.funcionario.Add(funcionarios);
                MessageBox.Show("Você foi cadastrado");
            }

            LimparCampos();

        }
        private void LimparCampos()
        {
            txtNomeDaPessoa.Text = "";
            txtIdade.Text = "";
            cbEstado.Text = "";
            txtCidade.Text = "";
            txtTelefone.Text = "";
            cbSetor.Text = "";       
            txtEndereco.Text = "";
            txtCep.Text = "";
            txtRg.Text = "";
            txtCpf.Text = "";
            txtEmail.Text = "";
            rbMasculino.Checked = true;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        }
    }
