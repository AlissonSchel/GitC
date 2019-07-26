using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeOperacoesDaCalculadora.OperacoesCalculadora;

namespace Calculafoca
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculadora = new OperacoesAritmeticas();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Selecione a opção desejada: \n");
                Console.WriteLine("1 - Calculo de Soma.");
                Console.WriteLine("2 - Cálculo de Subtração.");
                Console.WriteLine("3 - Calculo de Multiplicação.");
                Console.WriteLine("4 - Calculo de Divisão.");
                Console.WriteLine("5 - Calculo de Área de Retângulo.");
                Console.WriteLine("6 - Calculo de Área de Triângulo Equilátero.");
                Console.WriteLine("7 - Calculo de Raio.");
                Console.WriteLine("8 - Sair.");
                int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);
                switch (opcao)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine(".....Calculo de Adição.....\n");

                            Console.WriteLine("Informe o primeiro valor: ");
                            float.TryParse(Console.ReadLine(), out float pX);

                            Console.WriteLine("Informe o segundo valor: ");
                            float.TryParse(Console.ReadLine(), out float pY);

                            float resultado = calculadora.Adicao(pX, pY);

                            Console.WriteLine($"\nResultado: {resultado}");

                            Console.ReadKey();

                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine(".....Calculo de Subtração.....\n");

                            Console.WriteLine("Informe o primeiro valor: ");
                            float.TryParse(Console.ReadLine(), out float pX);

                            Console.WriteLine("Informe o segundo valor: ");
                            float.TryParse(Console.ReadLine(), out float pY);

                            float resultado = calculadora.Subtracao(pX, pY);

                            Console.WriteLine($"\nResultado: {resultado}");

                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine(".....Calculo de Multiplicação.....\n");

                            Console.WriteLine("Informe o primeiro valor: ");
                            float.TryParse(Console.ReadLine(), out float pX);

                            Console.WriteLine("Informe o segundo valor: ");
                            float.TryParse(Console.ReadLine(), out float pY);

                            float resultado = calculadora.Multiplicacao(pX, pY);

                            Console.WriteLine($"\nResultado: {resultado}");

                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine(".....Calculo de Divisão.....\n");

                            Console.WriteLine("Informe o primeiro valor: ");
                            float.TryParse(Console.ReadLine(), out float pX);

                            Console.WriteLine("Informe o segundo valor: ");
                            float.TryParse(Console.ReadLine(), out float pY);

                            float resultado = calculadora.Divisao(pX, pY);

                            Console.WriteLine($"\nResultado: {resultado}");

                            Console.ReadKey();
                        }
                        break;
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine(".....Calculo de Área de Retângulo.....\n");

                            Console.WriteLine("Informe o primeiro valor: ");
                            float.TryParse(Console.ReadLine(), out float pX);

                            Console.WriteLine("Informe o segundo valor: ");
                            float.TryParse(Console.ReadLine(), out float pY);

                            float resultado = calculadora.AreaRetangulo(pX, pY);

                            Console.WriteLine($"\nResultado: {resultado}");

                            Console.ReadKey();
                        }
                        break;
                    case 6:
                        {
                            Console.Clear();
                            Console.WriteLine(".....Calculo de Área de Triângulo Equilátero.....\n");

                            Console.WriteLine("Informe o valor da base: ");
                            float.TryParse(Console.ReadLine(), out float pBase);

                            Console.WriteLine("Informe o valor da altura: ");
                            float.TryParse(Console.ReadLine(), out float pAltura);

                            float resultado = calculadora.AreaTriangulo(pBase, pAltura);

                            Console.WriteLine($"\nResultado: {resultado}");

                            Console.ReadKey();
                        }
                        break;
                    case 7:
                        {
                            Console.Clear();
                            Console.WriteLine(".....Calculo de Raio.....\n");

                            Console.WriteLine("Informe o valor da area do círculo: ");
                            float.TryParse(Console.ReadLine(), out float pArea);

                            double resultado = calculadora.RaioDoCirculo(pArea);

                            Console.WriteLine($"\nResultado: {resultado}");

                            Console.ReadKey();
                        }
                        break;
                    case 8: { Environment.Exit(0); } break;
                    default: { Console.Clear();  Console.WriteLine("Valor inválido!"); Console.ReadKey(); } break;
                }
            }
        }
    }
}