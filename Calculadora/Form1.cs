using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        // Atributos / variáveis globais: 

        Double resultValue = 0;
        String operacao = "";
        bool operacao_2 = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void numero_Click(object sender, EventArgs e)
        {
            // Identificar o elemento da interface que invocou o método:
            if ((txbTela.Text == "0") || (operacao_2) )
                txbTela.Clear();
           
            operacao_2 = false;
            Button botao = (Button)sender;
            txbTela.Text = txbTela.Text + "" + botao.Text;
        }
        private void operador_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            operacao = botao.Text;
            resultValue = Double.Parse(txbTela.Text);
            labelOperacao.Text = resultValue + " " + operacao;
            operacao_2 = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (operacao)
            {

                case "+":
                    txbTela.Text = (resultValue + Double.Parse(txbTela.Text)).ToString();
                    break;


                case "-":
                    txbTela.Text = (resultValue - Double.Parse(txbTela.Text)).ToString();
                    break;


                case "*":
                    txbTela.Text = (resultValue * Double.Parse(txbTela.Text)).ToString();
                    break;


                case "/":
                    txbTela.Text = (resultValue / Double.Parse(txbTela.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbTela.Text = "0";
            resultValue = 0;
        }
    }
}
