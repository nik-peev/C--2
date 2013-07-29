// Write a method GetMax() with two parameters that returns the bigger of two integers. 
// Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

class SecondTask
{
    private static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    static void Main()
    {

        int[] numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Input element[{0}]:",i+1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int biggest = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            biggest = GetMax(biggest, numbers[i]);
        }
        Console.WriteLine("Biggest number is {0}",biggest);
    }
}

