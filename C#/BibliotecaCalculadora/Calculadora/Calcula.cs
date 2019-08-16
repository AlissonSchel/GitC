using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCalculadora.Calculadora
{
    public class Calcula
    {
        public void Somar()
        {
            Console.WriteLine("Informe o primeiro valor: ");
            int.TryParse(Console.ReadLine(), out int Valor1);

            Console.WriteLine("Informe o segundo valor: ");
            int.TryParse(Console.ReadLine(), out int Valor2);

            int Resultado = Valor1 + Valor2;

            Console.WriteLine($"Resultado da soma: {Resultado}\n");
            Console.ReadKey();
        }

        public void Subtrair()
        {
            Console.WriteLine("Informe o primeiro valor: ");
            int.TryParse(Console.ReadLine(), out int Valor1);

            Console.WriteLine("Informe o segundo valor: ");
            int.TryParse(Console.ReadLine(), out int Valor2);

            int Resultado = Valor1 - Valor2;

            Console.WriteLine($"Resultado da subtração: {Resultado}\n");
            Console.ReadKey();
        }

        public void Multiplicar()
        {
            Console.WriteLine("Informe o primeiro valor: ");
            int.TryParse(Console.ReadLine(), out int Valor1);

            Console.WriteLine("Informe o segundo valor: ");
            int.TryParse(Console.ReadLine(), out int Valor2);

            int Resultado = Valor1 * Valor2;

            Console.WriteLine($"Resultado da multiplicação: {Resultado}\n");
            Console.ReadKey();
        }

        public void Dividir()
        {
            Console.WriteLine("Informe o primeiro valor: ");
            int.TryParse(Console.ReadLine(), out int Valor1);

            Console.WriteLine("Informe o segundo valor: ");
            int.TryParse(Console.ReadLine(), out int Valor2);

            int Resultado = Valor1 / Valor2;

            Console.WriteLine($"Resultado da dividisão: {Resultado}\n");
            Console.ReadKey();
        }
    }
}
