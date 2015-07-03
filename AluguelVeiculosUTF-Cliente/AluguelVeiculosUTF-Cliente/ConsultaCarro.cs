using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AluguelVeiculosUTF_Cliente.ServidorAluguelCarro;

namespace AluguelVeiculosUTF_Cliente
{
    public partial class ConsultaCarro : Form
    {
        public ConsultaCarro()
        {
            InitializeComponent();
        }

        private void ConsultaCarro_Load(object sender, EventArgs e)
        {

            var locador = new InterfaceServClient();
            System.Object[] ItemObject = new System.Object[4];
            String[] arrayVeiculo = new String[4];
            arrayVeiculo = locador.consultarVeiculos();

            //listaVeiculosBox.Items.AddRange(arrayVeiculo);

            //System.Object[] ItemObject = new System.Object[10];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(arrayVeiculo[i]);
                ItemObject[i] = arrayVeiculo[i];
            }

            listaVeiculosBox.Items.AddRange(ItemObject);


            /*foreach (String modeloVeic in arrayVeiculo){
                Console.WriteLine(modeloVeic);
                listaVeiculosBox.Items.
            }*/

        }
    }
}
