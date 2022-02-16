using System;
using System.Collections;


namespace program // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static int whoIsTheSmallest(int[] input)
        {
            int smaller = input[0];
            foreach (var item in input)
            {
                if (item < smaller)
                {
                    smaller = item;
                }
            }
            return smaller;
        }
        static void Main(string[] args)
        {
            int a = 20;
            int b = 2;
            int c = 1;
            Console.WriteLine(whoIsTheSmallest(new int[] { b, a, c }));
        }


    }
}