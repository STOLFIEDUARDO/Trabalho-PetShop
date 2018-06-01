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
    public partial class ListaTosa : Form
    {
        public ListaTosa()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroTosaEBanho Tosar = new CadastroTosaEBanho();
            Tosar.ShowDialog();
        }
        private void AtualizarLista()
        {
            dgvListaTosa.Rows.Clear();
            for (int i = 0; i < Program.Pet.Count; i++)
            {
                Tosa Tosar = Program.Tosar[i];
                dgvListaTosa.Rows.Add(new object[] {
                                                    Tosar.nome, Tosar.Endereco,Tosar.TamanhoDoCorte,Tosar.peso,Tosar.altura,Tosar.Escova,Tosar.RG,Tosar.telefone,Tosar.Medo,Tosar});
            }
        }

        private void Listar_de_tosa_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvListaTosa.CurrentRow == null)
            {
                MessageBox.Show("Nenhum campo selecionado");
                return;
            }
            int linhaSelecionada = dgvListaTosa.CurrentRow.Index;
            DialogResult resultado = MessageBox.Show("Realmente quer apagar o registro?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Program.Tosar.RemoveAt(linhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Registro Apagado com sucesso");
            }
            else
            {
                MessageBox.Show("Registro foi salvo");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListaTosa.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma linha selecionada");
                return;
            }
            int linhaSelecionada = dgvListaTosa.CurrentRow.Index;
            Tosa Tosar = Program.Tosar[linhaSelecionada];
        }

    }
}
