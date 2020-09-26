using System;
using System.Collections.Generic;
using System.Text;

namespace RectangApplication
{
    class Rectangle
    {
        //成员变量
        double length;
        double width;
        public void Acceptdetails() {
            length = 4.5;
            width = 3.5;
        
        }

        public double Area => length * width;

        public void Display() {
            // 必须记得加分号;
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);

        
        }


    }
}
