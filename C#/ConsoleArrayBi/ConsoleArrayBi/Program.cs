﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArrayBi
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] listaDeLivros = new string[2,2] {{"O pequeno", "Sim"},{"O grande", "Não"}};

            for (int i = 0; i < listaDeLivros.GetLength(0); i++)
            {
                var nomeLivro = listaDeLivros[i, 0];
                var disponivel = listaDeLivros[i, 1];

                Console.WriteLine($"Nome do Livro: {nomeLivro} | Disponível: {disponivel}.");
            }

            Console.ReadKey();

        }
    }
}
