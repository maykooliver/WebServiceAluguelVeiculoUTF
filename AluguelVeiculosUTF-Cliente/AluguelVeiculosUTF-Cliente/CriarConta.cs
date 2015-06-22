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
    public partial class CriarConta : Form
    {
        public object CliImp { get; private set; }

        public CriarConta()
        {
            InitializeComponent();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            CliImpl cliente = new CliImpl();
            cliente.nomeCli = caixaTextoNome.Text;

            //OpcoesOperacoes.ActiveForm();

        }
    }
}
