// Write a method that checks if the element at given position in given array of 
// integers is bigger than its two neighbors (when such exist).

// Write a method that returns the index of the first element in array that is bigger than its neighbors,
// or -1, if there’s no such element.
// Use the method from the previous exercise.


using System;

class Program
{
    private static bool CheckElement(int[] array, int index)
    {
        bool biggest = true;
        if (index >= 1)
        {
            if (array[index - 1] > array[index])
            {
                biggest = false;
            }
        }

        if (index < array.Length-1)
        {
            if (array[index + 1] > array[index])
            {
                biggest = false;
            }
        }

        return biggest;
    }
    static void Main()
    {
        int[] array = new int[] {1,2,3,6,7,2,4,77,5};
        int index = 3;
        bool isBigerThanNeighbors = CheckElement(array, index);
        Console.WriteLine("The element on position {0} is {1} than its neighbors",index, isBigerThanNeighbors?"bigger":"not bigger");
        int firstIndex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (CheckElement(array, i))
            {
                firstIndex = i;
                break;
            }
        }
        if (firstIndex != -1)
        {
            Console.WriteLine("First bigger than its neghbors is {0}",firstIndex);
        }
        else
        {
            Console.WriteLine("There is no element bigger than its neghbors");
        }

    }
}
