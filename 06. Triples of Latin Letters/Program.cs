using System;

namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tripesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < tripesCount; i++)
            {
                for (int j = 0; j < tripesCount; j++)
                {
                    for (int k = 0; k < tripesCount; k++)
                    {
                        Console.Write($"{(char)(97+i)}{(char)(97+j)}{(char)(97+k)}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
