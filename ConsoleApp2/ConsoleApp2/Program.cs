using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasseAnimal;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();

            //a.Nome = "Avestruz";

            Console.WriteLine($"Nome do Animal: {a.Nome}\n");

            a.Acordar();

            a.Comer();

            a.Dormir();

            Console.ReadKey();
        }
    }
}
