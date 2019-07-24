using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsole.Calculadora
{
    public class Calcular
    {
        public void Calculadora()
        {
            Console.WriteLine("Informe o primeiro valor: ");
            int.TryParse(Console.ReadLine(), out int Valor1);

            Console.WriteLine("Informe o segundo valor: ");
            int.TryParse(Console.ReadLine(), out int Valor2);

            Console.WriteLine("Informe a operação: ");
            string operacao = Console.ReadKey().KeyChar.ToString();

            int Resultado;

                Console.Clear();
                switch (operacao)
                {
                    case "+": { Resultado = Valor1 + Valor2; Console.WriteLine($"Resultado da soma: {Resultado}"); Console.ReadKey(); } break;
                    case "-": { Resultado = Valor1 - Valor2; Console.WriteLine($"Resultado da subtração: {Resultado}"); Console.ReadKey(); } break;
                    case "*": { Resultado = Valor1 * Valor2; Console.WriteLine($"Resultado da multiplicação: {Resultado}"); Console.ReadKey(); } break;
                    case "/": { Resultado = Valor1 / Valor2; Console.WriteLine($"Resultado da divisão: {Resultado}"); Console.ReadKey(); } break;
                    case "0": { Environment.Exit(0); } break;
                    default: { Console.WriteLine("Operação inválida..."); Console.Clear(); } break;
                }
            Console.Clear();
        }
    }
}
