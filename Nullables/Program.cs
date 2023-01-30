//C# nullables.
using System;

namespace CalculatorApplication
{
    class NUllablesAtShow
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 45;

            double? num3 = new double?();
            double? num4 = 3.147;

            bool? boolval = new bool?();

            //Display values.
            Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("A nullable boolean value: {0}", boolval);
            Console.ReadLine();
        }
    }
}