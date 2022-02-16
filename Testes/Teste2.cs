using System;
using System.Collections;


namespace program // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static float averageConsumption(float distance, float spentFuel)
        {
            return distance / spentFuel;

        }

        static void Main(string[] args)
        {
            float distance = 10F;
            float spentFuel = 8F;
            Console.WriteLine(averageConsumption(distance, spentFuel));
        }

    }
}