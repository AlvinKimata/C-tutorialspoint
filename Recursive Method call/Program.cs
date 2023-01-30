//Recursion.
using System;

namespace CalculatorApplication
{
    class Numbermanipulation
    {
        public int factorial (int num)
        {
            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }

        static void Main(string[] args)
        {
            Numbermanipulation n = new Numbermanipulation();

            //Call the factorial method.
            Console.WriteLine("Factorial of 7 is: {0}", n.factorial(7));
            Console.WriteLine("Factorial of 8 is: {0}", n.factorial(8));
            Console.ReadLine();
        }
    }
}