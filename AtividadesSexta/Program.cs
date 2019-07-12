using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesSexta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine($"{nome} pode consumir bibidas alcoólicas.");
            }
            else
            {
                Console.WriteLine($"{nome} só pode tomar Dolly.");
            }
            Console.ReadKey();
        }
    }
}
