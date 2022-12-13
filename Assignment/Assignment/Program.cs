using System;

namespace Assignment
{
    class Program
    {
     

        public static void Main(string[] args)
        {
            //PassByValue passByValue = new PassByValue();
            //passByValue.sum(10, 20);


            // int a = 10, b = 20;
            // the out data members doesn't need to assign initial value as they are processed and brought back
            // int c, d;
            //PassByOut passByOut = new PassByOut();
            //Console.WriteLine("sum of a and b  is : " + passByOut.sum(a, b, out c, out d));
            //Console.WriteLine("Value of a is : " + a);
            //Console.WriteLine("Value of b is : " + b);
            //Console.WriteLine("Value of c is : " + c);
            //Console.WriteLine("Value of d is : " + d);
            //Console.ReadLine();

            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //int a = 10, b = 20, c = 30, d = 40;
            //PassByParams obj = new PassByParams();
            //obj.print(a, b, c, d);
            //obj.print(numbers);
            //Console.ReadLine();

            AcessSpecifier test = new AcessSpecifier();
            test.PublicSpecifier();
            /* test.PrivateSpecifier();*/// PrivateSpecifier method is private.  'member' is inaccessible due to its protection level
            /* test.ProtectedSpecifier();*/ // ProtectedSpecifier is protected, 'member' is inaccessible due to its protection level
            test.InternalSpecifier();
            test.ProtectedInternalSpecifier();

            //DryPrinciple dryPrinciple = new DryPrinciple();
            //Console.WriteLine(dryPrinciple.weekday1(3));
            //Console.WriteLine(dryPrinciple.weekday2(5));


        }
    }
}
