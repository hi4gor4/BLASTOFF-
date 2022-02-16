using System;
using System.Collections;


namespace program // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static int factorial(int number)
        {
            int result = 1;
            for (int i = number; i > 1; i--)
            {
                result = result * i;

            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("5! = {0}", factorial(5));
        }

    }
}
