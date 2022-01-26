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
            int pokePowerTemp = pokePower;
            while (pokePowerTemp>=distance)
            {
                pokePowerTemp -= distance;
                count++;
                if (pokePowerTemp==pokePower/2.0 && exhaustionFactor != 0)
                {
                    pokePowerTemp /= exhaustionFactor;
                }
            }
            Console.WriteLine($"{pokePowerTemp}\n{count}");        }
    }
}
