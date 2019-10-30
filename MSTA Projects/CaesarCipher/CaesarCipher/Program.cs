using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWithCaesar
{
    class Program
    {
        static void Main(string[] args)
        {
            CaesarCipher cc = new CaesarCipher();
            Console.WriteLine("Type a string to encrypt:");
            string UserString = Console.ReadLine();

            Console.WriteLine("\n");

            Console.Write("Enter your Key");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Encrypted Data");

            string cipherText =  cc.Encipher(UserString, key);
            Console.WriteLine(cipherText);
            Console.Write("\n");

            Console.WriteLine("Decrypted Data:");

            string t = cc.Decipher(cipherText, key);
            Console.WriteLine(t);
            Console.Write("\n");

            Console.ReadKey();

        }
    }
}
