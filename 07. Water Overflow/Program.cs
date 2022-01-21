using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pours = int.Parse(Console.ReadLine());
            int volume = 255;
            int currLitters = 0;
            for (int i = 0; i < pours; i++)
            {
                int litters = int.Parse(Console.ReadLine());
                if (currLitters + litters > volume)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                currLitters += litters;
            }
            Console.WriteLine(currLitters);
        }
    }
}
