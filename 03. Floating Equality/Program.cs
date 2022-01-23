using System;

namespace _03._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal floatA = decimal.Parse(Console.ReadLine());
            decimal floatB = decimal.Parse(Console.ReadLine());
            decimal result = Math.Abs(floatA - floatB);
            int test = Decimal.Compare(result, 0.000001m);
            if (test<0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
