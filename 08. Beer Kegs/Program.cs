using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegs = int.Parse(Console.ReadLine());
            string model="";
            double volume = 0;
            for (int i = 0; i < kegs; i++)
            {
                string currModel = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double currVolume = Math.PI * radius * radius *height;
                if (currVolume>=volume)
                {
                    volume = currVolume;
                    model = currModel;
                }
            }
            Console.WriteLine(model);
        }
    }
}
