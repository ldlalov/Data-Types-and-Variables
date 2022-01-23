using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            BigInteger bestSnowball = 0;
            double snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            for (int i = 1; i <= snowballs; i++)
            {
                int snowballSnowTemp = int.Parse(Console.ReadLine());
                int snowballTimeTemp = int.Parse(Console.ReadLine());
                int snowballQualityTemp = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow(snowballSnowTemp / snowballTimeTemp, snowballQualityTemp);
                if (snowballValue >= bestSnowball)
                {
                    bestSnowball = snowballValue;
                    snowballSnow = snowballSnowTemp;
                    snowballTime = snowballTimeTemp;
                    snowballQuality = snowballQualityTemp;

                }
            }
            Console.WriteLine($"{ snowballSnow} : { snowballTime} = { bestSnowball} ({ snowballQuality})");
        }
    }
}
