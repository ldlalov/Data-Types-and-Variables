using System;

namespace _06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int startBracket = 0;
            int endBracket = 0;
            string input = "";
            for (int i = 0; i < lines; i++)
            {
                input = Console.ReadLine();
                if (input.ToString() == "(")
                {
                    startBracket++;
                }
                else if (input.ToString() == ")")
                {
                    endBracket++;
                }
                if ((endBracket>startBracket)||(startBracket-endBracket>1))
                {
                    break;
                }
            }
            if (startBracket== endBracket)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
