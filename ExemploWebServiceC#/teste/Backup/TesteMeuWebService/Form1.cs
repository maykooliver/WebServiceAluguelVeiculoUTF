using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TesteMeuWebService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal ValorA;
            decimal ValorB;
            localhost.OperacoesBasicas operacao = localhost.OperacoesBasicas.Adicao;
            decimal Resultado;

            decimal.TryParse(textBox1.Text, out ValorA);
            decimal.TryParse(textBox2.Text, out ValorB);

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    operacao = localhost.OperacoesBasicas.Adicao;
                    break;
                case 1:
                    operacao = localhost.OperacoesBasicas.Divisao;
                    break;
                case 2:
                    operacao = localhost.OperacoesBasicas.Multiplicacao;
                    break;
                case 3:
                    operacao = localhost.OperacoesBasicas.Subtracao;
                    break;
                default:
                    operacao = localhost.OperacoesBasicas.Adicao;
                    break;
            }

            localhost.Service MeuWebService = new localhost.Service();
            Resultado = MeuWebService.Calculadora(ValorA, ValorB, operacao);

            textBox3.Text = Resultado.ToString();
        }
    }
}