// Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Leap_year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input year: ");
            int year = int.Parse(Console.ReadLine());
            bool isLeap = DateTime.IsLeapYear(year);
            Console.WriteLine("The year is {0}leap", isLeap ? "": "not ");
        }
    }
}
