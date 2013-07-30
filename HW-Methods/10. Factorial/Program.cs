// Write a program to calculate n! for each n in the range [1..100]. 
// Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sum;

namespace _10.Factorial
{
    class Program
    {
        public static int[] MultipyArrayByInteger(int[] array, int multiplier)
        {
            int[] result = { 0 };
            for (int i = 0; i < multiplier; i++)
            {
                result = SumOfBigIntegers.sumArrays(result,array);
            }
            return result;
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]); 
            }
            Console.WriteLine();
        }
        
        static void Main()
        {
            int[] factorial = { 1 };
            for (int i = 1; i <= 100; i++)
            {
                factorial = MultipyArrayByInteger(factorial, i);
                PrintArray(factorial);
            }
        }
    }
}
