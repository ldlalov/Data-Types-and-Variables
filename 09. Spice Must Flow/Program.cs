using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int spice = 0;
            int forWorkers = 26;
            int days = 0;
            while (yield>=100)
            {
                spice += yield - forWorkers;
                yield -= 10;
                days++;
            }
            if (spice >= 26)
            {
                spice -= forWorkers;
            }
                Console.WriteLine(days);
                Console.WriteLine(spice);
        }
    }
}
