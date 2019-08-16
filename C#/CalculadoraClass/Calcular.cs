using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraClass
{
    public class Calcular
    {
        public double Somar(double Valor1, double Valor2)
        {
            double resultado = Valor1 + Valor2;

            return resultado;
        }

        public double Subtrair(double Valor1, double Valor2)
        {
            double resultado = Valor1 - Valor2;

            return resultado;
        }

        public double Multiplicar(double Valor1, double Valor2)
        {
            double resultado = Valor1 * Valor2;

            return resultado;
        }

        public double Dividir(double Valor1, double Valor2)
        {
            double resultado = Valor1 / Valor2;

            return resultado;
        }
        public double CalcularAreaRetangulo(double Valor1, double Valor2)
        {
            double resultado = Valor1 * Valor2;

            return resultado;
        }

        public double CalcularAreaTriangulo(double valorBase, double valorAltura)
        {
            double resultado = (valorBase * valorAltura) / 2;

            return resultado;
        }

        public double CalcularRaioCirculo(double valorArea)
        {
            double resultado = Math.Sqrt(valorArea / 3.14);

            return resultado;
        }
    }
}
