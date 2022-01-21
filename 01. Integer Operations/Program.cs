using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int int1 = int.Parse(Console.ReadLine());
            int int2 = int.Parse(Console.ReadLine());
            int int3 = int.Parse(Console.ReadLine());
            int int4 = int.Parse(Console.ReadLine());
            int result = (int1 + int2) / int3 * int4;
            Console.WriteLine(result);
        }
    }
}
