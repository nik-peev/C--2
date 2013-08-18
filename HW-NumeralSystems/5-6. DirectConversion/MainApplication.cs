//Write a program to convert hexadecimal numbers to binary numbers (directly).
//Write a program to convert binary numbers to hexadecimal numbers (directly).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_6.DirectConversion
{
    class MainApplication
    {
        public static string HexToBinary(string input)
        {
            string output = "";
            string segment = "";
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '0':
                      segment = "0000";
                      break;
                    case '1':
                      segment = "0001";
                      break;
                    case '2':
                      segment = "0010";
                      break;
                    case '3':
                      segment = "0011";
                      break;
                    case '4':
                      segment = "0100";
                      break;
                    case '5':
                      segment = "0101";
                      break;
                    case '6':
                      segment = "0110";
                      break;
                    case '7':
                      segment = "0111";
                      break;
                    case '8':
                      segment = "1000";
                      break;
                    case '9':
                      segment = "1001";
                      break;
                    case 'A':
                      segment = "1010";
                      break;
                    case 'B':
                      segment = "1011";
                      break;
                    case 'C':
                      segment = "1100";
                      break;
                    case 'D':
                      segment = "1101";
                      break;
                    case 'E':
                      segment = "1110";
                      break;
                    case 'F':
                      segment = "1111";
                      break;
                }
                output = segment + output;
            }
            return output;
        }

        public static string BinaryToHex(string input)
        {
            string output = "";
            string segment = "";
            string digit = "";
            int padding = 4 - input.Length % 4;
            if (padding == 4) padding = 0;
            input = input.PadLeft(input.Length + padding,'0');
            for (int i = 0; i < input.Length / 4 ; i++)
            {
                segment = input.Substring(i*4,4);
                switch (segment)
                {
                    case "0000":
                        digit = "0";
                        break;
                    case "0001":
                        digit = "1";
                        break;
                    case "0010":
                        digit = "2";
                        break;
                    case "0011":
                        digit = "3";
                        break;
                    case "0100":
                        digit = "4";
                        break;
                    case "0101":
                        digit = "5";
                        break;
                    case "0110":
                        digit = "6";
                        break;
                    case "0111":
                        digit = "7";
                        break;
                    case "1000":
                        digit = "8";
                        break;
                    case "1001":
                        digit = "9";
                        break;
                    case "1010":
                        digit = "A";
                        break;
                    case "1011":
                        digit = "B";
                        break;
                    case "1100":
                        digit = "C";
                        break;
                    case "1101":
                        digit = "D";
                        break;
                    case "1110":
                        digit = "E";
                        break;
                    case "1111":
                        digit = "F";
                        break;
                }
                output = output + digit;
            }    

            return output;
        }

        static void Main()
        {
            string input = "777";
            Console.WriteLine("This hex {0} is {1} in binary", input, HexToBinary(input).TrimStart('0'));

            input = "11110110";
            Console.WriteLine("This bin {0} is {1} in hex", input, BinaryToHex(input).TrimStart('0'));
        }
    }
}
