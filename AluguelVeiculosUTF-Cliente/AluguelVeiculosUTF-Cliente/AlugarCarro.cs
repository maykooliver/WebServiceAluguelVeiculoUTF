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
    public partial class AlugarCarro : Form
    {
        String nomeCarro;

        public AlugarCarro()
        {
            InitializeComponent();
            //Console.WriteLine(carro);
            //nomeCarro = carro;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void AlugarCarro_Load(object sender, EventArgs e)
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
