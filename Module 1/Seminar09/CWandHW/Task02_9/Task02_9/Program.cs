using System;
using System.Text;

namespace Task02_9
{
    class Program
    {
        public static string ConvertHex2Bin(string HexNumber)
        {
            int n = 0;
            int d = 1;
            string digits = "0123456789ABCDEF";
            for (int i = HexNumber.Length - 1; i >= 0; i--)
            {
                n += digits.IndexOf(HexNumber[i]) * d;
                d *= 16;
            }

            string bin = "";
            while (n > 0)
            {
                bin = n % 2 + bin;
                n /= 2;
            }


            return bin;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(ConvertHex2Bin(s));
        }
    }
}