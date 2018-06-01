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
    public partial class CadastroDeAnimais : Form
    {
        private int posicao = -1;

        public CadastroDeAnimais()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {





            if (txtNomeDaPessoa.Text.Length < 4)
            {
                MessageBox.Show("Nome da pessoa deve conter no mínimo 4 caracteres");
                txtNomeDaPessoa.Focus();
                return;
            }
            if (txtNomeDoAnimal.Text.Length < 4)
            {
                MessageBox.Show("Nome do animal deve conter no mínimo 4 caracteres");
                txtNomeDoAnimal.Focus();
                return;
            }
            if (txtAltura.Text.Length == 0)
            {
                MessageBox.Show("Altura deve ser preenchido");
                txtAltura.Focus();
                return;
            }
            if (txtPeso.Text.Length == 0)
            {
                MessageBox.Show("Peso deve ser preenchido");
                txtPeso.Focus();
                return;
            }
           
            if (txtRaca.Text.Length < 4)
            {
                MessageBox.Show("Raça deve conter no mínimo 4 caracteres");
                txtRaca.Focus();
                return;
            }
         
           
            if (txtObserva.Text.Length == 0)
            {
                MessageBox.Show("Observação deve conter no mínimo 4 caracteres");
                txtObserva.Focus();
                return;
            }
         
            if (txtCodigoAnimal.Text.Length == 0)
            {
                MessageBox.Show("Codigo do animal deve ser preenchido");
                txtCodigoAnimal.Focus();
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
                string NomeDoAnimal = txtNomeDoAnimal.Text;
            }
            catch
            {
                MessageBox.Show("Nome do animal deve conter somente letras");
                txtNomeDoAnimal.Focus();
                return;
            }
            try
            {
                double altura = Convert.ToDouble(txtAltura.Text);
            }
            catch
            {
                MessageBox.Show("Altura deve conter numeros");
                txtAltura.Focus();
                return;
            }
            try
            {
                double peso = Convert.ToDouble(txtPeso.Text);
            }
            catch
            {
                MessageBox.Show("Peso deve conter numeros");
                txtPeso.Focus();
                return;
            }
            
            try
            {
                string Raca = txtRaca.Text;
            }
            catch
            {
                MessageBox.Show("Raca deve conter apenas letras");
                txtRaca.Focus();
                return;
            }
           
            try
            {
                int idade = Convert.ToInt32(txtIdade.Text);
            }
            catch
            {
                MessageBox.Show("Idade deve conter numeros");
                txtIdade.Focus();
                return;
            }
           
            try
            {
                string Obs = txtObserva.Text;
            }
            catch
            {
                MessageBox.Show("Observação deve conter apenas letras");
                txtObserva.Focus();
                return;
            }
           
            try
            {
                
                int Codigo = Convert.ToInt32(txtCodigoAnimal.Text);

            }
            catch
            {
                MessageBox.Show("Codigo do animal deve conter numeros");
                txtCodigoAnimal.Focus();
                return;
            }

            
            Animais Animal = new Animais()
            {
                NomeDaPessoa = txtNomeDaPessoa.Text,
                NomeDoAnimal = txtNomeDoAnimal.Text,
                Altura = Convert.ToDouble(txtAltura.Text),
                Peso = Convert.ToDouble(txtPeso.Text),
                Raca = txtRaca.Text,
                Idade = Convert.ToInt32(txtIdade.Text),          
                Obs = txtObserva.Text,
                Racao = txtRacao.Text,
                Codigo = Convert.ToInt32(txtCodigoAnimal.Text),

            };
            if (posicao >= 0)
            {
                Program.Animal[posicao] = Animal;
                MessageBox.Show("Você foi cadastrado");
            }
            else
            {
                Program.Animal.Add(Animal);
                MessageBox.Show("Você foi cadastrado");
            }

            LimparCampos();

        }
        private void LimparCampos()
        {
            txtNomeDaPessoa.Text = "";
            txtNomeDoAnimal.Text = "";
            txtAltura.Text = "";
            txtPeso.Text = "";
            txtRaca.Text = "";
            txtIdade.Text = "";       
            txtObserva.Text = "";
            txtObserva.Text = "";
            txtCodigoAnimal.Text = "";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        

        
    }
    
}
