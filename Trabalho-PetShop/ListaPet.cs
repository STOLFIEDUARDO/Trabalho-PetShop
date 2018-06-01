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
    public partial class ListaPet : Form
    {
        public ListaPet()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroZooPet pet = new CadastroZooPet();
            pet.ShowDialog();
        }

        private void AtualizarLista()
        {
            dgvListaPeca.Rows.Clear();
            for (int i = 0; i < Program.Pet.Count; i++)
            {
                ZooPets Pet = Program.Pet[i];
                dgvListaPeca.Rows.Add(new object[] {
                                                    Pet.nome, Pet.NomeDoPai,Pet.Escola,Pet.Idade,Pet.Serie,Pet.Mae,Pet.Turno,Pet.Doenca,Pet});
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }
        private void Listar_de_pet_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListaPeca.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma linha selecionada");
                return;
            }
            int linhaSelecionada = dgvListaPeca.CurrentRow.Index;
            ZooPets Pets = Program.Pet[linhaSelecionada];
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvListaPeca.CurrentRow == null)
            {
                MessageBox.Show("Nenhum campo selecionado");
                return;
            }
            int linhaSelecionada = dgvListaPeca.CurrentRow.Index;
            DialogResult resultado = MessageBox.Show("Realmente quer apagar o registro?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Program.Pet.RemoveAt(linhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Registro Apagado com sucesso");
            }
            else
            {
                MessageBox.Show("Registro foi salvo");
            }
        }

        private void ListaPet_Load(object sender, EventArgs e)
        {

        }
    }
}
