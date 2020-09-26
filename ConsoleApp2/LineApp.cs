using System;
/*
析构函数
*/
namespace ConsoleApp2
{
    public class Line
    {
        private double length;
        public Line(){
            Console.WriteLine("对象已经创建");
        }

        ~Line(){
            Console.WriteLine("对象已经删除");
        }

        public void setLength(double len){
            length = len;
        }

        public double getLength(){
            return length;
        }

        public void Show(){
            setLength(6.0);

            Console.WriteLine("线条的长度: {0}", getLength());
        }
    }
}