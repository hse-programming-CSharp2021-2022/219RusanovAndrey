using System;

namespace Task02_7
{
    
    class Program
    {
        public static void Print(int[] arr)
        {
            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }
        }
        public static void Shuffle(int[] arr)
        {
            Random random = new Random();
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                int t = arr[j];
                arr[j] = arr[i];
                arr[j] = arr[i];
                arr[i] = t;
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            int[] arr = new int[99];
            for (int i = 0; i < 100; i++)
            {
                numbers[i] = i + 1;
            }
            Shuffle(numbers);
            Array.Copy(numbers, arr, 99);
            int sumNumbers = 5050;
            for (int i = 0; i < 99; i++)
            {
                sumNumbers -= arr[i];
            }
            Console.WriteLine("Отсутствующий элемент: " + sumNumbers);
        }
    }
}