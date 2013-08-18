// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConversionsTask;

namespace _8.SignedShortBinary
{
    class MainApp
    {
        public static string Reverse(string input)
        {
            string output = "";
            input = input.PadLeft(15, '0');
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '1')
                {
                    output = output + "0";
                }
                else
                {
                    output = output + "1";
                }
            }
            return output;
        }
        public static string ShortToBinary(short input)
        {
            string binaryNumber = "";
            string aboluteInBinary = "";
            if (input < 0)
            {
                binaryNumber = "1" + Reverse(Conversions.NumberToString(Math.Abs(input + 1), 2));
            }
            else
            {
                aboluteInBinary = Conversions.NumberToString(Math.Abs(input), 2);
                binaryNumber = aboluteInBinary.PadLeft(16,'0');
            }
            return binaryNumber;
        }

        static void Main()
        {
            short input = -32768;
            Console.WriteLine("{0} in binary is {1}",input,ShortToBinary(input));
        }
    }
}
