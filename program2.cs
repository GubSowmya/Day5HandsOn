using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_08_2022HandsOn
{
    internal class program2
    {
        public static void Main(string[] args)
        {

        Console.WriteLine("Enter  string : ");
        string str1 = Convert.ToString(Console.ReadLine());

        string i = string.Copy(str1);

        Console.WriteLine(i);

            }
    }
}
