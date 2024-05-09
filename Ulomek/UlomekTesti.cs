using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulomek
{
    internal class UlomekTesti
    {
        static void Main(string[] args)
        {
            Ulomek ul1 = new Ulomek(-1, 2); // -1/2
            Console.WriteLine(ul1);

            Ulomek ul2 = new Ulomek(-1, -2); // 1/2
            Console.WriteLine(ul2);

            Ulomek ul3 = new Ulomek(1, -4); // -1/4
            Console.WriteLine(ul3);

            Ulomek ul4 = new Ulomek(10, 20); // 10/20
            ul4.Okrajsaj();
            Console.WriteLine("Okrajsan 10/20 = " + ul4);

            Console.WriteLine(ul4 + ul1); // 0
            Console.WriteLine(ul4 * ul2); // 10/40
            Console.WriteLine(ul4 - ul4); // 0
            Console.WriteLine((ul4 / ul4)); // 1
            Console.WriteLine(ul4.CompareTo(ul1)); // 1
        }
    }
}
