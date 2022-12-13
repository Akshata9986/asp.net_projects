using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class PassByParams
    {
        public void print(params int[] numbers)
        {
            foreach (int x in numbers)
            {
                Console.WriteLine(" " + x);
            }
        }
    }
}
