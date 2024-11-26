using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tempo
{
    internal class Vozidlo
    {
        protected int _sedadla;
        protected string _výrobce;
        protected int _rychlost;

        
        public Vozidlo(int sedadla, string výrobce, int rychlost)
        {
            _sedadla = sedadla;
            _výrobce = výrobce;
            _rychlost = rychlost;

        }

        public virtual void Info()
        {

            Console.WriteLine($"Sedadla: {_sedadla}\nVýrobce {_výrobce}\nRachlost: {_rychlost}");
        }


        public virtual void Start()
        {
            Console.WriteLine("Vozidlo bylo nastartováno.");
        }

    }
}
