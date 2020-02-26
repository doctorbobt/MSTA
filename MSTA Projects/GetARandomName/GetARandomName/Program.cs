using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GetARandomName
{
    class Program
    {
        static string[] names = { "Ali", "Amy", "Ashley", "Deepika", "Esther", "Jackie", "Renae", "Reshu", "Sarah", "Sarah Mae", "Shandan", "Sheila", "Svitlana" };
        private static Random rng = new Random();
        static void Main(string[] args)
        {
            int minimum = 300;
            int maximum = 500;
            Random random = new Random();
            double r = random.NextDouble() * (maximum - minimum) + minimum;
            double timerMax = r;
            double timer = 0;
            string finalName = String.Empty;
            while (timer < timerMax)
            {
                Shuffle(names);
                for (int i = 0; i < names.Length; i++)
                {
                    timer += 10;
                    Console.Clear();
                    Console.CursorTop = 12;
                    Console.CursorLeft= 50; ;
                    double p = (timer / timerMax) * 100;
                    if (p < 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (p < 75)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    } else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    finalName = names[i];
                    Console.WriteLine($"{names[i]}");
                    Thread.Sleep((int)timer);
                }
            }
            Console.Clear();
            Console.CursorTop = 12;
            Console.CursorLeft = 50;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{finalName}");
            Console.WriteLine("");
            Console.CursorTop = 15;
            Console.CursorLeft = 50;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"WINNER! WINNER! CHICKEN DINNER!!!!!!");
            Console.ReadLine();
        }
        public static void Shuffle(string[] list)
        {
            int n = list.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
