//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//		x2 + 5 = 1x2 + 0x + 5 
//Extend the program to support also subtraction and multiplication of polynomials.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_12.Polynomials
{
    class Program
    {
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }

        static int[] Add(int[] a, int[] b)
        {
            if (a.Length > b.Length) return Add(b, a);
            int[] result = new int[b.Length];
            for (int i =0 ; i < a.Length; i++) result[i] = a[i] + b[i];
            for (int j = a.Length; j < b.Length; j++) result[j] = b[j];

            return result;
        }

        static int[] Subtract(int[] a, int[] b, bool reversed = false)
        {
            if (a.Length > b.Length) return Subtract(b, a, reversed: true); 
            int[] result = new int[b.Length];
            for (int i = 0; i < a.Length; i++) result[i] = (reversed ? b[i] - a[i] : a[i] - b[i]);
            for (int j = a.Length; j < b.Length; j++) result[j] = (reversed ? b[j] : -b[j]); 
            return result;
        }

        public static int[] Multiply(int[] a, int[] b)
        {

            int[] result = new int[a.Length + b.Length - 1];
            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < b.Length; j++)
                    result[i + j] += a[i] * b[j];

            return result;
        }

        static void Main(string[] args)
        {
            PrintArray(Add(new int[] { 2, 0, 3, 4 }, new int[] { 1, 2, 3, 4, 5, 6 }));
            PrintArray(Subtract(new int[] { 2, 0, 3, 4 }, new int[] { 1, 2, 3, 4, 5, 6 }));
            PrintArray(Subtract(new int[] { 1, 2 }, new int[] { 1 }));
            PrintArray(Multiply(new int[] { 2, 1 }, new int[] { 1, 1 }));

        }
    }
}
