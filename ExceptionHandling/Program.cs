using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExceptionHandling
{

    class DivNumbers
    {
        int result;
        public DivNumbers()
        {
            result = 0;
        }
        public void division(int num, int num2)
        {
            try
            {
                result = num / num2; // what if denomitator = 0
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception error {0}", e);
                // CWL on quiz/test
            }
            finally
            {
                Console.WriteLine("Result {0} ", result);
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            DivNumbers d = new DivNumbers(); 
            d.division(10, 0);
            Console.ReadKey();
            
        }
    }
}
