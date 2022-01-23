using System;

namespace _04._Refactoring_Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int range = 2; range <= input; range++)
            {
                string isPrime = "true";
                for (int devider = 2; devider < range; devider++)
                {
                    if (range % devider == 0)
                    {
                        isPrime = "false";
                    }
                }
                Console.WriteLine("{0} -> {1}", range, isPrime);
            }
        }
    }
}
