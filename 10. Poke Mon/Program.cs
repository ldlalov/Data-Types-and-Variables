using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int count = 0;
            while (pokePower>=distance)
            {
                pokePower -= distance;
                count++;
                if (pokePower==pokePower/2.0 && pokePower>=exhaustionFactor)
                {
                    pokePower /= exhaustionFactor;
                }
            }
            Console.WriteLine($"{pokePower}\n{count}");
        }
    }
}
