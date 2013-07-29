// Write a method that reverses the digits of given decimal number. Example: 256  652

using System;

class Reverser
{
    private static int ReverseInteger(int number)
    {
        string strNumber = number.ToString();
        string strReversedNumber = "";
        for (int i = strNumber.Length-1; i >=0 ; i--)
        {
            strReversedNumber = strReversedNumber + strNumber[i];
        }
        return int.Parse(strReversedNumber);
    }
    static void Main()
    {
        int number = 1234;
        int reversedNumber = ReverseInteger(number);
        Console.WriteLine("Number {0} when reversed is {1}",number,reversedNumber);
    }
}
