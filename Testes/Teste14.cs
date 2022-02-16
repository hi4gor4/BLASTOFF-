using System;
using System.Collections;


namespace program // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static bool palindrome(string palavra)
        {
            string first = palavra.Substring(0, palavra.Length / 2);
            char[] rever = palavra.ToCharArray();

            Array.Reverse(rever);

            string temp = new string(rever);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(palindrome("osso"));
            Console.WriteLine(palindrome("Urso"));
        }

    }
}
