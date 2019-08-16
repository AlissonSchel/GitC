using BoletimEscolar.Boletim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] arrayAlunos = new string[1, 6];
            int idAluno = 0;
            var opcaoMenu = ShowMenu();
            var classAlunos = new Alunos();

            while (true)
            {
                switch (opcaoMenu)
                {
                    case "1": { classAlunos.AdicionarAlunos(ref arrayAlunos, ref idAluno); } break;
                    case "2": { classAlunos.ListaALunos(arrayAlunos); } break;
                    case "3": { classAlunos.AlterarAlunos(arrayAlunos); } break;
                    case "4": { classAlunos.ExcluirAlunos(arrayAlunos); } break;
                    case "5": { Environment.Exit(0); } break;
                    default: { Console.WriteLine("Opção inválida."); } break;
                }
                opcaoMenu = ShowMenu();
            }   
        }

        public static string ShowMenu()
        {
            Console.Clear();

            Console.WriteLine("Escolha uma opção: \n");
            Console.WriteLine("1 - Cadastrar Alunos");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Alterar Alunos");
            Console.WriteLine("4 - Excluir Alunos");
            Console.WriteLine("5 - Sair");

            return Console.ReadLine();
        }
    }
}
