using CriacaoDeListaComClass.Lista_Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeListaComClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = new Create_List();

            List.MostraLista();

            List.ApagaLista();

            List.MostraLista();
        }
    }
}
