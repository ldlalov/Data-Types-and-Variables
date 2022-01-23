using System;

namespace _01._Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string type;
            while (input != "END")
            {
                if (int.TryParse(input, out int outInt) == true)
                {
                    type = "integer";
                }
                else if (float.TryParse(input, out float outFloat) == true)
                {
                    type = "floating point";
                }
                else if (char.TryParse(input, out char outChar) == true)
                {
                    type = "character";
                }
                else if (bool.TryParse(input, out bool outBool) == true) 
                {
                    type = "boolean";
                }
                else
                {
                    type = "string";
                }
                Console.WriteLine($"{ input} is { type} type");
                input = Console.ReadLine();
            }
        }
    }
}
