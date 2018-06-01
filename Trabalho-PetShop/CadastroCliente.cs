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
    public partial class CadastroCliente : Form
    {
        private int posicao = -1;

        public CadastroCliente()
        {
            InitializeComponent();
        }

        

        private void btnSalvar_Click(object sender, EventArgs e)
            {
            if (txtNome.Text.Length < 2)
            {
                MessageBox.Show("Nome deve conter no minímo 2 caracteres");
                txtNome.Focus();
                return;
            }
            
            if (txtAltura.Text.Length == 0)
            {
                MessageBox.Show("Altura deve ser preenchido");
                txtAltura.Focus();
                return;
            }
            if (txtEmail.Text.Length == 0)
            {
                MessageBox.Show("E-mail deve ser preenchido");
                txtEmail.Focus();
                return;
            }
            if (mtbTelefone.Text.Length == 0)
            {
                MessageBox.Show("Telefone deve ser preenchido");
                mtbTelefone.Focus();
                return;
            }
            if (txtCidade.Text.Length == 0)
            {
                MessageBox.Show("Cidade deve ser rpeenchido");
                txtCidade.Focus();
                return;
            }
            if (cbEstado.SelectedIndex < 0)
            {
                MessageBox.Show("Estado deve ser preenchido");
                cbEstado.DroppedDown = true;
                return;
            }
            if (txtBichinho.Text.Length == 0)
            {
                MessageBox.Show("Bichinho deve ser preenchido");
                txtBichinho.Focus();
                return;
            }


            try
            {
                string nome = txtNome.Text;
            }
            catch
            {
                MessageBox.Show("Nome deve conter apenas letras");
                txtNome.Focus();
                return;
            }
            try
            {
                double altura =Convert.ToDouble(txtAltura.Text);
            }
            catch
            {
                MessageBox.Show("Altura deve conter apenas números");
                txtAltura.Focus();
                return;
            }
            try
            {
                string cidade = txtCidade.Text;
            }
            catch
            {
                MessageBox.Show("Cidade deve conter apenas letras");
                txtCidade.Focus();
                return;
            }
            try
            {
                string marca = txtBichinho.Text;
            }
            catch
            {
                MessageBox.Show("Bichinho deve conter apenas letras");
                txtBichinho.Focus();
                return;
            }

            Cliente Clientes = new Cliente()
            {
                Nome = txtNome.Text,                
                Altura = Convert.ToDouble(txtAltura.Text),
                Telefone = mtbTelefone.Text,
                Cidade = txtCidade.Text,
                Estado = cbEstado.SelectedIndex.ToString(),
                Bicho = txtBichinho.Text,
                Email = txtEmail.Text,
            };
            if (posicao >= 0)
            {
                Program.Client[posicao] = Clientes;
                MessageBox.Show("Você foi cadastrado");
            }
            else
            {
                Program.Client.Add(Clientes);
                MessageBox.Show("Você foi cadastrado");
            }

              


            }
                private void ListarCampos()
                {
                   txtNome.Text = "";
                   txtAltura.Text = "";
                   txtEmail.Text = "";
                   mtbTelefone.Text = "";
                   txtCidade.Text = "";
                   cbEstado.SelectedIndex = -1;
                   txtBichinho.Text = "";
                }

           private void btnCancelar_Click(object sender, EventArgs e)
           {
               Dispose();
           }

       
        }
    }
