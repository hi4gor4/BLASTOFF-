using System;
using System.Collections;


namespace program // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static int[] evenNumbers(int[] input)
        {
            List<int> even = new List<int>();
            foreach (int item in input)
            {
                if (item % 2 == 0)
                {
                    even.Add(item);
                }
            }

            return even.ToArray();
        }
        static void Main(string[] args)
        {
            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            int[] result = evenNumbers(a);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }
    }

}