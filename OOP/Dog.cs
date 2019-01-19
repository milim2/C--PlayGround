using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Dog: Animal
    {
        public string type = "capivara(Brazilian rodent)";

        // if a child wants to override a method in the parent,
        // it needs the keyword override
        public override void Greet()
        {
            Console.WriteLine("Mooooo? I am a capivara");
            base.Greet();
            //base is like Java's super
            Console.WriteLine("Using the dog class: " + type);
            Console.WriteLine("Using the Animal class: " + base.type);

        }
    }
}
