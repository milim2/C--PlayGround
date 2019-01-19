using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    abstract class AbstractClass1 // 인터페이스랑 다른점 정리
    {
        public void print()
        {
            Console.WriteLine("Hi, there");

        }


        public abstract void personsays();
    }
}
