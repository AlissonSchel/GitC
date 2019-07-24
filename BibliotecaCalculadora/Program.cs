using BibliotecaCalculadora.Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            var Calculadora = new Calcula();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Informe a operação desejada: (1) Soma | (2) Subtração | (3) Multiplicação | (4) Dvisão");
                var opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1": { Calculadora.Somar(); } break;
                    case "2": { Calculadora.Subtrair(); } break;
                    case "3": { Calculadora.Multiplicar(); } break;
                    case "4": { Calculadora.Dividir(); } break;
                }
            }
            
        }
    }
}
