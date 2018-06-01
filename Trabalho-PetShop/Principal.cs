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
    public partial class btnListar : Form
    {
        public btnListar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void btnCadastroCarrros_Click(object sender, EventArgs e)
        {
            ListaAnimais listarCarro = new ListaAnimais();
            listarCarro.ShowDialog();
        }

        private void btnCadastroMoveis_Click(object sender, EventArgs e)
        {
            ListaTosa listarmoveis = new ListaTosa();
            listarmoveis.ShowDialog();
        }

        private void btnCadastroComputadores_Click(object sender, EventArgs e)
        {
            ListaPet listarpc = new ListaPet();
            listarpc.ShowDialog();
        }

        private void btnCadstroRoupas_Click(object sender, EventArgs e)
        {
            ListaClientes listarroupas = new ListaClientes();
            listarroupas.ShowDialog();
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se increve no meu canal xD");   
        }

       
    }
}
