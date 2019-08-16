using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarro4x4Class.MyFirstClass
{
    class Carro
    {
        public int Rodas { get; set; } = 0;
        public int Portas { get; set; } = 0;
        public int Bancos { get; set; } = 0;
        public int Janelas { get; set; } = 0;

        public int Rodas
        {
            get { return Rodas; }
            set { Rodas = value;}
        }

        public void MostrarCarro()
        {
            Console.WriteLine($"Nosso carro: Qntd Rodas [{Rodas}] | Qntd Portas [{Portas}] | Qntd Bancos [{Bancos}] | Qntd janelas [{Janelas}]");
        }
    }
}
