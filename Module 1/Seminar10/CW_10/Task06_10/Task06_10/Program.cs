using System;
using System.Text;

namespace Sem
{
    class Program
    {
        private static Random rnd = new();

        static char[] Series(int k, int ration)
        {
            char[] arr = new char[k];
            int letterCount = (int) (k * ration / 100.0);
            for (int i = 0; i < letterCount; i++)
                arr[i] = (char) rnd.Next('a', 'z' + 1);
            for (int i = letterCount; i < k; i++)
                arr[i] = (char) rnd.Next('0', '9' + 1);
            return arr;
        }

        static string Line(char[] series)
        {
            string[] letters = {"ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять"};
            StringBuilder sb = new();
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= '0' && series[i] <= '9')
                {
                    int index = series[i] - '0';
                    sb.Append(letters[index] + " ");
                }
                else
                {
                    sb.Append(series[i] + " ");
                }
            }

            return sb.ToString();
        }

        public static void Main(string[] args)
        {
            int n = 10;
            int per = 30;
            char[] arr = Series(n, per);
            foreach (var x in arr)
                Console.Write(x + " ");
            Console.WriteLine();
            string result = Line(arr);
            Console.WriteLine(result);
        }
    }
}