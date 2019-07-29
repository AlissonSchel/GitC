using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancoo_cSharp.Classes
{
    public class Conta
    {
        double saldo = 0;

        public double Saldo { get { return saldo; } }

        public Conta()
        {
            saldo = 1000;
        }

        /// <summary>
        /// Sacar dinheiro se saldo estiver disponível
        /// </summary>
        /// <param name="valor">Valor a ser sacado</param>
        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Metodo para mostrar saldo da conta.
        /// </summary>
        public double MostrarSaldo()
        {
            return saldo;
        }
    }
}
