using System;

namespace _05._Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            string message = "";
            for (int i = 1; i <= lines; i++)
            {
                int input = char.Parse(Console.ReadLine());
                char decrypted = (char)(input + key);
                message += decrypted;
            }
            Console.WriteLine(message); 
        }
    }
}
