using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlomekStaraVerzija
{
    internal class UlomekStaraVerzijaTesti
    {
        static void Main(string[] args)
        {

            UlomekStaraVerzija ul1 = new UlomekStaraVerzija(-1, 2); // -1/2
            Console.WriteLine(ul1);

            UlomekStaraVerzija ul2 = new UlomekStaraVerzija(-1, -2); // 1/2
            Console.WriteLine(ul2);

            UlomekStaraVerzija ul3 = new UlomekStaraVerzija(1, -4); // -1/4
            Console.WriteLine(ul3);

            UlomekStaraVerzija ul4 = new UlomekStaraVerzija(10, 20); // 10/20
            Console.WriteLine(ul4);

            Console.WriteLine(ul4 + ul1); // 0/40
            Console.WriteLine(ul4 * ul2); // 10/40
            Console.WriteLine(ul4 - ul4); // 0/400
            Console.WriteLine((ul4 / ul4)); // 200/200
            Console.WriteLine(ul4.CompareTo(ul1)); // 1

        }
    }
}
