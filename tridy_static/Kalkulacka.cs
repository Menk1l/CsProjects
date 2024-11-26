using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tempo
{
    static internal class kalkulacka
    {
        static public double pi = 3.14;

        static public double Dan(double x)
        {
            double y = x * 0.15;
            x = x-y;
            return x;
        }

        static public double Socialni(double x)
        {
            double y = x * 0.071;
            x = x - y;
            return x;
        }

        static public double Zdravotni(double x)
        {
            double y = x * 0.045;
            x = x - y;
            return x;
        }


        static public double Urok(double castka, double procenta, double roky)
        {
            return castka * (procenta/100) * roky;
        }

       


    }
}
