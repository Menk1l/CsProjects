using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tempo
{
    internal class Kocka : Zvire
    {
        public Kocka(int vek, int vaha, string druh) : base(vek, vaha, druh)
        {
        }

        public override void Projev() => Console.WriteLine("Kočka mňouká");
    }
}
