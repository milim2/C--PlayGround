using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Defined_Exceptions
{

    class TestTemperature
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();

            try
            {
                temp.showTemp(); // 
            }
            catch (TemperatureIsZeroException e)
            {
                Console.WriteLine("Temperature is 0 {0} ", e.Message);
            }
            Console.ReadKey();
        }
    }
    // creating our own exception
    public class TemperatureIsZeroException : Exception
    {
        // most common 
        public TemperatureIsZeroException(string message) : base(message) // calling the parent instructor -- base class constructor 
        { 
            }

        public TemperatureIsZeroException()
        {

        }

        public TemperatureIsZeroException(string message, Exception inner) : base(message, inner) 
            // calling the parent instructor 
        {

            // explain  what is going on here 42 line -- HOMEWORK 
        }
    }

    public class Temperature
    {
        int temperature = 0;
        public void showTemp()
        {
            if (temperature == 0)
            {
                throw (new TemperatureIsZeroException("Zero temperature found"));
            }
            else
            {
                // CWL
                Console.WriteLine("Temperature is {0} ", temperature);
            }
        }
    }
}
