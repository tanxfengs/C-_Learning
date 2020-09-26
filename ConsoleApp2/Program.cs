using System;
using ConsoleApp2.StringClass;
using ConsoleApp2.Structure;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[][] scores = new int[5][];
            for (int i = 0; i < scores.Length; i++) 
            {
                scores[i] = new int[4];
            }
            Console.WriteLine(scores);

            new MyArray().Show();
            // 传递数组参数
            int[] balence = new int[]{1000, 2, 3, 17, 50};

            double val = ArrayParam.GetAverage(balence, 5);
            Console.WriteLine("数组传递给函数, result-{0}",val);
            int sum = new ArrayApplication2().AddElements(512, 24, 512, 516, 61);
            Console.WriteLine($"总和是{sum}");

            //Array类方法
            new MyArray2().Show();

            //字符串
            new StringApp().Show();

            //结构图
            TestStructure.Show();

            //枚举
            TestEnum.Show();

            //类
            Line line = new Line();
            line.Show();

            Box box1 = new Box();
            Box box2 = new Box();
            //Box box3 = new Box();
            double volume;

            box1.setLength(6.0);
            box1.setBreadth(7.0);
            box1.setHeight(5.0);

            //box2 
            box2.setLength(16.0);
            box2.setBreadth(17.0);
            box2.setHeight(15.0);
            // box1的体积
            volume = box1.getVolume();
            Console.WriteLine($"box1 的体积是: {volume}");
            
            //Box2 的体积
            volume = box2.getVolume();
            Console.WriteLine($"box2 的体积是: {volume}");

            //Box3
            Box box3 = box1 + box2;
            volume = box3.getVolume();
            Console.WriteLine($"box3 的体积是: {volume}");
        }
    }
}
