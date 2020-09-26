using System;
namespace ConsoleApp2
{
    public class MyArray2
    {
        public void Show(){
            int[] list = {34, 62, 21, 51, 51, 63, 12};
            Console.WriteLine("原始数组");
            foreach (int i in list)
            {
                Console.WriteLine(i + " ");
            }
            //逆转数组
            Array.Reverse(list);
            Console.Write("逆转数组: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //排序数组
            Array.Sort(list);
            Console.Write("排序数组:");
            foreach (int i in list){
                Console.WriteLine(i + "");
            }
            {
                
            }

        }
    }
}