using ConstTest;
using RectangApplication;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Application
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            string str = "C:\\";
            string str2 = @"C:\"; //@符号相当于转义字符串 python中的r''
            Console.WriteLine(str);
            Console.WriteLine(str == str2);

            string str3 = @"1
                2
3
";
            Console.WriteLine(str3);

            SampleClass sc = new SampleClass(11, 22);
            Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);
            Console.WriteLine("c1 = {0}", SampleClass.c1); //相当于只能通过类来访问这个常量变量

            //for 循环
            Loop lp = new Loop();
            lp.loopNum();

            // for each 循环
            ForEachLoop fel = new ForEachLoop();
            fel.loopArr();

            NullableClasss.Show();
            new MultiArray().Show();

            int[] intArr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var query1 = intArr[0..3];
            Console.WriteLine($"query1={string.Join(",", query1)}");

            //多维数组
            int[,] a = new int[5, 2] {
                {0, 0},{1, 2}, {2, 4}, {3, 6}, {4, 8}
            };


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0}, {1}] = {2}", i, j, a[i, j]);
                }
            }
            // string compare方法 比较的是unicode值
            int position = String.Compare("string1", "String2");
            Console.WriteLine("{0}", position);
    }
    }
}
