using Bancoo_cSharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancoo_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta accountUser = new Conta();

            Console.WriteLine("Informe o valor para saque: \n");

            double.TryParse(Console.ReadLine(), out double valorSacar);

            if (valorSacar > 0 && accountUser.Sacar(valorSacar))
                Console.WriteLine("Saque realizado com sucesso!");
            else
                Console.WriteLine("Falha ao realizar operação");
            Console.WriteLine($"Saldo atual disponível: {accountUser.MostrarSaldo().ToString("N2")}");

            Console.ReadKey();
        }
    }
}
