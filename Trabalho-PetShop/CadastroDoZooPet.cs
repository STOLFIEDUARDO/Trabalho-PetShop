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
    public partial class CadastroZooPet : Form
    {

        private int posicao = -1;

        public CadastroZooPet()
        {
            InitializeComponent();
        }

        



        private void btnSalvar_Click(object sender, EventArgs e)
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
                string NomeDoPai = txtNomePai.Text;
            }
            catch
            {
                MessageBox.Show("Nome do pai deve conter apenas letras");
                txtNomePai.Focus();
                return;
            }
            try
            {
                int Idade = Convert.ToInt32(txtIdade.Text);
            }
            catch
            {
                MessageBox.Show("Idade deve conter apenas números");
                txtIdade.Focus();
                return;
            }
            try
            {
                string Serie = txtEmQualSerie.Text;
            }
            catch
            {
                MessageBox.Show("Serie deve conter apenas letras");
                txtEmQualSerie.Focus();
                return;
            }
            try
            {
                string Escola = txtEscola.Text;
            }
            catch
            {
                MessageBox.Show("Escola deve conter apenas letras");
                txtEscola.Focus();
                return;
            }
            try
            {
                string mae = txtMae.Text;
            }
            catch
            {
                MessageBox.Show("Nome da mãe deve estar preenchido");
                txtMae.Focus();
                return;
            }
            if (cbTurno.SelectedIndex < 0)
            {
                MessageBox.Show("Campo Turno deve ser preenchido");
                cbTurno.DroppedDown = true;
                return;
            }
           

            try
            {
                string cidade = txtAlergia.Text;
            }
            catch
            {
                MessageBox.Show("sem tem ou não alergia deve conter apenas letras");
                txtAlergia.Focus();
                return;
            }



            if (txtNome.Text.Length < 2)
            {
                MessageBox.Show("Nome deve conter mais de 2 letras");
                txtNome.Focus();
                return;
            }
            if (txtNomePai.Text.Length < 2)
            {
                MessageBox.Show("Nome deve conter mais de 2 letras");
                txtNomePai.Focus();
                return;
            }
            if (txtIdade.Text.Length == 0)
            {
                MessageBox.Show("idade deve ser preenchido");
                txtIdade.Focus();
                return;
            }
            if (txtEmQualSerie.Text.Length < 4)
            {
                MessageBox.Show("Serie deve ser escrito por extenso e deve conter mais de 4 letras");
                txtEmQualSerie.Focus();
                return;
            }
            if (txtEscola.Text.Length < 5)
            {
                MessageBox.Show("Escola deve conter mais de 5 letras");
                txtEscola.Focus();
                return;
            }
            if (txtMae.Text.Length < 2)
            {
                MessageBox.Show("Nome da mãe deve conter mais de 2 letras");
                txtMae.Focus();
                return;
            }

          
            if (cbTurno.SelectedIndex < 0)
            {
                MessageBox.Show("Campo Turno deve ser preenchido");
                cbTurno.DroppedDown = true;
                return;
            }

            if (txtAlergia.Text.Length < 2)
            {
                MessageBox.Show("Campo Alergia ou não deve conter mais de 2 letras");
                txtAlergia.Focus();
                return;
            }
            ZooPets Pets = new ZooPets()
            {
                nome = txtNome.Text,
                NomeDoPai = txtNomePai.Text,
                Idade = Convert.ToInt32(txtIdade.Text),
                Serie = txtEmQualSerie.Text,
                Escola = txtEscola.Text,
                Mae = txtMae.Text,
                Turno = cbTurno.SelectedItem.ToString(),
                Doenca = txtAlergia.Text,

            };
            if (posicao >= 0)
            {
                Program.Pet[posicao] = Pets;
                MessageBox.Show("Cadastro alterado com sucesso");
            }
            else
            {
                Program.Pet.Add(Pets);
                MessageBox.Show("Cadastro realizado com sucesso");
            }

            LimparCampos();

        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtNomePai.Text = "";
            txtIdade.Text = "";
            txtEmQualSerie.Text = "";
            txtEscola.Text = "";
            txtMae.Text = "";            
            cbTurno.Text = "";
            txtAlergia.Text = "";

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

      
    }
}
