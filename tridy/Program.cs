using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Classy
{
    internal class Program
    {
        static void Main(string[] args)
        {

           Clovek hanus = new Clovek("Hanuš",17,2007);

           Clovek Bogdan = new Clovek("Bogdan",26,1999);

           Zvire pes = new Zvire("pes",5,"samec");

            hanus.Pozdrav(Bogdan);

            pes.Info();

            Kniha halus = new Kniha("Hanus", 299, "jsd", "han", 26);

            Console.ReadKey();


        }
    }
}
