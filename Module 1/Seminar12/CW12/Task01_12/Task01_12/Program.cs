using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Task01_12
{
    class Program
    {
        public static bool Palindrome(int n)
        {
            string s = n.ToString();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static int SumDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }

            return sum;
        }

        public static int MaxDigits(int n)
        {
            int max = 0;
            while (n > 0)
            {
                if (n % 10 > max)
                {
                    max = n % 10;
                }

                n /= 10;
            }

            return max;
        }

        public static void Print(int[] arr)
        {
            foreach (var n in arr)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int len))
            {
                int[] numbers = new int[len];
                Random rand = new Random();
                for (int i = 0; i < len; i++)
                {
                    numbers[i] = rand.Next(10, 100);
                }

                var s1 = (from n in numbers where n % 3 == 0 & n >= 10 & n < 100 select n).ToArray();
                var s2 = (from n in numbers where Palindrome(n) select n).ToArray();
                var s3 = (from n in numbers orderby SumDigits(n) select n).ToArray();
                var s4 = (from n in numbers where n >= 1000 & n < 10000 select n).ToArray().Sum();
                var s5 = (from n in numbers where n >= 10 & n < 100 select n).ToArray().Min();
                var s6 = (from n in numbers select MaxDigits(n)).ToArray();
                Print(numbers);
                Print(s1);
                Print(s2);
                Print(s3);
                Console.WriteLine(s4);
                Console.WriteLine(s5);
                Print(s6);
                
            }
        }
    }
}