//Declaringm assigning and accessing arrays.
using System;

namespace Application
{
    class MyArray
    {
        static void Main(string[] args)
        {
            int[] n = new int[10]; //Array of 10 integers.
            int i, j;

            //Init elements of array n.
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            //Print elements of the array.
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element [{0}] = {1}", j, n[j]);
            }
            Console.ReadKey();
            Console.WriteLine("Using foreach loop. \n");

            foreach (int j in n)
            {
                int i = j - 100;
                Console.WriteLine("Element [{0}] = {1}", i, j);
            }
            Console.ReadKey();
        }
    }
}