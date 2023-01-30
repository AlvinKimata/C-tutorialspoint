using System;

namespace Application
{
    class MyArray
    {
        double getAverage(int[] arr, int size)
        {
            int i;
            double avg;
            int sum = 0;

            for (i = 0; i < size; ++i)
            {
                sum += arr[i];
            }
            avg = (double)sum / size;
            return avg;
        }
        static void Main(string[] args)
        {
            MyArray app = new MyArray();

            //init array with 5 elements.
            int[] balance = new int[] { 1000, 2, 4, 456, 7 };
            double avg;
            avg = app.getAverage(balance, 5);

            Console.WriteLine("Average value is: {0}:", avg);
            Console.ReadKey();
        }
    }
}