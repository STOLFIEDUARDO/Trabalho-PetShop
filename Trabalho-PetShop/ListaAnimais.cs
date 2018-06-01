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
    public partial class ListaAnimais : Form
    {
        public ListaAnimais()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroDeAnimais Animaiss = new CadastroDeAnimais();
            Animaiss.ShowDialog();
        }

       

        private void AtualizarLista()
        {

            dgvListaAnimais.Rows.Clear();
            for (int i = 0; i < Program.Animal.Count; i++)
            {
                Animais Animals = Program.Animal[i];
                dgvListaAnimais.Rows.Add(new object[] {
                                                    Animals.NomeDaPessoa, Animals.Altura,Animals.Peso,Animals.Idade,Animals});
            }


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void Listar_de_animal_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListaAnimais.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma linha selecionada");
                return;
            }
            int linhaSelecionada = dgvListaAnimais.CurrentRow.Index;
            Animais Animals = Program.Animal[linhaSelecionada];
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (dgvListaAnimais.CurrentRow == null)
            {
                MessageBox.Show("Nenhum campo selecionado");
                return;
            }
            int linhaSelecionada = dgvListaAnimais.CurrentRow.Index;
            DialogResult resultado = MessageBox.Show("Realmente quer apagar o registro?","AVISO",MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Program.Animal.RemoveAt(linhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Registro Apagado com sucesso");
            }
            else
            {
                MessageBox.Show("Registro foi salvo");
            }








        }

       
    }
}
