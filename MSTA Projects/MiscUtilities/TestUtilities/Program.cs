using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace TestUtilities
{
    class Program
    {
        static void Main(string[] args)
        {
            MiscUtilities util = new MiscUtilities();
            Console.WriteLine(util.KiloToPounds(1.0));
            Console.WriteLine(util.PoundsToKilo(2.2));
            Console.WriteLine(util.TemperatureFtoC(32.0));
            Console.WriteLine(util.TemperatureCtoF(100.0));
            Console.WriteLine(util.CalculateBMI(75, 2, true));
            Console.WriteLine(util.CalculateBMI(150, 68, false));

            Console.Read();

        }
    }
}
