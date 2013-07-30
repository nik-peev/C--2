// Write a method that adds two positive integer numbers represented as arrays of digits 
// (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
// Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    public class SumOfBigIntegers
    {
        public static int[] sumArrays(int[] n1, int[] n2)
        {
            int digit1, digit2, overflow = 0;
            int sumLength =  Math.Max(n1.Length, n2.Length);
            int[] sum = new int[sumLength];
            for (int i = 1; i <= sumLength; i++)
            {
                digit1 = 0;
                digit2 = 0;
                if (n1.Length - i >= 0)
                {
                    digit1 = n1[n1.Length - i];
                }
                if (n2.Length - i >= 0)
                {
                    digit2 = n2[n2.Length - i];
                }
                sum[sumLength - i] = (digit1 + digit2 + overflow) % 10;
                overflow = (digit1 + digit2 + overflow) / 10;
            }
            if (overflow == 1)
            {
                int[] tempsum = new int[sumLength + 1];
                sum.CopyTo(tempsum, 1);
                Array.Resize(ref sum, sumLength + 1);
                tempsum[0] = 1;
                tempsum.CopyTo(sum, 0);
            }
            return sum;
        }

        static void Main(string[] args)
        {
            // wel i did it wrong the last digit is in the last element, but its more readable this way
            int[] number1 = new int[] {1,1,1};
            int[] number2 =new int[] {9,3,4};
            int[] sum = new int[Math.Max(number1.Length, number2.Length)+1];
            sum = sumArrays(number1,number2);
            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write(sum[i]);
            }
        }
    }
}
