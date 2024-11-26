using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tempo
{
    internal class Motorka : Vozidlo
    {
        int _pocet_kol;

        public Motorka(int sedadla, string výrobce, int rychlost, int pocet_kol) : base(sedadla, výrobce, rychlost)
        {
            _pocet_kol = pocet_kol;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Kola: {_pocet_kol}");
        }

        public override void Start()
        {
            Console.WriteLine("Motorka byla nastartována.");
        }

    }
}
