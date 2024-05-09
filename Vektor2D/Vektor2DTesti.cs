using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektor2D
{
    internal class Vektor2DTesti
    {
        static void Main(string[] args)
        {
            Vektor2D v1 = new Vektor2D(1, 1);
            Vektor2D v2 = new Vektor2D(1, 2);
            Console.WriteLine(v1);
            Console.WriteLine(v2);

            Console.WriteLine(v1+v2);
            Console.WriteLine(v1-v2);
            Console.WriteLine(v1*v2);

            Console.WriteLine(v1.Norma());
        }
    }
}
