using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Classes
{
    class ClasseEstacionamento
    {
        public void MenuInicial()
        {
            string[,] carros = new string [1,4];
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Escolha uma opção: \n");
                Console.WriteLine("1 - Entrada de veículo");
                Console.WriteLine("2 - Listar Veículos no Estacionamento");
                Console.WriteLine("3 - Saída de Veículos");
                Console.WriteLine("4 - Historico de Saídas");
                Console.WriteLine("5 - Sair");
                var opcaoMenu = Console.ReadLine();

                switch (opcaoMenu)
                {
                    case "1": { AdicionarCarros(ref carros); } break;
                    case "2": { ListarCarros(carros); } break;
                    case "3": { ExcluirAlunos(carros); } break;
                    case "4": { HistoricoDeSaida(carros); } break;
                    case "5": { Environment.Exit(0); } break;
                    default: { Console.WriteLine("Opção inválida."); } break;
                }   
            }
        }

        public void AdicionarCarros(ref string[,] carros)
        {
            AumentaLista(ref carros);
            Console.Clear();

            Console.WriteLine("Informe a placa do carro: ");
            var placaCarro = Console.ReadLine();

            for (int x = 0; x < carros.GetLength(0); x++)
            {
                if (placaCarro == carros[x,0] && carros[x,3] == null)
                {
                    Console.Clear();
                    Console.WriteLine("Erro! Carro já registrado.\n");
                    Console.ReadKey();
                    break;
                } else
                {
                    Console.WriteLine("Informe o modelo do carro: ");
                    var modeloCarro = Console.ReadLine();

                    for (int i = 0; i < carros.GetLength(0); i++)
                    {
                        if (carros[i, 0] != null)
                            continue;

                        carros[i, 0] = placaCarro.ToString();
                        carros[i, 1] = modeloCarro;
                        carros[i, 2] = DateTime.Now.ToString();
                        carros[i, 3] = null;
                    }
                    Console.WriteLine("Entrada realizada com sucesso!");
                    Console.ReadKey();
                }
            }
        }

        public void ListarCarros(string[,] carros)
        {
            Console.Clear();
            Console.WriteLine("Lista de carros do sistema:\n\n");

            for (int i = 0; i < carros.GetLength(0); i++)
            {
                if (carros[i,3] == null)
                {
                    Console.WriteLine($"Placa: {carros[i, 0]} | Modelo: {carros[i, 1]} | Hora da Entrada: {carros[i, 2]}\n");
                } 
            }
            Console.ReadKey();
        }

        public void HistoricoDeSaida(string[,] carros)
        {
            Console.Clear();
            Console.WriteLine("Historico de Saídas:\n\n");

            for (int i = 0; i < carros.GetLength(0); i++)
            {
                if (carros[i, 3] != null)
                {
                    Console.WriteLine($"Placa: {carros[i, 0]} | Modelo: {carros[i, 1]} | Hora da Entrada: {carros[i, 2]} | Hora da Saída {carros[i,3]}\n");
                }
            }
            Console.ReadKey();
        }

        public void ExcluirAlunos(string[,] carros)
        {
            Console.Clear();

            for (int i = 0; i < carros.GetLength(0); i++)
            {
                if (carros[i, 3] == null)
                {
                    Console.WriteLine($"Placa: {carros[i, 0]} | Modelo: {carros[i, 1]} | Hora da Entrada: {carros[i, 2]}\n");
                }
            }
            Console.WriteLine("Informe a plcada do carro que está saindo: ");
            var placa = Console.ReadLine();

            for (int i = 0; i < carros.GetLength(0); i++)
            {
                if (carros[i, 0] != null && carros[i, 0] == placa)
                {
                    carros[i, 3] = DateTime.Now.ToString();
                }
            }
            Console.WriteLine("Saída realizada com sucesso!");
            Console.ReadKey();
        }
            public static void AumentaLista(ref string[,] listaCarros)
        {
            var limiteLista = true;

            for (int i = 0; i < listaCarros.GetLength(0); i++)
            {
                if (listaCarros[i, 0] == null)
                {
                    limiteLista = false;
                }
            }

            if (limiteLista)
            {
                var novaBase = listaCarros;

                listaCarros = new string[listaCarros.GetLength(0) + 1, 6];

                for (int i = 0; i < novaBase.GetLength(0); i++)
                {
                    listaCarros[i, 0] = novaBase[i, 0];
                    listaCarros[i, 1] = novaBase[i, 1];
                    listaCarros[i, 2] = novaBase[i, 2];
                    listaCarros[i, 3] = novaBase[i, 3];
                }
            }
        }
    }
}
