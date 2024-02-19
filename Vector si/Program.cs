using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_si
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(6, 3);
            Vector v2 = new Vector(7, 2);
            Console.WriteLine("{0}", v1 + v2);
            Console.ReadLine();
        }
    }
}
