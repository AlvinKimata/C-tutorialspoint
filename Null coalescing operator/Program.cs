//Null coalescing operator (??) is used for converting an operand to the type of
//anothe variable (or not) value type operand, where an implicit conversion is possible.

using System;

namespace CalculatorApplication
{
    class NullablesAtShow
    {
        static void Main(string[] args)
        {
            double? num1 = null;
            double? num2 = 3.142;
            double num3;

            num3 = num1 ?? 5.34;
            Console.WriteLine("Value of num3: {0}", num3);

            num3 = num2 ?? 5.34;
            Console.WriteLine("Value of num3: {0}", num3);
            Console.ReadLine();
        }
    }
}