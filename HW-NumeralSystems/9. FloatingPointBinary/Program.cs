// * Write a program that shows the internal binary representation of given 32-bit signed floating-point number
// in IEEE 754 format (the C# type float).
// Example: -27,25 -> sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConversionsTask;

namespace _9.FloatingPointBinary
{
    class Program
    {
        public static int GetSign(float input)
        {
            if (input < 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static string ConvertIntegerToBinary(float input)
        {
            return Conversions.NumberToString((int)input,2);
        }

        public static string ConvertFractionToBinary(float input)
        {
            string output = "";
            string digit = "";
            float remaining = (input - (int)input);
            do
            {
                digit = (remaining * 2).ToString().Substring(0,1);
                output = output + digit;
                remaining = remaining * 2;
                if (remaining > 1) remaining = remaining - 1;
            } while (remaining != 1);
            return output;
        }

        public static string ConvertToBinary(float input)
        {
            string integerPart = ConvertIntegerToBinary(input);
            string FractionPart = ConvertFractionToBinary(input);
            return integerPart + "." + FractionPart;
        }

        public static string GetExponent(string binaryString)
        {
            int pointPosition;
            if (binaryString.Substring(0, 2) == "0.")
            {
                pointPosition = - binaryString.IndexOf('1') + 1;
            }
            else 
            {
                pointPosition = binaryString.IndexOf('.')-1;
            }
            string exponent = Conversions.NumberToString(pointPosition + 127,2).PadLeft(8,'0');
            return exponent;
        }

        public static string GetMantissa(string binaryString)
        {
            string output ="";
            int pointPosition;
            if (binaryString.Substring(0, 2) == "0.")
            {
                pointPosition = binaryString.IndexOf('1') + 1;
            }
            else
            {
                pointPosition = binaryString.IndexOf('.') + 1;
            }
            output = binaryString.Substring(pointPosition).PadRight(23,'0');
            return output;
        }

        static void Main()
        {
            // Never got time to properly test this
            // Used this procedure http://sandbox.mc.edu/~bennet/cs110/flt/dtof.html
            //it works at least for this number I think
            float input = -0.1015625f;
            Console.WriteLine("{0} in binary float is:");
            Console.WriteLine("sign: {0}",GetSign(input));
            string binaryString = ConvertToBinary(Math.Abs(input));
            Console.WriteLine("exponent: {0}",GetExponent(binaryString));
            Console.WriteLine("mantissa: {0}", GetMantissa(binaryString));

        }
    }
}
