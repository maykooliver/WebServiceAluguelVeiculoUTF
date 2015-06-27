using System;
using System.Collections;
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
    public partial class ConsultarCarros : Form
    {
        public ConsultarCarros()
        {
            InitializeComponent();
            try
            {
                //WebServiceAluguelVeiculo.InterfaceServClient. veiculos = new WebServiceAluguelVeiculo.InterfaceServClient.;

                ArrayList listaTeste = new ArrayList();

                //listaTeste = veiculos.consultarVeiculos();

                //veiculos.consultarVeiculos;

                //foreach (AluguelVeiculosUTF_Cliente.)
                //{
                //    count += 1;
                //    System.Console.WriteLine("Element #{0}: {1}", count, element);
                //}

                //double dFahrenheit = Convert.ToDouble(TextBox1.Text);
                //double dCelsius = ws.ConvertTemperature(dFahrenheit);
                //menssagemErro.Text = dCelsius.ToString();
            }
            catch
            {
                menssagemErro.Text = "Conversion failed.";
            }
            //ArrayList<Veiculo> listaVeiculo;
            //listaVeiculo = cliImpl.consultarVeiculo();
            //System.out.println(listaVeiculo.toString());

            //String disponibilidade;
            


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ConsultarCarros_Load(object sender, EventArgs e)
        {

        }

        private void ConsultarCarros_Load_1(object sender, EventArgs e)
        {

        }
    }
}
