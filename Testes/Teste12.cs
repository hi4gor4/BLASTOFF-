using System;
using System.Collections;


namespace program // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static int[] myItersect(int[] inputA, int[] inputB)
        {
            List<int> contains = new List<int>();
            foreach (int itemA in inputA)
            {
                foreach (int itemB in inputB)
                {
                    if (itemA == itemB)
                    {
                        contains.Add(itemA);
                    }
                }
            }

            return contains.ToArray();
        }
        static void Main(string[] args)
        {
            int[] a = new int[4] { 1, 2, 3, 4 };
            int[] b = new int[4] { 1, 2, 5, 8 };
            int[] result = myItersect(a, b);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }

    }
}
