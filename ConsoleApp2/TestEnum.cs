using System;
namespace ConsoleApp2
{
    public class TestEnum
    {
        enum Day
        {
            Sun, Mon, Tue, Web, Thu, Fri, Sat
        }

        public static void Show(){
            int x = (int)Day.Sun;
            int y = (int)Day.Fri;
            Console.WriteLine("Sun = {0}", x);
            Console.WriteLine("Fri = {0}", y);
        }

    }
}