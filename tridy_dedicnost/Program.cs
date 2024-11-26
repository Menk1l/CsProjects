using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Net.Sockets;
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

            Vozidlo[] vozidla = new Vozidlo[]
            {
                new Auto(2, "Mazda", 45, 4),
                new Motorka(1, "Hayabusa", 150, 2),
            };

            Zvire[] zver = new Zvire[]
            {
                new Pes(5, 5, "Labrador"),
                new Kocka(2, 2, "Siamská"),
            };

            for (int i = 0; i < vozidla.Length; i++)
            {
                vozidla[i].Info();
                vozidla[i].Start();
                Console.Write("\n");
            }

            for (int i = 0; i < zver.Length; i++)
            {
                zver[i].Projev();
                
                Console.Write("\n");
            }



            Console.ReadKey();
        }
        
    }
}
