using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeNome = new string[5, 2];

            CarregaInformacoesEListaNaTela(ref listaDeNome);

            Console.ReadKey();

            Console.WriteLine("Informe o ID do registro a ser pesquisado: ");

            PesquisaNaLista(listaDeNome, Console.ReadLine());

            Console.ReadKey();

        }
        /// <summary>
        /// Metodo que carrega informações e lista na tela.
        /// </summary>
        /// <param name="arrayBi"></param>
        public static void CarregaInformacoesEListaNaTela(ref string[,] arrayBi)
        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                arrayBi[i, 0] = i.ToString();
                arrayBi[i, 1] = $"Alisson_{i}";
            }

            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                Console.WriteLine($"ID: {arrayBi[i, 0]} - Nome: {arrayBi[i, 1]}");
            }
        }

        public static void PesquisaNaLista(string[,] arrayBi,string pID)
        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                if (arrayBi[i,0] == pID)
                {
                    Console.WriteLine($"Informação escolhida: ID: {arrayBi[i,0]} | Nome{arrayBi[i,1]}");
                    return;
                }
            }
            Console.WriteLine("Infelizmente a busa pelo ID não resultou em nenhuma informação;");
        }

    }
}
