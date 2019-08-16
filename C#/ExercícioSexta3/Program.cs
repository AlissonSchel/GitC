using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioSexta3
{
    class Program
    {
        static string[,] alunos;

        static void Main(string[] args)
        {
            CarregaBaseDeDados();
            listarAlunos();
        }

        /// <summary>
        /// Lista os alunos
        /// </summary>
        static void listarAlunos()
        {
            Console.Clear();
            Console.WriteLine("____________________");
            Console.WriteLine("Listagem de Alunos: ");
            Console.WriteLine("____________________\n");
            for (int i = 0; i < alunos.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {alunos[i, 0]} | Idade: {alunos[i, 1]} | Sexo: {alunos[i, 2]}\n");
            }

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();

        }

        /// <summary>
        /// Carrega Nomes, idades e sexo dos alunos
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            alunos = new string[20, 3]
            {
                {"Defuntina De Souza","17","Feminino"},
                {"Silvio Dubroca","18","Masculino"},
                {"Ivandilson","17","Masculino"},
                {"Manoel de Hora Pontual","17","Masculino"},
                {"Maria do Sô Anternor","17","Feminino"},
                {"Rolando Caio da Rocha","18","Masculino"},
                {"Segundo Avelino Peito","17","Masculino"},
                {"Tuzleuda Fragalhães","17","Feminino"},
                {"Uélitu Silva","17","Masculino"},
                {"Zeteônzio Calaboca","17","Masculino"},
                {"Hindianajones Silva","17","Masculino"},
                {"Galenogal de Silva","18","Masculino"},
                {"Frigobar Beneditino","17","Masculino"},
                {"Eliene Bubina","17","Feminino"},
                {"Edna Boa Sorte","18","Masculino"},
                {"Brizabela Alves","18","Feminino"},
                {"Ausêncio Nogueira","17","Masculino"},
                {"Argonauta Sucupira","18","Feminino"},
                {"Abecê Nogueira","20","Masculino"},
                {"Sansão Chazan","17","Masculino"},
            };
        }

    }
}
