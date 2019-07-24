using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraConsole.Calculadora;

namespace CalculadoraConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var Calcula = new Calcular();

            while (true)
            {
                Calcula.Calculadora();
            } 
        }
    }
}
