using System;
namespace ConsoleApp2
{
    public class MyArray
    {
        public void Show(){
            int[][] a = new int[][]{
                new int[]{0, 0}, new int[]{1, 2},
                new int[]{2, 4}, new int[]{3, 6},
                 new int[]{4, 8}
            };
            
            int i, j;
            //输出
            for (i = 0; i< 5; i++){
                for (j = 0; j< 2; j++){
                    Console.WriteLine($"第{i}行-{j}列, {a[i][j]}");
                }
            }

        }
    }
}