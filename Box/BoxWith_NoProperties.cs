using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxWith_NoProperities
{
    class Box {
        private double b, l, w;

        public void setLength(double l)
        {
            this.l = l;
        }

        public void setBase(double b)
        {
            this.b = b;
        }

        public void setWidth(double w)
        {
            this.w = w;
        }

        public double getLength()
        {
            return l;
        }

        public double getBase()
        {
            return b;
        }

        public double getWidth()
        {
            return w;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Box b = new Box();
            b.setBase(10);
            b.setLength(3);
            b.setWidth(5);

            Console.WriteLine("Base {0}, Width {1}, Length {2}", b.getBase(), b.getWidth(), b.getLength());

            Console.ReadKey();
        }
    }
}
