﻿using System;
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
            #region Notas
            int C1 = 261;
            int Csus1 = 277;
            int D1 = 293;
            int Dsus1 = 311;
            int E1 = 329;
            int F1 = 349;
            int Fsus1 = 370;
            int G1 = 392;
            int Gsus1 = 415;
            int A1 = 440;
            int Asus1 = 466;
            int B1 = 493;

            int C2 = 523;
            int Csus2 = 554;
            int D2 = 587;
            int Dsus2 = 622;
            int E2 = 659;
            int F2 = 698;
            int Fsus2 = 740;
            int G2 = 784;
            int Gsus2 = 830;
            int A2 = 880;
            int Asus2 = 932;
            int B2 = 987;
            #endregion

            
            var opcao = ShowMenu();

            while (true)
            {
                switch (opcao)
                {
                    case "1":
                        {
                            //Inicio da Intro
                            Console.Beep(D2, 900);
                            Console.Beep(A1, 300);
                            Console.Beep(A1, 300);
                            Console.Beep(D2, 300);
                            Console.Beep(D2, 300);
                            Console.Beep(E2, 300);
                            Console.Beep(E2, 300);
                            Console.Beep(F2, 300);
                            Console.Beep(F2, 300);
                            Console.Beep(E2, 300);
                            Console.Beep(E2, 300);
                            Console.Beep(D2, 300);
                            Console.Beep(D2, 300);
                            Console.Beep(E2, 300);
                            Console.Beep(D2, 300);


                            Console.Beep(C2, 900);
                            Console.Beep(G1, 300);
                            Console.Beep(G1, 300);
                            Console.Beep(C2, 300);
                            Console.Beep(C2, 300);
                            Console.Beep(D2, 300);
                            Console.Beep(D2, 300);
                            Console.Beep(E2, 300);
                            Console.Beep(E2, 300);
                            Console.Beep(D2, 300);
                            Console.Beep(D2, 300);
                            Console.Beep(C2, 300);
                            Console.Beep(C2, 300);
                            Console.Beep(E2, 300);
                            Console.Beep(C2, 300);

                            //Muda Tonalidade

                            Console.Beep(Gsus1, 300);
                            Console.Beep(Gsus1, 300);
                            Console.Beep(Dsus1, 300);
                            Console.Beep(Dsus1, 300);
                            Console.Beep(Gsus1, 300);
                            Console.Beep(Gsus1, 300);
                            Console.Beep(Asus1, 300);
                            Console.Beep(Asus1, 300);
                            Console.Beep(B1, 300);
                            Console.Beep(B1, 300);
                            Console.Beep(Asus1, 300);
                            Console.Beep(Asus1, 300);
                            Console.Beep(Gsus1, 300);
                            Console.Beep(Gsus1, 300);
                            Console.Beep(Asus1, 300);
                            Console.Beep(Gsus1, 300);

                            Console.Beep(Fsus1, 300);
                            Console.Beep(Fsus1, 300);
                            Console.Beep(Csus1, 300);
                            Console.Beep(Csus1, 300);
                            Console.Beep(Fsus1, 300);
                            Console.Beep(Fsus1, 300);
                            Console.Beep(Gsus1, 300);
                            Console.Beep(Gsus1, 300);
                            Console.Beep(Asus1, 300);
                            Console.Beep(Asus1, 300);
                            Console.Beep(Gsus1, 300);
                            Console.Beep(Gsus1, 300);
                            Console.Beep(Fsus1, 300);
                            Console.Beep(Fsus1, 300);
                            Console.Beep(Asus1, 300);
                            Console.Beep(Fsus1, 300);


                            Console.Beep(Gsus1, 300);
                            Thread.Sleep(20);
                            Console.Beep(Gsus1, 300);
                            Thread.Sleep(20);
                            Console.Beep(Dsus1, 300);
                            Thread.Sleep(20);
                            Console.Beep(Dsus1, 300);
                            Thread.Sleep(20);
                            Console.Beep(Gsus1, 300);
                            Thread.Sleep(20);
                            Console.Beep(Gsus1, 300);
                            Thread.Sleep(20);
                            Console.Beep(Asus1, 300);
                            Thread.Sleep(20);
                            Console.Beep(Asus1, 300);
                            Thread.Sleep(20);
                            Console.Beep(B1, 300);
                            Thread.Sleep(20);
                            Console.Beep(B1, 300);
                            Thread.Sleep(20);
                            Console.Beep(Asus1, 300);
                            Thread.Sleep(20);
                            Console.Beep(Asus1, 300);
                            Thread.Sleep(20);
                            Console.Beep(Gsus1, 300);
                            Thread.Sleep(20);
                            Console.Beep(Gsus1, 300);
                            Thread.Sleep(20);
                            Console.Beep(Asus1, 300);
                            Thread.Sleep(20);
                            Console.Beep(Gsus1, 300);
                            Thread.Sleep(20);

                            Console.Beep(E1, 300);
                            Console.Beep(E1, 300);
                            Console.Beep(C1, 300);
                            Console.Beep(C1, 300);
                            Console.Beep(F1, 300);
                            Console.Beep(F1, 300);
                            Console.Beep(G1, 300);
                            Console.Beep(G1, 300);
                            Console.Beep(A1, 300);
                            Console.Beep(A1, 300);
                            Console.Beep(G1, 300);
                            Console.Beep(G1, 300);
                            Console.Beep(F1, 300);
                            Console.Beep(F1, 300);
                            Console.Beep(A1, 500);
                            Console.Beep(F1, 1200);

                            Thread.Sleep(600);

                            // Riff 1
                            Console.Beep(A1, 200);
                            Console.Beep(D2, 400);
                            Console.Beep(E2, 200);
                            Console.Beep(F2, 400);
                            Console.Beep(G2, 400);
                            Console.Beep(F2, 400);
                            Console.Beep(E2, 200);
                            Console.Beep(C2, 600);

                            Console.Beep(G1, 200);
                            Console.Beep(C2, 400);
                            Console.Beep(G1, 200);
                            Console.Beep(Asus1, 600);

                            Console.Beep(C2, 400);
                            Console.Beep(C2, 400);
                            Console.Beep(F2, 200);
                            Console.Beep(D2, 600);

                            Console.Beep(A1, 200);
                            Console.Beep(D2, 400);
                            Console.Beep(E2, 200);
                            Console.Beep(F2, 400);
                            Console.Beep(G2, 400);
                            Console.Beep(F2, 400);
                            Console.Beep(E2, 200);
                            Console.Beep(C2, 1200);

                            Thread.Sleep(1200);

                            Console.Beep(A1, 200);
                            Console.Beep(D2, 400);
                            Console.Beep(E2, 200);
                            Console.Beep(F2, 400);
                            Console.Beep(G2, 400);
                            Console.Beep(F2, 400);
                            Console.Beep(E2, 200);
                            Console.Beep(C2, 600);

                            Console.Beep(G1, 200);
                            Console.Beep(C2, 400);
                            Console.Beep(G1, 200);
                            Console.Beep(Asus1, 800);

                            Console.Beep(C2, 400);
                            Console.Beep(C2, 400);
                            Console.Beep(F2, 200);
                            Console.Beep(D2, 600);

                            Console.Beep(A1, 200);
                            Console.Beep(D2, 400);
                            Console.Beep(E2, 200);
                            Console.Beep(F2, 400);
                            Console.Beep(G2, 400);
                            Console.Beep(F2, 400);
                            Console.Beep(E2, 200);
                            Console.Beep(C2, 1200);
                        }
                        break;
                    case "2": { } break;
                    case "3": { } break;
                    case "4": { Environment.Exit(0); } break;
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
            Console.WriteLine("1 - Fear Of The Beep");
            Console.WriteLine("4 - Sair");

            return Console.ReadLine();
        }

    }
}
