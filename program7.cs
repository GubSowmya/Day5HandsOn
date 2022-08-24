using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_08_2022HandsOn  //display the Day properties
                              //(year, month, day, hour, minute, second, millisecond etc.)
                              //of todays date
{
    internal class program7
    {
        public static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            Console.WriteLine("Year : " + dt.Year);
            Console.WriteLine("Year : " + dt.Month);
            Console.WriteLine("Year : " + dt.Day);
            Console.WriteLine("Year : " + dt.Hour);
            Console.WriteLine("Year : " + dt.Minute);
            Console.WriteLine("Year : " + dt.Second);
            Console.WriteLine("Year : " + dt.Millisecond);


        }
    }
}
