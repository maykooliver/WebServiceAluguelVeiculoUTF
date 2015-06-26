using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluguelVeiculosUTF_Cliente
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void alugarCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlugarCarro novaform = new AlugarCarro();
            novaform.Show();
        }

        private void consultarCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCarros novaform = new ConsultarCarros();
            novaform.Show();
        }

        private void criarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarConta novaform = new CriarConta();
            novaform.Show();
        }

        private void devolverCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevolverCarro novaform = new DevolverCarro();
            novaform.Show();
        }

        private void opçoesDeOperaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpcoesOperacoes novaform = new OpcoesOperacoes();
            novaform.Show();
        }
    }
}
