using System;
using System.Collections;


namespace program // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static bool isAMultiple(int a, int b)
        {
            if (a % b == 0)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Console.WriteLine(isAMultiple(a, b));
        }


    }
}