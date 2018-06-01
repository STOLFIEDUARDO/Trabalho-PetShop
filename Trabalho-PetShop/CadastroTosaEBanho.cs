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
    public partial class CadastroTosaEBanho : Form
    {
        private int posicao = -1;

        public CadastroTosaEBanho()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
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
                string Medo = txtMedo.Text;
            }
            catch
            {
                MessageBox.Show("Medo de agua deve conter apenas letras");
                txtMedo.Focus();
                return;
            }
            
            try
            {
                string Escova = txtEscovação.Text;
            }
            catch
            {
                MessageBox.Show("Escovação deve conter apenas letras");
                txtEscovação.Focus();
                return;
            }

            try
            {
                string Endereco = txtEndereco.Text;
            }
            catch
            {
                MessageBox.Show("Endereco deve conter apenas letras");
                txtEndereco.Focus();
                return;
            }
           
            try
            {
                string TamanhoCorte = txtTamanhoCorte.Text;
            }
            catch
            {
                MessageBox.Show("Tipo do material deve conter apenas letras");
                txtTamanhoCorte.Focus();
                return;
            }
            try
            {
                double peso = Convert.ToDouble(txtPeso.Text);
            }
            catch
            {
                MessageBox.Show("Peso deve conter apenas números");
                txtPeso.Focus();
                return;
            }
            try
            {
                double altura = Convert.ToDouble(txtAltura.Text);
            }
            catch
            {
                MessageBox.Show("altura deve conter apenas números");
                txtAltura.Focus();
                return;
            }
            try
            {
                string RG = mtbRG.Text;
            }
            catch
            {
                MessageBox.Show("RG deve ser preenchido apenas com números");
                mtbRG.Focus();
                return;
            }
            try
            {
                string telefone = mtbTelefone.Text;
            }
            catch
            {
                MessageBox.Show("Telefone deve conter apenas números");
                mtbTelefone.Focus();
                return;
            }
           
            

            if (txtNome.Text.Length < 2)
            {
                MessageBox.Show("Nome deve conter mais de 2 letras");
                txtNome.Focus();
                return;
            }
            if (txtEndereco.Text.Length == 0)
            {
                MessageBox.Show("Endereço deve ser preenchido");
                txtEndereco.Focus();
                return;
            }
           
            if (txtTamanhoCorte.Text.Length == 0)
            {
                MessageBox.Show("Tipo do material deve ser preenchido");
                txtTamanhoCorte.Focus();
                return;
            }
            if (txtPeso.Text.Length == 0)
            {
                MessageBox.Show("Peso deve ser preenchido");
                txtPeso.Focus();
                return;
            }
            if (txtAltura.Text.Length == 0)
            {
                MessageBox.Show("Campo altura deve ser preenchido");
                txtAltura.Focus();
                return;
            }

            if (txtMedo.Text.Length < 2)
            {
                MessageBox.Show("Medo de agua ou não deve conter mais de 2 letras");
                txtMedo.Focus();
                return;
            }
            if (txtEscovação.Text.Length < 2)
            {
                MessageBox.Show("Se quer escovação ou não deve conter mais de 2 letras");
                txtEscovação.Focus();
                return;
            }
            
           
            Tosa Tosar = new Tosa()
            {
                nome = txtNome.Text,
                Endereco = txtEndereco.Text,
                TamanhoDoCorte = txtTamanhoCorte.Text,
                peso = Convert.ToDouble(txtPeso.Text),
                altura = Convert.ToDouble(txtAltura.Text),
                Escova = txtEscovação.Text,
                RG = mtbRG.Text,
                telefone = mtbTelefone.Text,
                Medo = txtMedo.Text,
               
            };
            if (posicao >= 0)
            {
                Program.Tosar[posicao] = Tosar;
                MessageBox.Show("Cadastro Alterado");
            }
            else
            {
                Program.Tosar.Add(Tosar);
                MessageBox.Show("Cadastrado com sucesso");
            }

            LimparCampos();

        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtTamanhoCorte.Text = "";
            txtPeso.Text = "";
            txtAltura.Text = "";
            txtEscovação.Text = "";
            mtbRG.Text = "";
            mtbTelefone.Text = "";
            txtMedo.Text = "";
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        
    }
}
