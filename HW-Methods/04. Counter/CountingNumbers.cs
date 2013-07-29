// Write a method that counts how many times given number appears in given array. 
// Write a test program to check if the method is working correctly.

using System;

class CountingNumbers
{
    private static int CountNumberinArray(int number,int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
          if (array[i] == number) count++;  
        }
        return count;
    }
    static void Main()
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 4, 4, 2, 1, 4, 4, 88 };
        int countFromMethod = CountNumberinArray(4, numbers);

    }
}
