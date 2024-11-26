using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tempo
{
    internal class Program
    {
        static void Main(string[] args)
        {





            /*
            int x = 25;
            string[] karty = new string[x];

            karty[0] = "1";
            karty[1] = "2";
            karty[2] = "3";

            Random rand = new Random();
            int index = rand.Next(x);


            Console.WriteLine($"Zadejte počet hráčů: ");
            int pocet_hracu = int.Parse(Console.ReadLine());

            Console.WriteLine($"{karty[index]}");
            for (int i = 1; i < pocet_hracu; i++)
            {
                Console.WriteLine($"Hráč {i} vybere větu: ");
                Console.WriteLine($"1) "); Console.Write($"{karty[index]}");
                Console.WriteLine($"2) "); Console.Write($"{karty[index]}");

            }*/

            

           
            Console.WriteLine(kalkulacka.Dan(100));
            Console.WriteLine(kalkulacka.Zdravotni(100));
            Console.WriteLine(kalkulacka.Socialni(100));


            Console.ReadKey();
        }
        
    }
}
