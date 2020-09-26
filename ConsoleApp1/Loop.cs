using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Loop
    {
        public void loopNum() {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("i = {0}", i);
            }
        } 
    }

    class ForEachLoop {
        public void loopArr() {
            int[] fibArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            foreach (int item in fibArray)
            {
                Console.WriteLine(item);
            }

        }
    
    }
}
