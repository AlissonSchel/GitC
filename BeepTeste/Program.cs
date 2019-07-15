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
            #region notas 3 oitavas
            var C1 = 130;
            var Csus1 = 138;
            var D1 = 146;
            var Dsus1 = 155;
            var E2 = 164;
            var F2 = 174;
            var Fsus2 = 185;
            var G2 = 196;
            var Gsus2 = 207;
            var A2 = 220;
            var Asus2 = 466;
            var B2 = 493;
            var C3 = 523;
            var Csus3 = 554;
            var D3 = 587;
            var Dsus3 = 622;
            var E3 = 659;
            var F3 = 698;
            var Fsus3 = 740;
            var G3 = 784;
            var Gsus3 = 830;
            var A3 = 880;
            var Asus3 = 932;
            var B3 = 987;
            #endregion
            
            // Riff 1
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

            Console.Beep(D3, 400);
            Console.Beep(D3, 800);
            Console.Beep(E3, 400);
            Console.Beep(E3, 800);

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

            Console.Beep(D3, 400);
            Console.Beep(D3, 800);
            Console.Beep(E3, 400);
            Console.Beep(E3, 800);

            //Riff 2

            Console.Beep(B2,400);
            Console.Beep(B2,400);
            Console.Beep(D2,1000);

        }
    }
}
