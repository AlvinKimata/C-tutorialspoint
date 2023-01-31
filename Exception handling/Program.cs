//Exception is built upon 4 keywords: try, catch, finally, throw.
//try: Identifies a block of code for which particular exceptions is activated.
//catch: Indicates the catching of an exception.
//finally: Used to execute a given set of statements, whether an exception is thrown or not.
//throw: Throw an exception when a problem shows up.

//Directy derived from the "System.Execption class"

using System;

namespace ErrorhandlingApplication
{
    class DivNumbers
    {
        int result;

        DivNumbers()
        {
            result = 0;
        }
        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }

            catch(DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }

        static void Main(string[] args)
        {
            DivNumbers d = new DivNumbers();
            d.division(25, 0);
            Console.ReadKey();
        }
    }
}