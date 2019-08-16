using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAnimal
{
    public class Animal
    {
        private string nome = "Pato";

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public void Acordar()
        {
            Console.WriteLine($"{nome} acaba de acordar. ");
        }

        public void Comer()
        {
            Console.WriteLine($"{nome} está comendo. ");
        }

        public void Dormir()
        {
            Console.WriteLine($"{nome} acaba de dormir. ");
        }
    }
}
