using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeListaComClass.Lista_Create
{
    public class Create_List
    {
        string[] lista;

        public Create_List()
        {
            lista = new string[10];
            CriarLista();
        }

        public void CriarLista()
        {
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
            }
        }

        public void MostraLista()
        {
            foreach (var item in lista)
                Console.WriteLine(item);

            Console.ReadKey();
        }

        public void ApagaLista()
        {
            for (int i = 0; i < lista.Length; i++)
                lista[i] = string.Empty;
        }
    }
}
