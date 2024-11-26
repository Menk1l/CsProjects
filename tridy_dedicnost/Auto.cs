using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tempo
{
    internal class Auto : Vozidlo
    {
        public int _pocet_dveri;

        public Auto(int sedadla, string výrobce, int rychlost, int pocet_dveri) : base(sedadla, výrobce, rychlost)
        {
            _pocet_dveri = pocet_dveri;


        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Pocet dveri: {_pocet_dveri}");
        }

        public override void Start()
        {
            Console.WriteLine("Auto bylo nastartováno.");
        }

    }
}
