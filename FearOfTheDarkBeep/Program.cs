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
                            Console.Clear();
                            Console.WriteLine("***Tocando Fear of the beep***");
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
                    case "2": {
                            Console.Clear();
                            Console.WriteLine("***Tocando Beep on the water***");
                            Console.Beep(D1,550);
                            Thread.Sleep(20);
                            Console.Beep(F1,550);
                            Thread.Sleep(20);
                            Console.Beep(G1,800);
                            Thread.Sleep(280);

                            Console.Beep(D1, 550);
                            Thread.Sleep(20);
                            Console.Beep(F1, 550);
                            Thread.Sleep(20);
                            Console.Beep(Gsus1, 200);
                            Thread.Sleep(20);
                            Console.Beep(G1, 800);

                            Thread.Sleep(200);

                            Console.Beep(D1, 550);
                            Thread.Sleep(20);
                            Console.Beep(F1, 550);
                            Thread.Sleep(20);
                            Console.Beep(G1, 650);
                            Thread.Sleep(280);
                            Console.Beep(F1, 550);
                            Thread.Sleep(10);
                            Console.Beep(D1, 800);
                            Thread.Sleep(20);

                        } break;
                    case "3": {
                            Console.Clear();
                            Console.WriteLine("***Tocando Come as you beep***");
                            Console.Beep(E1,300);
                            Console.Beep(E1,300);
                            Console.Beep(F1,300);
                            Console.Beep(Fsus1,600);

                            Console.Beep(A1, 300);
                            Console.Beep(Fsus1, 300);
                            Console.Beep(A1, 300);
                            Console.Beep(Fsus1, 300);
                            Console.Beep(Fsus1, 300);
                            Console.Beep(F1, 300);
                            Console.Beep(E1, 300);
                            Console.Beep(B1, 300);
                            Console.Beep(E1, 300);
                            Console.Beep(E1, 600);

                            // Divisor 

                            Console.Beep(B1, 300);
                            Console.Beep(E1, 300);
                            Console.Beep(F1, 300);
                            Console.Beep(Fsus1, 600);

                            Console.Beep(A1, 300);
                            Console.Beep(Fsus1, 300);
                            Console.Beep(A1, 300);
                            Console.Beep(Fsus1, 300);
                            Console.Beep(Fsus1, 300);
                            Console.Beep(F1, 300);
                            Console.Beep(E1, 300);
                            Console.Beep(B1, 300);
                            Console.Beep(E1, 300);
                            Console.Beep(E1, 600);

                            Console.Beep(B1, 300);
                            Console.Beep(E1, 300);
                            Console.Beep(F1, 300);
                            Console.Beep(Fsus1, 600);

                            Console.Beep(A1, 300);
                            Console.Beep(Fsus1, 300);
                            Console.Beep(A1, 300);
                            Console.Beep(Fsus1, 300);
                            Console.Beep(Fsus1, 300);
                            Console.Beep(F1, 300);
                            Console.Beep(E1, 300);
                            Console.Beep(B1, 300);
                            Console.Beep(E1, 300);
                            Console.Beep(E1, 600);

                            Console.Beep(B1, 300);
                            Console.Beep(E1, 300);
                            Console.Beep(F1, 300);
                            Console.Beep(Fsus1, 600);

                            Console.Beep(A1, 300);
                            Console.Beep(Fsus1, 300);
                            Console.Beep(A1, 300);
                            Console.Beep(Fsus1, 300);
                            Console.Beep(Fsus1, 300);
                            Console.Beep(F1, 300);
                            Console.Beep(E1, 300);
                            Console.Beep(B1, 300);
                            Console.Beep(E1, 300);
                            Console.Beep(E1, 600);
                            Thread.Sleep(600);
                        } break;
                    case "4": {
                            Console.Clear();
                            Console.WriteLine("***Tocando Highway to beep***");
                            Console.Beep(A1,280);
                            Console.Beep(A1,280);
                            Console.Beep(A1,280);
                            Thread.Sleep(1200);

                            Console.Beep(Fsus1, 280);
                            Console.Beep(Fsus1, 280);
                            Console.Beep(G1, 280);
                            Thread.Sleep(1200);

                            Console.Beep(Fsus1, 280);
                            Console.Beep(Fsus1, 280);
                            Console.Beep(G1, 280);
                            Thread.Sleep(320);
                            Console.Beep(Fsus1, 280);
                            Console.Beep(Fsus1, 250);
                            Console.Beep(G1, 280);
                            Console.Beep(Fsus1, 280);
                            Thread.Sleep(360);
                            Console.Beep(A1,280);
                            Console.Beep(A1,280);

                            Thread.Sleep(1200);

                            Console.Beep(A1, 280);
                            Console.Beep(A1, 280);
                            Console.Beep(A1, 280);
                            Thread.Sleep(1200);

                            Console.Beep(Fsus1, 280);
                            Console.Beep(Fsus1, 280);
                            Console.Beep(G1, 280);
                            Thread.Sleep(1200);

                            Console.Beep(Fsus1, 280);
                            Console.Beep(Fsus1, 280);
                            Console.Beep(G1, 280);
                            Thread.Sleep(320);
                            Console.Beep(Fsus1, 280);
                            Console.Beep(Fsus1, 250);
                            Console.Beep(G1, 280);
                            Console.Beep(Fsus1, 280);
                            Thread.Sleep(360);
                            Console.Beep(A1, 280);
                            Console.Beep(A1, 280);


                        }  break;
                    case "5": { Environment.Exit(0); } break;
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
            Console.WriteLine("5 - Sair");

            return Console.ReadLine();
        }

    }
}
