using System;

namespace Task6._1
{
    class Program
    {
        public static void Compress(ref int[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (Math.Abs(arr[i] + arr[i + 1]) % 3 == 0)
                {
                    arr[i] = arr[i] * arr[i + 1];
                    for (int j = i + 1; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];

                    }
                    Array.Resize(ref arr, arr.Length - 1);
                }
            }
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
                Compress(ref numbers);
                Array.ForEach(numbers, i => Console.Write(i + " "));
                Console.WriteLine();
            }
        }
    }
}