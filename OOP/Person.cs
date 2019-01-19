using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Person: AbstractClass1, Interface1, Interface2
    {
        // classes that inherit come before 
        // interfaces that you implement
        public override void personsays()
        {
            Console.WriteLine("I am a human");
        }

        public void DoStuff()
        {
            Console.WriteLine("I am writing");
        }

        public void DoStuff2()
        {
            Console.WriteLine("I am running");
        }
        
        public void DoStuff3()
        {
            Console.WriteLine("I am eating");
        }
    }

    }

