using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertRemoveFromList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] baseDeDados = new string[2,5];
            int IndiceBase = 0;
            Console.WriteLine("Iniciando sistema de lista de nome e idade.");
            var escolhaInicial = ApresentaMenuInicial();
            while (true)
            {
                switch (escolhaInicial)
                {
                    case "1": { AddValoresNaLista(ref baseDeDados, ref IndiceBase); } break;
                    case "2": { RemoverInformacoes(ref baseDeDados); } break;
                    case "3": { MostrarInformacoes(baseDeDados);}break;
                    case "4": { MostrarInformacoes(baseDeDados, "true"); }break;
                    case "5": { return; };
                }
                escolhaInicial = ApresentaMenuInicial();
            }
        }

        /// <summary>
        /// Metodo para mostrar menu
        /// </summary>
        /// <returns>Retorna menu escolhido</returns>
        public static string ApresentaMenuInicial()
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Inserir um novo registro");
            Console.WriteLine("2 - Remover um registro");
            Console.WriteLine("3 - Listar informações");
            Console.WriteLine("4 - Lista as informações desativadas");
            Console.WriteLine("4 - Sair do sistema\n");

            Console.WriteLine("Digite o número da opção desejada: ");

            return Console.ReadLine();
        }
        /// <summary>
        /// Metodo para adicionar valores na lista
        /// </summary>
        /// <param name="baseDeDados">Base de dados</param>
        /// <param name="IndiceBase">Indice na base de dados</param>
        public static void AddValoresNaLista(ref string[,] baseDeDados, ref int IndiceBase)
        {
            Console.Clear();
            Console.WriteLine("|*|*|*|*|*|*| Adicionando valores na lista |*|*|*|*|*|*|");
            Console.WriteLine("Informe um nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe a idade");
            var idade = Console.ReadLine();

            AumentaTamanhoLista(ref baseDeDados);

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i,0] != null)
                    continue;

                baseDeDados[i, 0] = (IndiceBase++).ToString();
                baseDeDados[i, 1] = nome;
                baseDeDados[i, 2] = idade;
                baseDeDados[i, 3] = "true";
                baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyy HH:mm:ss");
                break;
            }
            Console.WriteLine("Registro cadastrado com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial, pressione qualquer tecla.");
            Console.ReadKey();
        }
        
        /// <summary>
        /// Metodo que lista as informações do base de dados
        /// </summary>
        /// <param name="baseDeDados">Base de dados</param>
        public static void MostrarInformacoes(string[,] baseDeDados,string registrosAtivos = "false")
        {
            Console.Clear();
            Console.WriteLine("Listagem das informações do banco de dados.");

            if (registrosAtivos == "true")
            {
                Console.WriteLine("Registros desativados do sistema:");
            }

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i,3] != registrosAtivos)
                {
                    Console.WriteLine($"ID: {baseDeDados[i, 0]} | Nome: {baseDeDados[i, 1]} | Idade {baseDeDados[i, 2]} | Data da alteração: {baseDeDados[i,4]}");
                }
            }
            
            Console.WriteLine("\nResultados apresentados com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial.");
            Console.ReadKey();

            ApresentaMenuInicial();
        }
        public static void RemoverInformacoes(ref string[,] baseDeDados)
        {
            Console.Clear();
            Console.WriteLine("Area de remoção de registro do sistema.");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if(baseDeDados[i,3] != "false")
                    Console.WriteLine($"ID: {baseDeDados[i, 0]} | Nome: {baseDeDados[i, 1]} | Idade {baseDeDados[i, 2]}");
            }

            Console.WriteLine("Informe o ID do registro a ser removido.");
            var id = Console.ReadLine();

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if(baseDeDados[i,0] != null && baseDeDados[i,0] == id)
                {
                    baseDeDados[i, 3] = "false";
                    baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyy HH:mm:ss");

                    Console.WriteLine("Removido com sucesso.");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                    Console.ReadKey();
                }
            }
        }
        public static void AumentaTamanhoLista(ref string[,] baseDeDados)
        {
            var limiteDaLista = true;

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] == null)
                    limiteDaLista = false; ;
            }

            if (limiteDaLista)
            {
                var listaCopia = baseDeDados;

                baseDeDados = new string[baseDeDados.GetLength(0) + 10, baseDeDados.GetLength(1)];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    baseDeDados[i, 0] = listaCopia[i, 0];
                    baseDeDados[i, 1] = listaCopia[i, 1];
                    baseDeDados[i, 2] = listaCopia[i, 2];
                    baseDeDados[i, 3] = listaCopia[i, 3];
                    baseDeDados[i, 4] = listaCopia[i, 4];
                }
                Console.WriteLine("Tamanho da Lista foi atualiado.");
            }


        }
    }
}
