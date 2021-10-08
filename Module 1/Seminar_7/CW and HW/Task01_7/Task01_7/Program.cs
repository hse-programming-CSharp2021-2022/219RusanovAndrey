using System;

namespace ConsoleApp10
{
    class Program 
    {
        public static void Print(char[] array)
        {
            foreach (char c in array)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            string s = Console.ReadLine();
            int K = Convert.ToInt32(s);
            char[] letters = new char[K];
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = (char)random.Next('A', 'Z' + 1);
            }
            Print(letters);
            char[] letters1 = new char[K];
            Array.Copy(letters, letters1, K);
            Array.Sort(letters1);
            Array.Reverse(letters1);
            Print(letters1);
        }
    }
}