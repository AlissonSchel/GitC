﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarJoinhaClass
{
    public class AquiMostraJoinha
    {
        public void MetodoInicialDoJoinha()
        {
            Console.WriteLine("Aqui iniciamos o joinha.");
        }

        public void MetodoDoisPontoZero(bool eQuinta)
        {
            if (eQuinta)
            {
                Console.WriteLine("Carai mermão!!!");
            }
            else
            {
                Console.WriteLine("Aiaiai!!!");
            }
            Console.ReadKey();
        }

        public string[] TesteUmOperadorLegal()
        {
            return new string[2] { "Teste 1", "Teste 2" };
        }
        
    }
}