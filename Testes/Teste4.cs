using System;
using System.Collections;


namespace program // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static float celciusToFarenheit(float tempC)
        {
            return (1.8F * tempC) + 32;
        }
        static void Main(string[] args)
        {
            float tempC = 50F;
            Console.WriteLine(celciusToFarenheit(tempC));
        }


    }
}