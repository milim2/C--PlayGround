using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Animal // sealed  class Animal: if a  class is sealed means no one can inherit  from it
    {
        public string type = "doberman";

        // virtual any child classs can modify a method
        // that is deemed virtual in the parent class
        public virtual void Greet() // public override ~~ testing해보기

        {
            Console.WriteLine("Hello~ I am an animal!!");
        }


    }
}
