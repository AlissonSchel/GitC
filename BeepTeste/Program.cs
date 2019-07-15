using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BeepTeste
{
    class Program
    {
        static void Main(string[] args)
        {

            var B2 = 493;
            var D3 = 587;
            var E3 = 659;
            var G3 = 784;
            var Fsus3 = 740;

            Console.Beep(B2, 800);
            Console.Beep(D3, 800);

            Console.Beep(D3, 400);
            Console.Beep(E3, 400);
            Console.Beep(E3, 800);

            Console.Beep(G3, 200);
            Console.Beep(Fsus3, 200);
            Console.Beep(G3, 200);
            Console.Beep(Fsus3, 200);
            Console.Beep(G3, 200);
            Console.Beep(Fsus3, 200);

            Console.Beep(587, 400);
            Console.Beep(587, 400);
            Console.Beep(659, 400);
            Console.Beep(659, 800);



        }
    }
}
