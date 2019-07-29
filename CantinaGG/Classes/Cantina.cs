using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaGG.Classes
{
    class Cantina
    {
        public double Saldo { get; set; }

        public Cantina()
        {
            Saldo = 20.00;
        }

        public double MostrarSaldo()
        {
            return Saldo;
        }

        public int MenuComprar()
        {
            Console.Clear();
            Console.WriteLine("Selecione a opção desejada:");
            Console.WriteLine("1 - Comprar Pastel (R$ 2,00)");
            Console.WriteLine("2 - Comprar Mini-Pizza (R$ 4,50)");
            Console.WriteLine("3 - Comprar  (R$ 3,75)");
            Console.WriteLine("4 - Sair");
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);
            return opcao;
        }

        public double VerificaCompra()
        {
            double precoLanche = 0.00;
            switch (MenuComprar())
            {
                case 1: { precoLanche = 2.00; } break;
                case 2: { precoLanche = 4.50; } break;
                case 3: { precoLanche = 3.75; } break;
                case 4: { Environment.Exit(0); } break;
            }
            return precoLanche;
        }

        public void RealizaCompra()
        {
            var precoLanche = VerificaCompra();
            if (Saldo >= precoLanche)
            {
                Console.Clear();
                Saldo -= precoLanche;
                Console.WriteLine("Compra realizada, veja seu saldo abaixo: ");
                Console.WriteLine(precoLanche);
                Console.ReadKey();
            }
                
        }
    }
}
