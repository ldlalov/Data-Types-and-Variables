using System;

namespace _02._From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                int space = input.IndexOf(' '); 
                long firstNum = long.Parse(input.Substring(0, space));
                long secondNum = long.Parse(input.Substring(space+1, input.Length-space-1));
                int sumDigits = 0;
                string biggestNum = "";
                if (firstNum>secondNum)
                {
                    biggestNum = firstNum.ToString();
                }
                else
                {
                    biggestNum = secondNum.ToString();
                }
                for (int j = 0; j < biggestNum.Length; j++)
                {
                    if (biggestNum[j] != 45)
                    {
                        sumDigits += int.Parse(biggestNum[j].ToString());
                    }
                }
                Console.WriteLine(sumDigits);
            }
        }
    }
}
