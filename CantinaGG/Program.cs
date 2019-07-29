using CantinaGG.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaGG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cantina GG\n");

            Cantina c = new Cantina();

            Console.WriteLine(c.MostrarSaldo());
            while (c.Saldo > 0)
            {
                Console.
                c.RealizaCompra();
                c.MostrarSaldo();
                Console.WriteLine("Deseja continuar comprando?");
                Console.WriteLine("(1) - Sim | (2) Não |");
                int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

                switch (opcao)
                {
                    case 1: { continue; };
                    case 2: { Environment.Exit(0); } break;
                    default: {Console.Clear(); Console.WriteLine("Opção Inválida."); Console.ReadKey(); } break;
                }
            }
            Console.Clear();
            c.MostrarSaldo();
            Console.WriteLine("Saldo indisponível");
        }
    }
}
