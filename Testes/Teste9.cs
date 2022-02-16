using System;
using System.Collections;


namespace program // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static string[] mutiplicationTable(int number)
        {
            string[] table = new string[10];
            for (int i = 1; i <= 9; i++)
            {
                table[i] = String.Format("{0} x {1} = {2}", number, i, i * number);

            }

            return table;
        }
        static void Main(string[] args)
        {
            string[] table = mutiplicationTable(8);
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine(table[i]);
            }
        }

    }
}
