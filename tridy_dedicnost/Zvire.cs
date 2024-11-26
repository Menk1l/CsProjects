using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tempo
{
    abstract class Zvire
    {
        protected int _vek;
        protected int _vaha;
        protected string _druh;

        public Zvire(int vek, int vaha, string druh)
        {
            _vek = vek;
            _vaha = vaha;
            _druh = druh;
        }

        public abstract void Projev();
        

        
    }
}
