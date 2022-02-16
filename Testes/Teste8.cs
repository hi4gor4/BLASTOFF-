using System;
using System.Collections;


namespace program // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static bool isPrimeNumber(int number)
        {
            if (number >= 2)
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        static void Main(string[] args)
        {
            int a = 20;
            for (int i = 1; i < a; i++)
            {
                if (isPrimeNumber(i))
                {
                    Console.WriteLine("{0}  is not a Prime number ", i);
                }
                else
                {
                    Console.WriteLine("{0}  is  a Prime number ", i);
                }

            }
        }
    }
}
