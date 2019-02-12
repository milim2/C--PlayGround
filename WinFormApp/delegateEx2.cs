using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx2
{
    class Program
    {
        // this delegate will reference more than 1 method
        delegate int funcDelegate(int x, int y);


        static void Main(string[] args)
        {
            funcDelegate d1 = add;
            //funcDelegate d2 = mult; // short ways of referencing delegate
            funcDelegate d2 = d1; // 
            funcDelegate d3 = new funcDelegate(mult); // longer way of assigning a reference
            Console.WriteLine("The sum 5 and 6 ", + d1(5, 6));
            Console.WriteLine("The result of multiplying 5 and 6 ", + d2(5, 6));
            Console.WriteLine("The result of multiplying 5 and 6 ", + d3(5, 5));
        }

        static int add(int x, int y)
        {
            return x + y;
        }

        static int mult(int x, int y)
        {
            return x * y;
        }

    }
}
