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
        
        InterfaceServClient locarCarro = new InterfaceServClient();
        Boolean veiculoLocado = false;

        public AlugarCarro()
        {
            InitializeComponent();
            //Console.WriteLine(carro);
            //nomeCarro = carro;
            
        }

        public void HabilitarBotao()
        {
            localRetiradaText.Enabled = true;
            localDevolucaoText.Enabled = true;
            dataInicioText.Enabled = true;
            horarioInicioText.Enabled = true;
            dataFimText.Enabled = true;
            horarioFimText.Enabled = true;
            nomeCondutorText.Enabled = true;
            idateCondutorText.Enabled = true;
            listaQuantidadeParcelaBox.Enabled = true;
        }

        public void DesahabilitarBotao()
        {
            localRetiradaText.Enabled = false;
            localDevolucaoText.Enabled = false;
            dataInicioText.Enabled = false;
            horarioInicioText.Enabled = false;
            dataFimText.Enabled = false;
            horarioFimText.Enabled = false;
            nomeCondutorText.Enabled = false;
            idateCondutorText.Enabled = false;
            listaQuantidadeParcelaBox.Enabled = false;
        }

        public void LimparTela()
        {
            listaVeiculosBox.SelectedIndex = -1;
            listaVeiculosBox.Text = " ";
            localRetiradaText.Text = " ";
            localDevolucaoText.Text = " ";
            dataInicioText.Text = " ";
            horarioInicioText.Text = " ";
            dataFimText.Text = " ";
            horarioFimText.Text = " ";
            nomeCondutorText.Text = " ";
            idateCondutorText.Text = " ";
            listaQuantidadeParcelaBox.SelectedIndex = -1;
            mensagemConsultaCarroText.Text = " ";
        }

        public bool verificaCarro()
        {
            if (locarCarro.verificaVeiculo(listaVeiculosBox.Text))
            {
                mensagemConsultaCarroText.Text = "Carro Locado!";
                return true;
            }
            else
            {
                mensagemConsultaCarroText.Text = "Carro não Locado!";
                return false;
            }
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
            string listaVeiculos = listaVeiculosBox.Text;
            string localRetirada = localRetiradaText.Text;
            string localDevolucao = localDevolucaoText.Text;
            string dataInicio = dataInicioText.Text;
            string horarioInicio = horarioInicioText.Text;
            string dataFim = dataFimText.Text;
            string horarioFim = horarioFimText.Text;
            string nomeCondutor = nomeCondutorText.Text;
            int idateCondutor = Convert.ToInt32(idateCondutorText.Text);
            string listaQuantidadeParcela = listaQuantidadeParcelaBox.Text;

            veiculoLocado = locarCarro.alugarVeic(listaVeiculos, localRetirada, localDevolucao, dataInicio, 
                horarioInicio, dataFim, horarioFim, nomeCondutor, idateCondutor, listaQuantidadeParcela);
            DesahabilitarBotao();
            LimparTela();
        }

        private void btnAlugarCarro_Click(object sender, EventArgs e)
        {
            if (!verificaCarro())
            {
                HabilitarBotao();
            }            
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            LimparTela();
            DesahabilitarBotao();
        }

        private void btnConsultarCarro_Click(object sender, EventArgs e)
        {
            verificaCarro();

        }

        private void btnDevolverCarro_Click(object sender, EventArgs e)
        {
            
            locarCarro.devolverVeiculo(nomeCondutorDevolverText.Text);
            nomeCondutorDevolverText.Text = " ";
            LimparTela();
        }
    }
}
