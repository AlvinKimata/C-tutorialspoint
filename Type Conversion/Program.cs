//Explicit type conversion in C#
using System;

namespace TypeConversionApplication
{
    class ExplicitConversion
    {
        static void Main(string[] args)
        {
            double d = 5673.74;
            int i;

            //Cast double to integer.
            i = (int)d;
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}