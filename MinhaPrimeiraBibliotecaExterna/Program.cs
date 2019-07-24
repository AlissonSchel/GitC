using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeArquivosDoWindows;

namespace MinhaPrimeiraBibliotecaExterna
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new GetFiles();

            var arquivosMeusDoc = lista.RetornaArquivosDoMeuDocumentos();

            var arquivosImagens = lista.RetornaArquivosImagesFiles();

            var arquivosGit = lista.RetornaArquivosGit();


            for (int i = 0; i < arquivosMeusDoc.Length; i++)
            {
                Console.WriteLine(arquivosMeusDoc[i]);
                Console.WriteLine("_________________\n");
            }
                Console.ReadKey();

            for (int i = 0; i < arquivosImagens.Length; i++)
            {
                Console.WriteLine(arquivosImagens[i]);
                Console.WriteLine("_________________\n");
            }
                Console.ReadKey();

            if (arquivosGit != null)
            {
                for (int i = 0; i < arquivosGit.Length; i++)
                {
                    Console.WriteLine(arquivosGit[i]);
                    Console.WriteLine("_________________\n");
                }
            }
            else
                Console.WriteLine("Nada encontrado.");

            Console.ReadKey();
        }
    }
}
