
// Write a method that return the maximal element in a portion of array of integers starting at given index. 
// Using it write another method that sorts an array in ascending / descending order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sorting
{
    class Sorting
    {
        public static int[] FunnySort(int[] array, bool isAscending)
        {
            int temp;
            int[] result = new int[array.Length];
            Array.Copy(array,result,array.Length);
            int indexToSwap;
            for (int i = 0; i < array.Length; i++)
            {
                indexToSwap = maxElement(result, i);
                temp = result[i];
                result[i] = result[indexToSwap];
                result[indexToSwap] = temp;
            }
            if (isAscending) Array.Reverse(result);
            return result;
        }

        public static int maxElement(int[] array, int index)
        {
            int max = int.MinValue;
            int indexOfBiggest = 0;
            for (int i = index; i < array.Length; i++)
			{
                if (max < array[i])
                {
                    max = array[i];
                    indexOfBiggest = i;
                }
			}
            return indexOfBiggest;
        }

        static void Main()
        {
            int[] numbers = new int[] {4,5,9,1,2,6,55,12};
            int[] result = new int[numbers.Length];
            bool isAscending = true;
            result = FunnySort(numbers,isAscending);
        }
    }
}
