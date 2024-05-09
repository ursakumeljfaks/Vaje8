using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valj
{
    internal class ValjTesti
    {
        static void Main(string[] args)
        {
            Valj v1 = new Valj(1, 1);
            Valj v2 = new Valj(2, 2);
            Console.WriteLine(v1.Prostornina());
            Console.WriteLine(v2.Prostornina());
            Console.WriteLine(v1.Ploscina());
            Console.WriteLine(v2.Ploscina());
            Console.WriteLine(v1.Obseg());
            Console.WriteLine(v2.Obseg());

            Valj v3 = new Valj(0, 0);
            Console.WriteLine(v3);

            //Valj v4 = new Valj(1, -1);
            //Console.WriteLine(v4);

            Valj v5 = new Valj(0, 1);
            Console.WriteLine(v5);

            Valj v6 = new Valj(6, 0);
            Console.WriteLine(v6);

            //Console.WriteLine(v5 * v6);

            Console.WriteLine(v1+v2);
        }
    }
}
