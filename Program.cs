using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_08_2022HandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st string");
            string str1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter 2nd string");
            string str2 = Convert.ToString(Console.ReadLine());

            if (str1.Length == str2.Length)
            {
                Console.WriteLine("String lengths are same");
            }
            else
            {
                Console.WriteLine("Strings are not equal");
            }
        }
    }
}


