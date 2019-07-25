using FearOfTheDarkBeep.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FearOfTheDarkBeep
{
    class Program
    {
        static void Main(string[] args)
        {
            var musicas = new Musicas();
            var opcao = ShowMenu();
            while (true)
            {
                switch (opcao)
                {
                    case "1": {
                            Console.Clear();
                            musicas.Fear();
                        } break;
                    case "2": {
                            Console.Clear();
                            musicas.SmokeOnTheWater();
                        } break;
                    case "3": {
                            Console.Clear();
                            musicas.ComeAsYouAre();
                        } break;
                    case "4": {
                            Console.Clear();
                            musicas.HighwayToHell();
                        } break;
                    case "5": {
                            Console.Clear();
                            musicas.Paranoid();

                        } break;
                    case "6": {
                            Console.Clear();
                            musicas.Sunshine();

                        } break;
                    case "7": {
                            Console.Clear();
                            musicas.Misterio();
                        } break;
                    case "8": {
                            musicas.Teclado();
                        } break;
                    case "9": { Environment.Exit(0); } break;
                    default:
                        { Console.WriteLine("Opção inválida, tente novamente."); }
                        break;
                }
                opcao = ShowMenu();
            }
        }

        public static string ShowMenu ()
        {
            Console.Clear();

            Console.WriteLine("Escolha uma opção: \n");
            Console.WriteLine("1 - Fear of the beep");
            Console.WriteLine("2 - Beep on the water");
            Console.WriteLine("3 - Come as you beep");
            Console.WriteLine("4 - Highway to beep");
            Console.WriteLine("5 - Paranoid");
            Console.WriteLine("6 - Sunshine of your Beep");
            Console.WriteLine("7 - Projeto");
            Console.WriteLine("8 - Sair");

            return Console.ReadLine();
        }

    }
}
