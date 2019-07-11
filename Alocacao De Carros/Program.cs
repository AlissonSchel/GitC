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
        static void Main(string[] args)
        {
            CarregaBaseDeDados();
            var opcaoMenu = MenuPrincipal();

            while (opcaoMenu != 4)
            {
                if (opcaoMenu == 1)
                    AlocarUmCarro();

                if (opcaoMenu == 2)
                    DesalocarUmCarro();

                if (opcaoMenu == 3)
                {
                    Console.Clear();
                    MostrarListaDeCarros();
                    Console.ReadKey();
                }

                opcaoMenu = MenuPrincipal();
            }
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
        public static int MenuPrincipal()
        {
            Console.Clear();

            MostrarBemVindo();

            Console.WriteLine("Menu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar Carro.");
            Console.WriteLine("2 - Desalocar Carro.");
            Console.WriteLine("3 - Mostrar Lista de Carros.");
            Console.WriteLine("4 - Sair.");
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
            for (int i = 0; i < basedeCarros.GetLength(0); i++)
            {
                if (nomeCarro == basedeCarros[i, 0])
                {
                    return basedeCarros[i, 2] == "Sim";
                }
            }
            return false;
        }

        /// <summary>
        /// Função para alocar carro.
        /// </summary>
        public static void AlocarUmCarro()
        {
            MostrarMenuDeCarros("Alocar um carro: \n");

            MostrarListaDeCarros();

            var nomedoCarro = Console.ReadLine();
            if (PesquisaCarroParaAlocacao(nomedoCarro))
            {
                Console.Clear();
                MostrarBemVindo();
                Console.WriteLine("Você deseja alocar este carro? para Sim(1) para Não(0)");

                atualizarCarro(nomedoCarro, Console.ReadKey().KeyChar.ToString() == "1");

                Console.Clear();
                Console.WriteLine("Carro alterado com sucesso!\n");

                MostrarListaDeCarros();

                Console.ReadKey();
            }
        }

        /// <summary>
        /// Função para desalocar carros
        /// </summary>
        public static void DesalocarUmCarro()
        {
            MostrarMenuDeCarros("Desalocar um carro: \n");

            MostrarListaDeCarros();

            var nomedoCarro = Console.ReadLine();
            if (!PesquisaCarroParaAlocacao(nomedoCarro))
            {
                Console.Clear();
                MostrarBemVindo();
                Console.WriteLine("Você deseja desalocar este carro? para Sim(1) para Não(0)");

                atualizarCarro(nomedoCarro, Console.ReadKey().KeyChar.ToString() == "0");

                Console.Clear();
                Console.WriteLine("Carro alterado com sucesso!\n");

                MostrarListaDeCarros();

                Console.ReadKey();
            }
        }

        /// <summary>
        /// Metodo que aloca o carro de acordo com o parametro passado.
        /// </summary>
        /// <param name="nomeCarro">Carro a ser alocado.</param>
        public static void atualizarCarro(string nomeCarro, bool alocar)
        {
            for (int i = 0; i < basedeCarros.GetLength(0); i++)
            {
                if (nomeCarro == basedeCarros[i, 0])
                {
                    basedeCarros[i, 2] = alocar ? "Não" : "Sim";
                }
            }
        }
        /// <summary>
        /// Mostra o menu de carros
        /// </summary>
        /// <param name="operacao"></param>
        public static void MostrarMenuDeCarros(string operacao)
        {
            Console.Clear();

            MostrarBemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.WriteLine("Digite o carro que gostaria de realizar a operação: \n");
        }
        /// <summary>
        /// Mostra a lista de carros
        /// </summary>
        public static void MostrarListaDeCarros()
        {
            Console.WriteLine("Lista de carros: ");
            for (int i = 0; i < basedeCarros.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {basedeCarros[i, 0]} | Ano: {basedeCarros[i, 1]} | Disponível: {basedeCarros[i, 2]}");
            }
        }

    }
}
