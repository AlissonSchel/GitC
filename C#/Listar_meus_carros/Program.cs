using Listar_meus_carros.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listar_meus_carros
{
    class Program
    {
        static List<Carro> listaCarros = new List<Carro>();
        static void Main(string[] args)
        {   
            while (true)
            {
                
                switch (MostrarMenu())
                {
                    case 1: { AdicionarCarro(); break; }
                    case 2: { ListaCarros(); break; }
                    case 3: { Environment.Exit(0); break; }
                    default: { Console.WriteLine("Opção inválida."); break; }
                }
            }
        }

        public static int MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Selecione a opção desejada: \n");

            Console.WriteLine("(1) - Adicionar Carro");
            Console.WriteLine("(2) - Listar Carros");
            Console.WriteLine("(3) - Sair");
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }

        public static void AdicionarCarro()
        {
            Console.Clear();
            listaCarros.Add(new Carro()
            {
                Modelo = InsereValor("modelo"),
                Ano = int.Parse(InsereValor("ano")),
                Placa = InsereValor("placa"),
                Cv = int.Parse(InsereValor("Cv"))
            });

            Console.WriteLine("Carro adicionado com sucesso.");
            Console.ReadKey();
        }

        public static void ListaCarros()
        {
            Console.Clear();
            foreach (Carro item in listaCarros)
            {
                Console.WriteLine($"Modelo: {item.Modelo} | Ano: {item.Ano} | Placa: {item.Placa} | Cv: {item.Cv}");
            }
            Console.ReadKey();
        }

        public static string InsereValor(string campo)
        {
            Console.WriteLine($"Informe o {campo} do carro.");
            return Console.ReadLine();
        }
    }
}
