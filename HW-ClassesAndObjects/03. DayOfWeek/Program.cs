// Write a program that prints to the console which day of the week is today. Use System.DateTime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Today = DateTime.Now;
            Console.WriteLine("Today is {0}.",Today.DayOfWeek);
        }
    }
}
