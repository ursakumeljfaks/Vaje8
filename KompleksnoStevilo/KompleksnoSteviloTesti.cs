using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompleksnoStevilo
{
    internal class KompleksnoSteviloTesti
    {
        static void Main(string[] args)
        {
            KompleksnoStevilo ks1 = new KompleksnoStevilo(1, 2);
            Console.WriteLine(ks1);

            KompleksnoStevilo ks2 = new KompleksnoStevilo(1, 1);
            Console.WriteLine(ks2);

            KompleksnoStevilo ks3 = new KompleksnoStevilo(-1,-5);
            Console.WriteLine(ks3);

            Console.WriteLine(ks2.CompareTo(ks3));

            Console.WriteLine(ks1 + ks2);
            Console.WriteLine(ks1 - ks2);
            Console.WriteLine(ks1 * ks2);
            Console.WriteLine(ks1 / ks2);

            KompleksnoStevilo ks4 = new KompleksnoStevilo(0, 0);
            //Console.WriteLine(ks1 / ks4);

            ks3.Konjugirano();
            Console.WriteLine(ks3);
        }
    }
}
