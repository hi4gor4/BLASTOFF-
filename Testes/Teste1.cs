using System;
using System.Collections;


namespace program // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static float average(int i, int j, int k, int x, int y)
        {
            return (float)(i + j + k + x + y) / 5;
        }
        static void Main(string[] args)
        {
            int i = 2;
            int j = 2;
            int k = 2;
            int x = 2;
            int y = 10;
            Console.WriteLine(average(i, j, k, x, y));
        }

    }
}