using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class AcessSpecifier
    {
        public void Test()
        {
            int a = 3;
            float b = a;
            Console.WriteLine($"the value of b is{b}");
        }

        public void PublicSpecifier()
        {
            Console.WriteLine("Public Access specifier");
        }
        private void PrivateSpecifier()
        {
            Console.WriteLine("Private Access specifier");
        }
        protected void ProtectedSpecifier()
        {
            Console.WriteLine("Protected Access specifier");
        }
        internal void InternalSpecifier()
        {
            Console.WriteLine("Internal Access specifier");
        }

        protected internal void ProtectedInternalSpecifier()
        {
            Console.WriteLine("ProtectedInternal Access specifier");
        }
    }
}
