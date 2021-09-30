using System;
using System.Threading.Channels;

namespace Task02_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (char.TryParse(s, out char ch))
            {
                if (Shift(ref ch))
                {
                    Console.WriteLine(ch);
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                    
                }
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }

        static bool Shift(ref char ch)
        {
            char[] alpahabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            for (int i = 0; i < 26; i++)
            {
                if (alpahabet[i] == ch)
                {
                    ch = alpahabet[(i + 4) % 26];
                    return true;

                }
            }
            return false;
        }
    }
}