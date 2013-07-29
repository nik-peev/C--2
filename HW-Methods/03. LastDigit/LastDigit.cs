// Write a method that returns the last digit of given integer as an English word.
// Examples: 512  "two", 1024  "four", 12309  "nine".
using System;

class Program
{
    private static string LastDigitToNumber(int number)
    {
        string digitWord = "";
        switch (number % 10)
        {
            case 1:
                {
                    digitWord = "one";
                    break;
                }
            case 2:
                {
                    digitWord = "two";
                    break;
                }
            case 3:
                {
                    digitWord = "three";
                    break;
                }
            case 4:
                {
                    digitWord = "four";
                    break;
                }
            case 5:
                {
                    digitWord = "five";
                    break;
                }
            case 6:
                {
                    digitWord = "six";
                    break;
                }
            case 7:
                {
                    digitWord = "seven";
                    break;
                }
            case 8:
                {
                    digitWord = "eight";
                    break;
                }
            case 9:
                {
                    digitWord = "nine";
                    break;
                }
            case 0:
                {
                    digitWord = "zero";
                    break;
                }
            default:
                break;
        }
        return digitWord;
    }

    static void Main()
    {
        int number = 2340;
        Console.WriteLine("The last digit of {0} is {1}.",number,LastDigitToNumber(number));
    }
}
