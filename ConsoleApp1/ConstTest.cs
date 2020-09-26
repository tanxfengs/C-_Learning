using System;
using System.Collections.Generic;
using System.Text;

namespace ConstTest
{
    class SampleClass
    {
        public int x;
        public int y;
        public const int c1 = 5;
        public const int c2 = c1 + 5;

        public SampleClass(int p1, int p2) {
            x = p1;
            y = p2;
        }

    }
}
