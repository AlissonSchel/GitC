using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdicionandoValoresEmUmaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeNome = new string[10,2];
            int ID = 0;

            InsertRegistro(ref listaDeNome, ref ID);

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que insere novos registros.
        /// </summary>
        /// <param name="listaDeNome">Lista de nomes.</param>
        /// <param name="ID">Referencia externa de ID.</param>
        public static void InsertRegistro(ref string[,] listaDeNome, ref int ID)
        {
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                if (listaDeNome[i, 0] != null)
                    continue;

                Console.Clear();
                Console.WriteLine("Informe um nome a ser adicionado na lista.");
                var nome = Console.ReadLine();

                listaDeNome[i, 0] = (ID++).ToString();
                listaDeNome[i, 1] = nome;

                Console.Clear();
                Console.WriteLine("Deseja inserir um novo registro? Sim(1) | Não(0)");
                var continuar = Console.ReadKey().KeyChar.ToString();

                if (continuar == "0")
                {
                    break;
                }

                AumentaTamanhoLista(ref listaDeNome);

            }

            Console.WriteLine("Registros adicionados com sucesso, segue lista de informações adicionadas: ");

            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                Console.WriteLine(string.Format("|ID: {0} | Nome: {1}", listaDeNome[i, 0], listaDeNome[i, 1]));
            }

        }

        public static void AumentaTamanhoLista(ref string[,] ListaDeNome)
        {
            var limiteDaLista = true;

            for (int i = 0; i < ListaDeNome.GetLength(0); i++)
            {
                if (ListaDeNome[i, 0] == null)
                    limiteDaLista = false;
            }

            if(limiteDaLista)
            {
                var listaCopia = ListaDeNome;

                ListaDeNome = new string[ListaDeNome.GetLength(0) + 5, 2];

                for (int i = 0; i < ListaDeNome.GetLength(0); i++)
                {
                    ListaDeNome[i, 0] = listaCopia[i, 0];
                    ListaDeNome[i, 1] = listaCopia[i, 1];
                }
                Console.WriteLine("Tamanho da Lista foi atualiado.");
            }


        }

    }
}
