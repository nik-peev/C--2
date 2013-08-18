// You are given a sequence of positive integer values written into a string, separated by spaces.
// Write a function that reads these values from given string and calculates their sum. Example:
//		string = "43 68 9 23 318"  result = 461

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "43 68 9 23 318";
            int sum = 0;
            foreach (var strNumber in str.Split(' '))
            {
                int number = int.Parse(strNumber);
                sum = sum + number;
            }
            Console.WriteLine("The sum is {0}",sum);
        }
    }
}
