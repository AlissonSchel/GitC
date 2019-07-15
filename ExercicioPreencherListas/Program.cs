using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPreencherListas
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] ListaAlunos = new string[5, 3];
            int IDAluno = 0;

            InserirDados(ref ListaAlunos, ref IDAluno);

            Console.ReadKey();

            InserirDados(ref ListaAlunos, ref IDAluno);

            Console.ReadKey();
        }

        public static void InserirDados(ref string[,] ListaAlunos, ref int IDAluno)
        {

            for (int i = 0; i < ListaAlunos.GetLength(0); i++)
            {
                if (ListaAlunos[i, 0] != null)
                    continue;

                Console.Clear();
                Console.WriteLine("Informe o nome do Aluno: ");
                var nome = Console.ReadLine();
                Console.WriteLine("Informar idade do aluno: ");
                int.TryParse(Console.ReadLine(), out int idade);

                ListaAlunos[i, 0] = (IDAluno++).ToString();
                ListaAlunos[i, 1] = nome;
                ListaAlunos[i, 2] = idade.ToString();

                Console.Clear();
                Console.WriteLine("Deseja adicionar mais alunos? Sim(1) | Não(0)");
                var continuar = Console.ReadKey().KeyChar.ToString();

                if (continuar == "0")
                    break;

            }

            AumentaLista(ref ListaAlunos);

            Console.WriteLine("Alunos adicionados na lista. Veja a lista de alunos abaixo: ");

            for (int i = 0; i < ListaAlunos.GetLength(0); i++)
            {
                Console.WriteLine(string.Format("ID: {0} | Nome: {1} | Idade: {2}.", ListaAlunos[i,0], ListaAlunos[i, 1], ListaAlunos[i,2]));
            }

        }

        public static void AumentaLista(ref string[,] ListaAlunos)
        {
            Console.Clear();
            var limiteLista = true;

            for (int i = 0; i < ListaAlunos.GetLength(0); i++)
            {
                if (ListaAlunos[i,0] == null)
                {
                    limiteLista = false;
                }
            }

            if (limiteLista)
            {
                var novaLista = ListaAlunos;

                ListaAlunos = new string[ListaAlunos.GetLength(0) + 5, 3];

                for (int i = 0; i < novaLista.GetLength(0); i++)
                {
                    ListaAlunos[i, 0] = novaLista[i, 0];
                    ListaAlunos[i, 1] = novaLista[i, 1];
                    ListaAlunos[i, 2] = novaLista[i, 2];
                }
                Console.WriteLine("Lista atualizada com sucesso!");
            }

        }

    }
}
