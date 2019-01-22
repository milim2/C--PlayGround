using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxwithProperties
{
    class Box
    {
        public double Length
        {
            get;set;
        }

        public double Width
        {
            get; set;
        }
        // 이런 타입으로 만드는건 속성 으로 만드는 거고 다른 타입으로 만드는 것은 밸류로 지정하는 거임
        public double Base
        {
            get; set;
        }
               
    }

    class Program
    {
        static void Main(string[] args)
        {

            Box box1 = new Box();
            box1.Base = 2;
            box1.Width = 3;
            box1.Length = 5;
            // properties 에 대해서 다시 공부
            Console.WriteLine("Base {0}, Width {1}, Length {2)", box1.Base, box1.Width, box1.Length);
            Console.ReadKey();

        }
    }
}
