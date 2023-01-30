//While loop in C#
using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args) {
            //Local variable definintion.
            int a = 10;
            
            //While loop execution.
            while (a < 20)
            {
                Console.WriteLine("Value of a: {0}", a);
                a++;

                if (a > 15)
                {
                    //Terminate the loop using a break statement.
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}