using BoletimEscolar.Boletim;
using BoletimEscolar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolar.Boletim
{
    class Alunos
    {
        /// <summary>
        /// Metodo para Adicionar novos alunos na lista.
        /// </summary>
        /// <param name="alunos">Array onde os dados serao armazenados</param>
        public void AdicionarAlunos(ref string[,] alunos, ref int idAluno)
        {
            AumentaLista(ref alunos);

            Console.Clear();

            var boletim = new CalculaDados();

            Console.WriteLine("Informe o nome do aluno: ");
            var nomeAluno = Console.ReadLine();

            var media = RegistraMedia();

            var frequencia = RegistraFrequencia();

            for (int i = 0; i < alunos.GetLength(0); i++)
            {
                if (alunos[i, 0] != null)
                    continue;

                alunos[i, 0] = (idAluno++).ToString();
                alunos[i, 1] = nomeAluno;
                alunos[i, 2] = media.ToString();
                alunos[i, 3] = frequencia.ToString();
                alunos[i, 4] = boletim.SituacaoAluno(media,frequencia);
                alunos[i, 5] = "true";
            }
            Console.WriteLine("Aluno cadastrado!");
            Console.ReadKey();
        }

        /// <summary>
        /// Lista alunos na tela
        /// </summary>
        /// <param name="alunos">Base de dados dos alunos</param>
        public void ListaALunos(string [,] alunos, string listagemAlternada = "false")
        {
            Console.Clear();
            Console.WriteLine("Lista de alunos do sistema:\n\n");

            for (int i = 0; i < alunos.GetLength(0); i++)
            {
                if (alunos[i,5] != listagemAlternada)
                {
                    Console.WriteLine($"Id: {alunos[i, 0]} | Nome: {alunos[i, 1]} | Média: {alunos[i, 2]} | Frequencia: {alunos[i, 3]}% | Situação: {alunos[i, 4]}");
                }
               
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Armazena e calcula Media
        /// </summary>
        /// <returns>Media do aluno</returns>
        public int RegistraMedia()
        {
            var boletim = new CalculaDados();

            Console.WriteLine("Informe a primeira nota:");
            int.TryParse(Console.ReadLine(), out int Nota1);

            Console.WriteLine("Informe a segunnda nota:");
            int.TryParse(Console.ReadLine(), out int Nota2);

            Console.WriteLine("Informe a terceira nota:");
            int.TryParse(Console.ReadLine(), out int Nota3);

            int media = boletim.Media(Nota1, Nota2, Nota3);

            return media;
        }

        /// <summary>
        /// Calcula frequencia
        /// </summary>
        /// <returns>Frequencia em porcentagem do aluno</returns>
        public float RegistraFrequencia()
        {
            var boletim = new CalculaDados();

            Console.WriteLine("Informe o número total de aulas:");
            float.TryParse(Console.ReadLine(), out float nAulas);

            Console.WriteLine("Informe o número de faltas do aluno.");
            float.TryParse(Console.ReadLine(), out float nFaltas);

            float frequencia = boletim.Frequencia(nAulas, nFaltas);

            return frequencia;
        }

        public void AlterarAlunos(string[,] alunos)
        {
            Console.Clear();

            var boletim = new CalculaDados();


            Console.WriteLine("Informe o aluno a ser alterado: ");
            var id = Console.ReadLine();

            for (int i = 0; i < alunos.GetLength(0); i++)
            {
                if (alunos[i, 0] != null && alunos[i, 0] == id)
                {

                    Console.WriteLine("Informe o nome do aluno: ");
                    var nomeAluno = Console.ReadLine();

                    var media = RegistraMedia();

                    var frequencia = RegistraFrequencia();

                    alunos[i, 1] = nomeAluno;
                    alunos[i, 2] = media.ToString();
                    alunos[i, 3] = frequencia.ToString();
                    alunos[i, 4] = boletim.SituacaoAluno(media,frequencia);
                }
            }
            Console.WriteLine("Aluno alterado com sucesso!");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo Para Excluir Alunos
        /// </summary>
        /// <param name="alunos">Base de dados dos alunos</param>
        public void ExcluirAlunos(string [,] alunos, string listagemAlternada = "false")
        {
            Console.Clear();

            for (int i = 0; i < alunos.GetLength(0); i++)
            {
                if (alunos[i, 5] != listagemAlternada)
                {
                    Console.WriteLine($"Id: {alunos[i, 0]} | Nome: {alunos[i, 1]} | Média: {alunos[i, 2]} | Frequencia: {alunos[i, 3]}% | Situação: {alunos[i, 4]}");
                }

            }

            Console.WriteLine("Informe o aluno a ser Excluído: ");
            var id = Console.ReadLine();

            for (int i = 0; i < alunos.GetLength(0); i++)
            {
                if (alunos[i,0] != null && alunos[i,0] == id)
                {
                    alunos[i, 5] = "false";
                }
            }
            Console.WriteLine("Aluno exluido do sistema");
            Console.ReadKey();
        }

        public static void AumentaLista(ref string [,] alunos)
        {
            var limiteLista = true;

            for (int i = 0; i < alunos.GetLength(0); i++)
            {
                if (alunos[i, 0] == null)
                {
                    limiteLista = false;
                }
            }

            if (limiteLista)
            {
                var novaBase = alunos;

                alunos = new string[alunos.GetLength(0) + 1, 6];

                for (int i = 0; i < novaBase.GetLength(0); i++)
                {
                    alunos[i, 0] = novaBase[i, 0];
                    alunos[i, 1] = novaBase[i, 1];
                    alunos[i, 2] = novaBase[i, 2];
                    alunos[i, 3] = novaBase[i, 3];
                    alunos[i, 4] = novaBase[i, 4];
                    alunos[i, 5] = novaBase[i, 5];
                }
            }
        }
    }

    
}
