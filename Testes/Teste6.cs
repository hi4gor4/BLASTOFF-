using System;
using System.Collections;


namespace program // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static string matchDuration(string a, string b)
        {
            TimeSpan start = TimeSpan.Parse(a);
            TimeSpan end = TimeSpan.Parse(b);
            return end.Subtract(start).ToString();
        }
        static void Main(string[] args)
        {
            string a = "8:12:14";
            string b = "9:18:14";
            Console.WriteLine(matchDuration(a, b));
        }
    }

}