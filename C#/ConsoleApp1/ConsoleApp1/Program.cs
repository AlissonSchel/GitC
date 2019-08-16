using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nameList = new string[2] {"Nome 1","Nome 2"};

            foreach (var nome in nameList)            
                Console.WriteLine(nome);

            string[] dateList = new string[10000];
            DateTime firstTime = DateTime.Now;

            for (int i = 0; i < dateList.Length; i++)
            {
                dateList[i] = DateTime.Now.ToString("dd/MM/yyyy | hh:mm:ss.fff");
                Console.WriteLine(dateList[i]);
            }

            Console.WriteLine((DateTime.Now - firstTime) .ToString());

            Console.ReadKey();

        }
    }
}
