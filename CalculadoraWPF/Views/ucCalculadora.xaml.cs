using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculadoraWPF.Views
{
    /// <summary>
    /// Interaction logic for ucCalculadora.xaml
    /// </summary>
    public partial class ucCalculadora : UserControl
    {
        public ucCalculadora()
        {
            InitializeComponent();
        }
        public decimal Valor1 { get; set; }
        public string Operacao { get; set; }
        public decimal Valor2 { get; set; }
        public decimal Resultado { get; set; }
        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            input("0");
            tbxConta.Text += "0 ";
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            input("1");
            tbxConta.Text += "1 ";
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            input("2");
            tbxConta.Text += "2 ";
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            input("3");
            tbxConta.Text += "3 ";
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            input("4");
            tbxConta.Text += "4 ";
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            input("5");
            tbxConta.Text += "5 ";
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            input("6");
            tbxConta.Text += "6 ";
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            input("7");
            tbxConta.Text += "7 ";
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            input("8");
            tbxConta.Text += "8 ";
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            input("9");
            tbxConta.Text += "9 ";
        }

        private void input(string a)
        {
            if (tbxResultado.Text == "0")
            {
                tbxResultado.Text = a;
            }
            else
            {
                tbxResultado.Text += a;
            }
        }

        private void BtnSoma_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxResultado.Text))
            {
                tbxResultado.Text = "0";
            }
            Valor1 = decimal.Parse(tbxResultado.Text);
            Operacao = "+";
            tbxConta.Text += "+ ";
            tbxResultado.Text = "0";
        }

        private void BtnSubtracao_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxResultado.Text))
            {
                tbxResultado.Text = "0";
            }
            Valor1 = decimal.Parse(tbxResultado.Text);
            Operacao = "-";
            tbxConta.Text += "- ";
            tbxResultado.Text = "0";
        }

        private void BtnMultiplica_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxResultado.Text))
            {
                tbxResultado.Text = "0";
            }
            Valor1 = decimal.Parse(tbxResultado.Text);
            Operacao = "*";
            tbxConta.Text += "* ";
            tbxResultado.Text = "0";
        }

        private void BtnDivisao_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxResultado.Text))
            {
                tbxResultado.Text = "0";

            }
            Valor1 = decimal.Parse(tbxResultado.Text);
            Operacao = "/";
            tbxConta.Text += "/ ";
            tbxResultado.Text = "0";
        }

        private void BtnIgual_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Valor2 = decimal.Parse(tbxResultado.Text);
                switch (Operacao)
                {
                    case "+": { Resultado = Valor1 + Valor2; } break;
                    case "-": { Resultado = (Valor1 - Valor2); } break;
                    case "*": { Resultado = (Valor1 * Valor2); } break;
                    case "/": { Resultado = (Valor1 / Valor2); } break;
                }
                tbxConta.Text = "";
                tbxResultado.Text = Resultado.ToString();
            }
            catch (Exception)
            {
                tbxResultado.Text = "Error!";
                tbxConta.Text = "Error!";
            }
        }

        private void TbxResultado_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnAC_Click(object sender, RoutedEventArgs e)
        {
            tbxResultado.Text = "0";
            tbxConta.Text = "";
            Valor1 = 0;
            Valor2 = 0;
            Operacao = "";
        }
    }
}
