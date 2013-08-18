//Write a program to convert decimal numbers to their binary representation.
//Write a program to convert binary numbers to their decimal representation.
//Write a program to convert decimal numbers to their hexadecimal representation.
//Write a program to convert hexadecimal numbers to their decimal representation.

// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionsTask
{

    public class Conversions
    {
        public static int StringToNumber(string sNumber, int numericalBase)
        {
            int number = 0;
            for (int i = sNumber.Length - 1; i >= 0; i--)
            {
                int digit = 0;
                switch (sNumber[i])
                {
                    case '0':
                        digit = 0;
                        break;
                    case '1':
                        digit = 1;
                        break;
                    case '2':
                        digit = 2;
                        break;
                    case '3':
                        digit = 3;
                        break;
                    case '4':
                        digit = 4;
                        break;
                    case '5':
                        digit = 5;
                        break;
                    case '6':
                        digit = 6;
                        break;
                    case '7':
                        digit = 7;
                        break;
                    case '8':
                        digit = 8;
                        break;
                    case '9':
                        digit = 9;
                        break;
                    case 'A':
                        digit = 10;
                        break;
                    case 'B':
                        digit = 11;
                        break;
                    case 'C':
                        digit = 12;
                        break;
                    case 'D':
                        digit = 13;
                        break;
                    case 'E':
                        digit = 14;
                        break;
                    case 'F':
                        digit = 15;
                        break;
                }
                number = number + (int)(digit * Math.Pow(numericalBase, sNumber.Length - i - 1));
            }

            return number;
        }


        public static string NumberToString(int number, int numericalBase)
        {
            int remaining = number;
            string output = "";
            char digit = ' ';
            if (remaining >= numericalBase)
                {
                    do
                    {
                        int reminder = remaining % numericalBase;
                        switch (reminder)
                        {
                            case 0:
                                digit = '0';
                                break;
                            case 1:
                                digit = '1';
                                break;
                            case 2:
                                digit = '2';
                                break;
                            case 3:
                                digit = '3';
                                break;
                            case 4:
                                digit = '4';
                                break;
                            case 5:
                                digit = '5';
                                break;
                            case 6:
                                digit = '6';
                                break;
                            case 7:
                                digit = '7';
                                break;
                            case 8:
                                digit = '8';
                                break;
                            case 9:
                                digit = '9';
                                break;
                            case 10:
                                digit = 'A';
                                break;
                            case 11:
                                digit = 'B';
                                break;
                            case 12:
                                digit = 'C';
                                break;
                            case 13:
                                digit = 'D';
                                break;
                            case 14:
                                digit = 'E';
                                break;
                            case 15:
                                digit = 'F';
                                break;
                        }
                        output = digit + output;
                        remaining = remaining / numericalBase;
                    } while (remaining > numericalBase);
                    
                }

            switch (remaining)
            {
                case 0:
                    digit = '0';
                    break;
                case 1:
                    digit = '1';
                    break;
                case 2:
                    digit = '2';
                    break;
                case 3:
                    digit = '3';
                    break;
                case 4:
                    digit = '4';
                    break;
                case 5:
                    digit = '5';
                    break;
                case 6:
                    digit = '6';
                    break;
                case 7:
                    digit = '7';
                    break;
                case 8:
                    digit = '8';
                    break;
                case 9:
                    digit = '9';
                    break;
                case 10:
                    digit = 'A';
                    break;
                case 11:
                    digit = 'B';
                    break;
                case 12:
                    digit = 'C';
                    break;
                case 13:
                    digit = 'D';
                    break;
                case 14:
                    digit = 'E';
                    break;
                case 15:
                    digit = 'F';
                    break;
            }
            output = digit + output;

            return output;
        }

        public static string DecimalToBinary(string decimalNumber)
        {
            int number = StringToNumber(decimalNumber,10);
            string binaryNumber = NumberToString(number,2);
            return binaryNumber;
        }

        public static string DecimalToHex(string decimalNumber)
        {
            int number = StringToNumber(decimalNumber, 10);
            string hexNumber = NumberToString(number, 16);
            return hexNumber;
        }

        public static string BinaryToDecimal(string binaryNumber)
        {
            int number = StringToNumber(binaryNumber, 2);
            string decNumber = NumberToString(number, 10);
            return decNumber;
        }

        public static string HexToDecimal(string hexNumber)
        {
            int number = StringToNumber(hexNumber, 16);
            string decimalNumber = NumberToString(number, 10);
            return decimalNumber;
        }

        static void Main()
        {
            string input;
            string output = "";

            input = "15";
            Console.Write("Decimal: {0}",input);
            output = DecimalToBinary(input);
            Console.WriteLine(" is binary: {0}",output);

            input = "1010";
            Console.Write("Binary: {0}", input);
            output = BinaryToDecimal(input);
            Console.WriteLine(" is decimal: {0}", output);

            input = "15";
            Console.Write("Decimal: {0}", input);
            output = DecimalToHex(input);
            Console.WriteLine(" is hex: {0}", output);

            input = "17";
            Console.Write("Hex: {0}", input);
            output = HexToDecimal(input);
            Console.WriteLine(" is decimal: {0}", output);



        }
    }
}
