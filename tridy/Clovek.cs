using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classy
{
    internal class Clovek
    {
        private string jmeno;
        private int vek;
        private int rokNarozeni;

        public Clovek(string jmeno, int vek, int rokNarozeni)
        {
            this.jmeno = jmeno;
            this.vek = vek;
            this.rokNarozeni = rokNarozeni;
        }

        public string Jmeno { get => jmeno; set => jmeno = value; }
        public int Vek { get => vek; set => vek = value; }
        public int RokNarozeni{ get => rokNarozeni; set => rokNarozeni = value; }

       
        public void Pozdrav(Clovek clovek)
        {
            Console.WriteLine($"Ahoj {clovek.Jmeno}, ja jsem {this.Jmeno}");
        }

        public void Info()
        {
            Console.WriteLine($"{this.Jmeno}: {this.Vek}, {this.rokNarozeni}");
        }


    }
}
