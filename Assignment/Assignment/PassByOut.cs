using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class PassByOut
    {
        public int sum(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = c + 100;
            return (a + b);
        }
    }
}
