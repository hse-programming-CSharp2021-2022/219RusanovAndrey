using System;
using System.Text;
using System.Threading;

namespace Task09_3
{
    class Program
    {
        public static string F1(string input)
        {
            StringBuilder res = new StringBuilder();
            int spaceCount = 0;
            input = input.TrimStart();
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    if (spaceCount == 0)
                    {
                        res.Append(c);
                    }

                    spaceCount += 1;
                }
                else
                {
                    res.Append(c);
                    spaceCount = 0;
                }
            }

            return (res.ToString());
        }

        public static int F2(string input)
        {
            int countLetters = 0;
            int countWords = 0;
            foreach (char c in input)
            {
                if (c != ' ')
                {
                    countLetters += 1;
                }
                else
                {
                    if (countLetters > 4)
                    {
                        countWords += 1;
                    }

                    countLetters = 0;
                }
            }

            return countWords;
        }

        public static int F3(string input)
        {
            int count = 0;
            string vowels = "аиеёоуыэюяАИЕЁОУЫЭЮЯ";
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (((i == 0 ) && (vowels.Contains(input[i]))) || ((input[i] == ' ') && vowels.Contains(input[i + 1])))
                {
                    count += 1;
                }
            }

            return count;
        }


        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(F1(s));
            Console.WriteLine(F2(s));
            Console.WriteLine(F3(s));
        }
    }
}