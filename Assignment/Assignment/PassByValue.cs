using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class PassByValue
    {
        public int sum(int a, int b)
        {
            a = a + 10;
            b = b + 20;
            Console.WriteLine("Value of a is : " + a);
            Console.WriteLine("Value of b is : " + b);
            return (a + b);
        }
    }
}
