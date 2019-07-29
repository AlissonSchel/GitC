using PrimeiraListaTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraListaTipada
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lanche> minhaLista = new List<Lanche>();

            minhaLista.Add(new Lanche()
            {
                 Nome = "Pão de Queijo",
                 Quantidade = 9,
                 Valor = 1.85
            });

            minhaLista.Add(new Lanche()
            {
                Nome = "Bolinho de Soya + Pepsi",
                Quantidade = 2,
                Valor = 7.00
            });

            bool adicionarLanche = true;
            while (adicionarLanche)
            {
                Console.Clear();
                Console.WriteLine("Informe o nome do lanche.");
                var nomeLanche = Console.ReadLine();
                Console.WriteLine($"Informe a quantidade de {nomeLanche}");
                int.TryParse(Console.ReadLine(), out int quantidade);
                Console.WriteLine($"Informe o valor de {nomeLanche}");
                double.TryParse(Console.ReadLine(), out double valor);

                minhaLista.Add(new Lanche()
                {
                    Nome = nomeLanche,
                    Quantidade = quantidade,
                    Valor = valor
                });
                Console.Clear();
                Console.WriteLine("Lanche adicionado com sucesso.\n");

                Console.WriteLine("Deseja adicionar mais lanches?");
                Console.WriteLine("(1) - Sim | (2) Não | (3) - Ver Lista de Lanches\n");
                int.TryParse(Console.ReadLine(), out int opcao);

                if (opcao == 2)
                {
                    adicionarLanche = false;
                } if (opcao == 3)
                {
                    Console.Clear();
                    foreach (Lanche item in minhaLista)
                    {
                        Console.WriteLine($"Lanches disponíveis: {item.Nome} | Quantidade: {item.Quantidade} | Preço: {item.Valor}");
                    }
                    Console.ReadKey();
                    adicionarLanche = true;
                }
            }
        }
    }
}
