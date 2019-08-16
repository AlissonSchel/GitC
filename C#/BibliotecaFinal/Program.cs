using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] baseDeLivros = new string[0,5];

            int indice = 0;

            Console.WriteLine("Bem Vindo à Biblioteca Online");

            var opcaoMenu = MenuInicial();

            while (true)
            {
                switch (opcaoMenu)
                {
                    case "1": { AdicionaLivros(ref baseDeLivros, ref indice); } break;
                    case "2": { RemoveLivros(ref baseDeLivros); } break;
                    case "3": { ListagemDeLivros(ref baseDeLivros); } break;
                    case "4": { ListagemDeLivros(ref baseDeLivros, "true"); } break;
                    case "5": { Environment.Exit(0); }break;
                    default:{Console.Clear();Console.WriteLine("Opção inválida, tente novamente.");Console.ReadKey();} break;
                }
                opcaoMenu = MenuInicial();
            }

        }

        /// <summary>
        /// Mostra Menu Inicial Com opções de escolha para o usuario
        /// </summary>
        /// <returns>Retorna a opção escolhida pelo usuário</returns>
        public static string MenuInicial()
        {
            Console.Clear();
            Console.WriteLine("Menu Inicial");
            Console.WriteLine("1 - Cadastrar Livro");
            Console.WriteLine("2 - Excluir Livro");
            Console.WriteLine("3 - Lista De Livros do Sistema");
            Console.WriteLine("4 - Lista de Livros Excluídos");
            Console.WriteLine("5 - Sair do Sistema");

            Console.WriteLine("Digite o número da opção desejada: ");
            return Console.ReadLine();
        }

        /// <summary>
        /// Aciodiona Livros ao banco de dados do sistema
        /// </summary>
        /// <param name="baseDeLivros">Banco de Livros Cadastrados</param>
        /// <param name="idLivro">ID do livro</param>
        public static void AdicionaLivros(ref string[,] baseDeLivros, ref int idLivro)
        {
            Console.Clear();
            Console.WriteLine("***Adicionar Livros No Sistema***\n");
            Console.WriteLine("Informe o nome do livro: ");
            var nomeLivro = Console.ReadLine();

            Console.WriteLine("Informe o nome do autor do livro: ");
            var AutorLivro = Console.ReadLine();

            AumentarLimiteLista(ref baseDeLivros);

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (baseDeLivros[i, 0] != null)
                    continue;

                baseDeLivros[i, 0] = (idLivro++).ToString();
                baseDeLivros[i, 1] = nomeLivro;
                baseDeLivros[i, 2] = AutorLivro;
                baseDeLivros[i, 3] = "true";
                baseDeLivros[i, 4] = DateTime.Now.ToString();
                break;
            }
            Console.Clear();
            Console.WriteLine("Livro cadastrado com sucesso!\n");
            Console.WriteLine("Pressione qualquer tecla para voltar ao Menu Inicial.");
            Console.ReadKey();
        }

        /// <summary>
        /// Remove Livros do Banco de Dados do Sistema
        /// </summary>
        /// <param name="baseDeLivros">Base de Livros do Sistema</param>
        public static void RemoveLivros(ref string[,] baseDeLivros)
        {
            Console.Clear();
            Console.WriteLine("*** Remover Livros do Sistema ***");

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (baseDeLivros[i,3] != "false")
                {
                    Console.WriteLine($"ID: {baseDeLivros[i,0]} | Livro: {baseDeLivros[i,1]} | Autor: {baseDeLivros[i,2]}");
                }
            }

            Console.WriteLine("Informe o ID do Livro a ser Excluído: ");
            var id = Console.ReadLine();

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (baseDeLivros[i, 0] != null && baseDeLivros[i, 0] == id)
                {
                    baseDeLivros[i, 3] = "false";
                    baseDeLivros[i, 4] = DateTime.Now.ToString();
                }
            }
            Console.WriteLine("Livro excluído com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para voltar ao Menu Inicial.");
            Console.ReadKey(); 
        }

        /// <summary>
        /// Apresenta lista de livros do bando de dados na tela.
        /// </summary>
        /// <param name="baseDeLivros">Base de livros</param>
        /// <param name="listagemAlternada">Listagem alternada entre Lista de Livros exluidos caso true</param>
        public static void ListagemDeLivros(ref string[,] baseDeLivros, string listagemAlternada = "false")
        {
            Console.Clear();
            Console.WriteLine("*** Lista de Livros Do Sistema ***");
            Console.WriteLine("__________________________________\n");

            if (listagemAlternada == "true")
            {
                Console.Clear();
                Console.WriteLine("Livros Excluídos do Sistema: ");
            }

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {

                if (baseDeLivros[i,3] != listagemAlternada)
                {
                    Console.WriteLine($"\n | \tID: {baseDeLivros[i, 0]} \t | \tLivro: {baseDeLivros[i, 1]} \t | \tAutor: {baseDeLivros[i, 2]} \t | \tData de alteração: {baseDeLivros[i, 4]}");
                }
            }
            Console.WriteLine("\n\nPressione qualquer tecla para voltar ao Menu Inicial.");
            Console.ReadKey();
        }

        /// <summary>
        /// Aumenta tamanho da lista quando o limite for atingido
        /// </summary>
        /// <param name="baseDeLivros">Base de dados a ter o tamanho aumentado</param>
        public static void AumentarLimiteLista(ref string[,] baseDeLivros)
        {
            var limiteLista = true;

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (baseDeLivros[i,0] == null)
                {
                    limiteLista = false;
                }
            }

            if (limiteLista)
            {
                var novaBase = baseDeLivros;

                baseDeLivros = new string[baseDeLivros.GetLength(0) + 1, 5];

                for (int i = 0; i < novaBase.GetLength(0); i++)
                {
                    baseDeLivros[i, 0] = novaBase[i, 0];
                    baseDeLivros[i, 1] = novaBase[i, 1];
                    baseDeLivros[i, 2] = novaBase[i, 2];
                    baseDeLivros[i, 3] = novaBase[i, 3];
                    baseDeLivros[i, 4] = novaBase[i, 4];
                }
                Console.WriteLine("Tamanho da lista atualizado devido ao limite ter sido atingido.");
            }
        }

    }
}
