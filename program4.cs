using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_08_2022HandsOn
{
    internal class program4
    {
        public static void Main(string[] args)
        {
            string newStr = "Welcome, to Mphasis, C#";
            string[] sep = { "a", "," };
            //char[] sep = { ' ' };
            int cnt = 2;
            string[] result = newStr.Split(sep, cnt, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


        }
    }
}
