using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaOnline2000
{
    class Program
    {
        static string[,] baseDeLivros;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();
            MostrarBemVindo();
            if (MenuInicial() == 1)
            {
                menuAlocacao();
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Boas vindas ao iniciar programa.
        /// </summary>
        public static void MostrarBemVindo()
        {
            Console.WriteLine("________________________________");
            Console.WriteLine("      BibliotecaOnline2000!     ");
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
            Console.WriteLine("1 - Alocar um livro.");
            Console.WriteLine("2 - Sair do Sistema.");
            Console.WriteLine("Degite o número desejado: ");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }

        /// <summary>
        /// Metodo que carrega a base de dados no sistema.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            baseDeLivros = new string[2, 2]
            {
                {"O pequeno","Sim"},
                { "O grande","Não"}
            };
        }

        /// <summary>
        /// Pesquisa no banco de dados o livro requisitado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser pesquisado</param>
        /// <returns>Disponibilidade do Livro</returns>
        public static bool PesquisaLivroParaAlocacao(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                {
                    Console.WriteLine($"O livro {nomeLivro} pode ser alocado?: {baseDeLivros[i, 1]}");
                    return baseDeLivros[i, 1] == "Sim";
                }
            }
            return false;
        }

        /// <summary>
        /// Metodo que aloca o livro de acordo com o parametro passado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser alocado.</param>
        public static void alocarLivro(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                    baseDeLivros[i, 1] = "Não";
            }
        }

        public static void menuAlocacao()
        {
            Console.Clear();
            MostrarBemVindo();
            Console.WriteLine("\r\nMenu - Alocação de Livros");
            Console.WriteLine("Digite o nome do livro a ser alocado: ");

            var nomedolivro = Console.ReadLine();
            if (PesquisaLivroParaAlocacao(nomedolivro))
            {
                Console.Clear();
                Console.WriteLine("Você deseja alocar o livro? | Sim(1) | Não(0)");
                if (Console.ReadKey().KeyChar.ToString() == "1")
                {
                    alocarLivro(nomedolivro);
                    Console.WriteLine("Livro Alocado!");
                }
                else
                    Console.Clear();

                Console.WriteLine("Listagem de livros: ");
                for (int i = 0; i < baseDeLivros.GetLength(0); i++)
                {
                    Console.WriteLine($"Nome: {baseDeLivros[i, 0]} | Disponível: {baseDeLivros[i, 1]}");
                }
            }
        }
    }
}
