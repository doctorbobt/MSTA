using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = ValidateUsername("freddie", "yabbadabbadoo@gmail.com");
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static string ValidateUsername(string username, string email)
        {
            var table = TableUtility.AuthTable();

            var exists = TableUtility.DoesUsernameExist(username, table);

            if (exists)
            {
                return "Username Taken";
            }

            var success = TableUtility.CreateEntity(email, username, table);

            if (success)
            {
                return "Username Registered";
            }
            else
            {
                return "Error";
            }

        }
    }
}
