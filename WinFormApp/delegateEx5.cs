using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx5
{


    class Program
    {

        delegate void funcDelegate(int x, int y);

        static void Main(string[] args)
        {
            funcDelegate d1 = add;
            funcDelegate d2 = mult;
            funcDelegate d3 = d1 + d2;
            funcDelegate d4 = d2 + d1;
            d3(10, 20);
            d4(10, 20);

            Console.ReadKey();
        }

        static void add(int x, int y)
        {
            Console.WriteLine("The sum is : " + (x + y));
        }

        static void mult(int x, int y)
        {
            Console.WriteLine("The mult result is : " + (x * y));
        }

    }
}
