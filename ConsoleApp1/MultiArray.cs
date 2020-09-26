using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MultiArray
    {
        public void Show() {
            string[,] names = new String [2,3]{
                {"1", "2", "3" },
                {"4", "5", "6"}
                
            }; //[[], []]
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++) {
                    Console.WriteLine("???{0}", names[i, j]);
                }
            }
            
        }
    }
}
