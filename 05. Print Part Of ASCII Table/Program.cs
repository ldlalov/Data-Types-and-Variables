using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int starSymbol = int.Parse(Console.ReadLine());
            int endSymbol = int.Parse(Console.ReadLine());
            for (int i = starSymbol; i <= endSymbol; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
