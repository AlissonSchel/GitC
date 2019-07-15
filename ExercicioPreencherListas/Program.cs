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

            Console.WriteLine("Alunos adicionados na lista. Veja a lista de alunos abaixo: ");

            for (int i = 0; i < ListaAlunos.GetLength(0); i++)
            {
                Console.WriteLine(string.Format("ID: {0} | Nome: {1} | Idade: {2}.", ListaAlunos[i,0], ListaAlunos[i, 1], ListaAlunos[i,2]));
            }

        }

    }
}
