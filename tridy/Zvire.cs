using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classy
{
    internal class Zvire
    {
        private string druh;
        private int vek;
        private string pohlavi;


        public Zvire(string druh, int vek, string pohlavi)
        {
            this.druh = druh;
            this.vek = vek;
            this.pohlavi = pohlavi;
        }

        public string Druh { get => druh; set => druh = value; }
        public int Vek { get => vek; set => vek = value; }
        public string Pohlavi { get => pohlavi; set => pohlavi = value; }

        public void Info()
        {
            Console.WriteLine($"Zvire je {this.Druh},{Vek} let, {Pohlavi}");
        }

    }
}
