using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication_Rectangles
{
    class Rectangle
    {
        private int length;
        private int width;
        
        public  void setLength(int length)
        {
            this.length = length;
        }

        public void setWidth(int width)
        {
            this.width = width;
        }

        public int CalculateArea()
        {
            return width * length;
        }

    }
}
