// Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r1 = new Random();
            for (int i = 0; i < 10; i++)
            {
                int number = r1.Next();
                Console.WriteLine(number);
            }
        }
    }
}
