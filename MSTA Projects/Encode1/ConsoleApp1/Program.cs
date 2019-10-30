using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KEY");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your text to encode:");
            string UserEntry = Console.ReadLine();
            string Encode = Encoding(UserEntry, key);
            Console.WriteLine(Encode);
            Console.Read();
        }
        public static string Encoding(string userinput, int key)
        {
            char[] fixedLetter = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'q', 'x', 'y', 'z' };
            int letter = 0;
            string temp = string.Empty;
            //userinput = string.Empty;
            for (int i = 0; i <= userinput.Length - 1; i++)
            {
                char curChar = Convert.ToChar(userinput.Substring(i, 1));
                for (int j = 0; j <= fixedLetter.Length - 1; j++)
                {
                    if (curChar == fixedLetter[j])
                    {
                        letter = j;
                        int c = (letter + key) % 26;
                        temp += fixedLetter[c].ToString();
                    }
                }
            }
            return temp;
        }
    }
}
