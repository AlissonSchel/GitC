using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioSexta2
{
    class Program
    {
        static string[] massacration;
        static void Main(string[] args)
        {
            receita();
        }
        
        static void receita()
        {
            Console.Clear();

            // Tela Inicial
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Receita de Bolo by Massacration");
            Console.WriteLine("-------------------------------\n");
            Console.WriteLine("Precione qualquer tecla para continuar.");

            // Etapas da Receita
            massacration = new string[]{
                "",
                "Em uma vasilha, penere a farinha de trigo, o fubá e o fermento para não empelotar.",
                "Bata as claras em neve e adicione as gemas, uma a uma, acrescente o leite, o óleo e a mistura reservada.",
                "Unte uma assadeira com margarina e polvilhe farinha de trigo... ",
                "Despeje a massa e leve para assar em forno brando.",
                "Depois que o bolo estiver assado, polvilhe o adoçante misturado com canela.",
            };

            // Lista as etapas
            for (int i = 1; i < massacration.GetLength(0); i++)
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"|Etapa {i}|\n \n {massacration[i]}\n\n");
                Console.WriteLine("Precione qualquer tecla quando terminar esta etapa.\n\n");
            }

            Console.WriteLine("Fim da Receita. Precione qualquer tecla para sair ou 1 para reiniciar.");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            if (opcao == 1)
            {
                receita();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
