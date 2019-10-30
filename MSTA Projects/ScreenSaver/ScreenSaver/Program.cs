using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ScreenSaver
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 1;
            int xIncrement = 1;
            int yIncrement = 1;

            while (true)
            {
                Console.Clear();
                x += xIncrement;
                y += yIncrement;

                if (x == 22)
                {
                    xIncrement = -1;
                }
                else if (x == 1)
                {
                    xIncrement = 1;
                }
                if (y == 60)
                {
                    yIncrement = -1;
                }
                else if (y == 1)
                {
                    yIncrement = 1;
                }

                Console.CursorTop = x;
                Console.CursorLeft = y;
                Console.WriteLine("Screen Saver Fun!");
                Thread.Sleep(100);
            }
        }
    }
}
