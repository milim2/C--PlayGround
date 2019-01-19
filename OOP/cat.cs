using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class cat: Animal
    {
        public override void Greet()
        {
            Console.WriteLine("Meow ~~ I am a feline");
           // base.Greet();
        }

    }
}
