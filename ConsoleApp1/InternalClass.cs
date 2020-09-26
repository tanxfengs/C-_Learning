using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class InternalClass
    {
        internal double length = 3.5;
        internal double width = 4.5;

        double GetArea() {
            return length * width;
        }

         public void Show() {
            GetArea();
        }

    }
}
