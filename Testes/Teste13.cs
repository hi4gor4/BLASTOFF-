using System;
using System.Collections;


namespace program // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void printMatrix(int[,] input)
        {
            int rowLength = input.GetLength(0);
            int colLength = input.GetLength(1);
            for (int i = 0; i < rowLength; i++)
            {
                for (int z = 0; z < colLength; z++)
                {
                    Console.Write(string.Format("{0} ", input[i, z]));
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 4] { { 1, 2, 3, 4 }, { 1, 1, 1, 1 }, { 2, 2, 2, 2 }, { 3, 3, 3, 3 }, { 4, 4, 4, 4 } };
            printMatrix(arr);
        }

    }
}
