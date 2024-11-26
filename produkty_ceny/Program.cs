using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tempo
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
                    Console.WriteLine("Spatny vstup...");
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
                    Console.WriteLine("Spatny vstup...");
                }
                else
                {
                    ok = true;
                }
            }
            return lol;
        }

        static int Drazsi(double prumer, int pocet, (string, double, string)[] produkty)
        {
            int drazsi = 0;
            for (int i = 0; i < pocet; i++)
            {
                if (produkty[i].Item2 > prumer)
                {
                    drazsi++;
                }
            }
            return drazsi;
        }

        static double Prumer(int pocet, (string, double, string)[] produkty)
        {
            double soucet = 0;
            for (int i = 0; i < pocet; i++)
            {
                soucet += produkty[i].Item2;
            }

            double prumer = soucet / pocet;
            return prumer;
        }

        static (double, int) Max(int pocet, (string, double, string)[] produkty)
        {
            double max = 0;
            int index = 0;
            for (int i = 0; i < pocet; i++)
            {
                if (produkty[i].Item2 > max)
                {
                    max = produkty[i].Item2;
                    index = i;
                }
            }
            return (max, index);
        }

    

        
        static void Main(string[] args)
        {   //zapsání produktů a cen do pole
            Console.WriteLine("Zadejte pocet produktů: ");
            int pocet = ValidCheckInt(1);
            (string, double, string)[] produkty_a_ceny = new (string, double, string)[pocet];

            for (int i = 0; i < pocet; i++)
            {
                Console.WriteLine($"Zadejte název produktu {i + 1}: ");
                produkty_a_ceny[i].Item1 = Console.ReadLine();

                Console.WriteLine($"Zadejte cenu produktu {i + 1}: ");
                produkty_a_ceny[i].Item2 = ValidCheckDouble(1);

                Console.WriteLine($"Zadejte kategorii produktu - {i + 1} [Jídlo(1), Pití(2), Drogerie(3), Elektro(4), Ostatní(5)]: ");
                int vyber = ValidCheckInt(1);

             
                   //určení kategorie produktu
                    switch (vyber)
                    {
                        case 1:
                            produkty_a_ceny[i].Item3 = "Jídlo";
                            break;

                        case 2:
                            produkty_a_ceny[i].Item3 = "Pití";
                            break;

                        case 3:
                            produkty_a_ceny[i].Item3 = "Drogerie";
                            break;

                        case 4:
                            produkty_a_ceny[i].Item3 = "Elektro";
                            break;

                        case 5:
                            produkty_a_ceny[i].Item3 = "Ostatní";
                            break;

                        default:
                            Console.WriteLine("Tato kategorie není v nabídce.");
                            produkty_a_ceny[i].Item3 = "Neurčeno";
                        continue;
                    
                    }
            }

            Console.WriteLine("\n");


            //vypsání produktů (držte si klobouky, hodně for loopů)
                Console.WriteLine("Jídla:");
            for (int i = 0; i < pocet; i++)
            {
                if (produkty_a_ceny[i].Item3 == "Jídlo")
                {
                    Console.Write($"{produkty_a_ceny[i].Item1}: ");

                    Console.WriteLine($"{produkty_a_ceny[i].Item2} Kč\n");
                }
                else { continue; }
             
            }

                Console.WriteLine("Pití:");
            for (int i = 0; i < pocet; i++)
            {
                if (produkty_a_ceny[i].Item3 == "Pití")
                {
                    Console.Write($"{produkty_a_ceny[i].Item1}: ");

                    Console.WriteLine($"{produkty_a_ceny[i].Item2} Kč\n");
                }
                else { continue; }
            }

                Console.WriteLine("Drogerie:");
            for (int i = 0; i < pocet; i++)
            {
                if (produkty_a_ceny[i].Item3 == "Drogerie")
                {
                    Console.Write($"{produkty_a_ceny[i].Item1}: ");

                    Console.WriteLine($"{produkty_a_ceny[i].Item2} Kč\n");
                }
                else { continue; }
            }

                Console.WriteLine("Elektro:");
            for (int i = 0; i < pocet; i++)
            {
                if (produkty_a_ceny[i].Item3 == "Elektro")
                {
                    Console.Write($"{produkty_a_ceny[i].Item1}: ");

                    Console.WriteLine($"{produkty_a_ceny[i].Item2} Kč\n");
                }
                else { continue; }
            }

                Console.WriteLine("Ostatní:");
            for (int i = 0; i < pocet; i++)
            {
                if (produkty_a_ceny[i].Item3 == "Ostatní")
                {
                    Console.Write($"{produkty_a_ceny[i].Item1}: ");

                    Console.WriteLine($"{produkty_a_ceny[i].Item2} Kč\n");
                }
                else { continue; }
            }

                Console.WriteLine("Neurčeno:");
            for (int i = 0; i < pocet; i++)
            {
                if (produkty_a_ceny[i].Item3 == "Neurčeno")
                {
                    Console.Write($"{produkty_a_ceny[i].Item1}: ");

                    Console.Write($"{produkty_a_ceny[i].Item2} Kč\n");
                }
                else { continue; }
            }



            Console.WriteLine("\n");


            //Dělání operací pomocí funkcí
            double prumer = Prumer(pocet, produkty_a_ceny);
            var (max, maxIndex) = Max(pocet, produkty_a_ceny);
            int drahy_produkty = Drazsi(prumer, pocet, produkty_a_ceny);




            //vypsání proměn
            Console.WriteLine($"Prumer: {prumer} Kč");
            Console.WriteLine($"Nejdražší produkt: {max} Kč ({produkty_a_ceny[maxIndex].Item1} - {produkty_a_ceny[maxIndex].Item3})");
            Console.WriteLine($"Produkty dražší než průměrná cena: {drahy_produkty}");



            Console.ReadKey();
        }
    }
} // Dneska se mám fajnově, konečně se můj vztah někam posouvá <3
