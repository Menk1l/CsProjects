using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    internal class Program
    {
        static double ValidCheckDouble(double lol)
        {
            bool ok = false;

            while (!ok)
            {

                if (!double.TryParse(Console.ReadLine(), out lol))
                {
                    Console.WriteLine("Spatny vstup...\n");
                }
                else
                {
                    ok = true;
                }
            }
            return lol;
        }


        static int ValidCheckInt(int lol)
        {
            bool ok = false;

            while (!ok)
            {

                if (!int.TryParse(Console.ReadLine(), out lol))
                {
                    Console.WriteLine("Spatny vstup...\n");
                }
                else
                {
                    ok = true;
                }
            }
            return lol;
        }

        static int Neprospelo(int pocet, (string, double)[] studenti)
        {
            int neprospelo = 0;
            for (int i = 0; i < pocet; i++)
            {
                if (studenti[i].Item2 < 50)
                {
                    neprospelo++;
                }
            }
            return neprospelo;
        }

        static double Prumer(int pocet, (string, double)[] studenti)
        {
            double soucet = 0;
            for (int i = 0; i < pocet; i++)
            {
                soucet += studenti[i].Item2;
            }

            double prumer = soucet / pocet;
            return prumer;
        }

        static (double, int) Max(int pocet, (string, double)[] studenti)
        {
            double max = 0;
            int index = 0;
            for (int i = 0; i < pocet; i++)
            {
                if (studenti[i].Item2 > max)
                {
                    max = studenti[i].Item2;
                    index = i;
                }
            }
            return (max, index);
        }

        static void barvicky(double vysledek)
        {
            if (vysledek > 80)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (vysledek <= 80 && vysledek >= 50)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            else if (vysledek < 50 && vysledek >= 25)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (vysledek < 25)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

        }
        static void Main(string[] args)
        {   //zapsání studentů do ´pole
            Console.WriteLine("Zadejte pocet studentu: ");
            int pocet = ValidCheckInt(1);
            (string, double)[] studenti_a_score = new (string, double)[pocet];

            for (int i = 0; i < pocet; i++)
            {
                Console.WriteLine($"Zadejte jmeno studenta {i + 1}: ");
                studenti_a_score[i].Item1 = Console.ReadLine();

                Console.WriteLine($"Zadejte vysledek studenta {i + 1}: ");
                studenti_a_score[i].Item2 = ValidCheckDouble(1);
            }

            Console.WriteLine("\n");

            //vypsání pole studentů
            for (int i = 0; i < pocet; i++)
            {
                Console.Write($"{studenti_a_score[i].Item1}: ");
                barvicky(studenti_a_score[i].Item2);
                Console.Write($"{studenti_a_score[i].Item2}%\n");
                Console.ResetColor();
            }

            Console.WriteLine("\n");



            //Dělání operací pomocí funkcí
            double prumer = Prumer(pocet, studenti_a_score);
            var (max, maxIndex) = Max(pocet, studenti_a_score);
            int neprospelo = Neprospelo(pocet, studenti_a_score);



            //vypsání proměn
            Console.Write($"Prumer: ");
            barvicky(prumer);
            Console.Write($"{prumer}%\n");
            Console.ResetColor();


            Console.Write($"Nejlepsi vysledek: ");
            barvicky(max);
            Console.Write($"{max}% ({studenti_a_score[maxIndex].Item1})\n");
            Console.ResetColor();

            Console.Write($"Neprospelo: ");
            if(neprospelo == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
            Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write($"{neprospelo}\n");
            Console.ResetColor();


            Console.ReadKey();
        }
    }
}
