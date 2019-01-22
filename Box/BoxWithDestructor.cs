using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxWithDestructor
{
    class Box
    {
        public double l, w, h; // what happens if we make these private?

        public double volume()
        {
            return l * w * h;
        }

        public Box()
        {
            Console.WriteLine("In the default constructor");
            // this id called each time we create an object
        }

        ~Box()
        {
            Console.WriteLine("In the destructor");
        }

        // Don't need to explicitly create the destructor
        // this is the Garbage Collector (GC) implicitly 
        // mananges the allocation and release of memory for your objects
        // However, when your application using unmanaged  resources such as files or
        // network connections it might be a good
        // idea to use destructor to free up these resources.
        // When the object that is eligible, the GC runs the finalized method

    }

    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            box1.l = 2.5;
            box1.w = 4;
            box1.h = 10;

            Console.WriteLine("The  volume is {0}", box1.volume());
           // Console.ReadKey();
        }
    }

    // More notes on Destructor
    // Can only be defined once in a class
    // Don't  call it. it is invoked automatically
    // The GC of the CLR manages the Destructor
    // automatically called at the program's exit
    // Can only be used in classes, not in structures
    // can't be overloaded or inherited
    // no modifiers and no parameters
    // The destructor implicitly calls the Finalize method of the base 
    // class of the object, therefore the destructors is implicitly translated as
    /*
    protected override void Finalize()
    {
        try
        {
            clean up statement
        }
        finally
        {
            Base64FormattingOptions.Finalize();
        }
    }
    */

    // Do NOT HAVE A DESTRUCTOR WITH NO CODE
    // this result in unoptimal code.

}
