using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class NullableClasss
    {
        public static void Show() {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            Console.WriteLine("显示可空类型的值 {0}, {1}, {2}", num1, num2, num3);

            num1 = 11;
            num3 = 2.4;
            Console.WriteLine("显示可空类型的值 {0}, {1}, {2}", num1, num2, num3);
        }
    }
}
