using System;
using System.Linq;

namespace Task6._2
{

    class Program
    {
        public static void DeleteEvenNumbers(ref int[] arr)
        {
            int newSize = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2 != 0) newSize++;
            }
            Array.Sort(arr, (a, b) =>
            {
                if (Math.Abs(a) % 2 == 0 && Math.Abs(b) % 2 == 1) return 1;
                if (Math.Abs(a) % 2 == 1 && Math.Abs(b) % 2 == 0) return -1;
                else return 0;


            });
            Array.Resize(ref arr, newSize);


        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (int.TryParse(s, out int n))
            {
                Random rand = new Random();
                int[] numbers = new int[n];
                for (int i = 0; i < n; i++)
                {
                    numbers[i] = rand.Next(-10, 10);

                }
                Array.ForEach(numbers, i => Console.Write(i + " "));
                Console.WriteLine();
                DeleteEvenNumbers(ref numbers);
                Array.ForEach(numbers, i => Console.Write(i + " "));

            }
        }
    }
}