using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alocacao_De_Carros
{
    class Program
    {
        static string[,] basedeCarros;
        ///
        static void Main(string[] args)
        {
            CarregaBaseDeDados();
            MostrarBemVindo();
            if (MenuInicial() == 1)
            {
                menuAlocacao();
            } else
                Environment.Exit(0);
            Console.ReadKey();
        }
        /// <summary>
        /// Boas vindas ao iniciar programa.
        /// </summary>
        public static void MostrarBemVindo()
        {
            Console.WriteLine("________________________________");
            Console.WriteLine("   Locadora de Veículos Ambev   ");
            Console.WriteLine("________________________________\n");
        }

        /// <summary>
        /// Metodo que mostra o conteudo do menu e as opções de escolha.
        /// </summary>
        /// <returns> Retorna o valor do menu escolhido em um tipo inteiro. </returns>
        public static int MenuInicial()
        {

            Console.WriteLine("Menu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar Carro.");
            Console.WriteLine("2 - Sair.");
            Console.WriteLine("Degite o número desejado: ");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }

        /// <summary>
        /// Metodo que carrega a base de dados no sistema.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            basedeCarros = new string[2, 3]
            {
                {"Gol","2012", "Não"},
                { "Ka","2018", "Sim"}
            };
        }

        /// <summary>
        /// Pesquisa no banco de dados o carro requisitado.
        /// </summary>
        /// <param name="nomeCarro">Nome do carro a ser pesquisado</param>
        /// <returns>Disponibilidade do carro</returns>
        public static bool PesquisaCarroParaAlocacao(string nomeCarro)
        {

            var infoInvalida = true;

            for (int i = 0; i < basedeCarros.GetLength(0); i++)
            {
                if (nomeCarro == basedeCarros[i, 0])
                {
                    Console.WriteLine($"O carro {nomeCarro} pode ser alocado?: {basedeCarros[i, 2]}");
                    infoInvalida = false;
                    return basedeCarros[i, 2] == "Sim";
                } 
            }

            if (infoInvalida == true)
            {
                Console.Clear();
                Console.WriteLine("Informação Inválida\n");
                MostrarBemVindo();
                if (MenuInicial() == 1)
                {
                    menuAlocacao();
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            return false;
        }

        /// <summary>
        /// Metodo que aloca o carro de acordo com o parametro passado.
        /// </summary>
        /// <param name="nomeCarro">Carro a ser alocado.</param>
        public static void alocarCarro(string nomeCarro)
        {
            for (int i = 0; i < basedeCarros.GetLength(0); i++)
            {
                if (nomeCarro == basedeCarros[i, 0])
                    basedeCarros[i, 2] = "Não";
            }
        }

        /// <summary>
        /// Função para alocar carro e mostra lista dos carros.
        /// </summary>
        public static void menuAlocacao()
        {
            Console.Clear();
            MostrarBemVindo();
            Console.WriteLine("\r\nMenu - Alocação de Carros");
            Console.WriteLine("Digite o modelo do carro a ser alocado: ");

            var nomedoCarro = Console.ReadLine();  
            if (PesquisaCarroParaAlocacao(nomedoCarro))
            {
                Console.Clear();
                Console.WriteLine($"Você deseja alocar este {nomedoCarro} | Sim(1) | Não(0)");
                if (Console.ReadKey().KeyChar.ToString() == "1")
                {
                    Console.Clear();
                    alocarCarro(nomedoCarro);
                    Console.WriteLine($"O seu {nomedoCarro} foi alocado com sucesso!");
                }
                else
                    Console.Clear();

                Console.WriteLine("Lista de carros: ");
                for (int i = 0; i < basedeCarros.GetLength(0); i++)
                {
                    Console.WriteLine($"Nome: {basedeCarros[i, 0]} | Ano: {basedeCarros[i, 1]} | Disponível: {basedeCarros[i, 2]}");
                }
            }
        }
    }
}
