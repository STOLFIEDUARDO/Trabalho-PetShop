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
    public partial class ListaClientes : Form
    {
        public ListaClientes()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroCliente Client = new CadastroCliente();
            Client.ShowDialog();
        }

        private void AtualizarLista()
        {

            dgvListaCliente.Rows.Clear();
            for (int i = 0; i < Program.Client.Count; i++)
            {
                Cliente Client = Program.Client[i];
                dgvListaCliente.Rows.Add(new object[] {
                                                    Client.Nome, Client.Altura,Client.Telefone,Client.Cidade,Client.Estado,Client.Bicho,Client.Email,Client});
        }   }                                                                                                                
        

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }
        private void Listar_de_cliente_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            if (dgvListaCliente.CurrentRow == null)
            {
                MessageBox.Show("Nenhum campo selecionado");
                return;
            }
            int linhaSelecionada = dgvListaCliente.CurrentRow.Index;
            DialogResult resultado = MessageBox.Show("Realmente quer apagar o registro?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Program.Client.RemoveAt(linhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Registro Apagado com sucesso");
            }
            else
            {
                MessageBox.Show("Registro foi salvo");
            }

        }

        
        private void txtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarLista();
            }
        }

        private void txtBusca_Leave(object sender, EventArgs e)
        {
            AtualizarLista();
        }
    }

    }
   
