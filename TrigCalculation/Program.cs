using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrigCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            double lowerLimit, upperLimit, number_of_intervals, spaces;

            // NUMBER of INTERVALS is double to avoid integer division
            Console.WriteLine("Type in the lower value!");
            lowerLimit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type in the upper value!");
            upperLimit = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("HOw many intervals do you want?");
            number_of_intervals = Convert.ToDouble(Console.Read());

            spaces = (upperLimit - lowerLimit) / number_of_intervals;

            Program p = new Program();

            Console.WriteLine("x values                    y = sin(2x)           y = cos(3x)");
            double count = lowerLimit;

            while(count <= upperLimit)
            {
                Console.WriteLine(count + "           " + p.f(count) + "         " + p.g(count));
                count += spaces;
            }
            Console.ReadKey();
        }

         double f(double x)
        {
            return Math.Sin(2 * x);
        }

         double g(double x)
        {
            return Math.Cos(3 * x);
        }
    }
}
