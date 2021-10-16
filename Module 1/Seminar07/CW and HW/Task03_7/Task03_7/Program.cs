using System;
using System.Collections.Generic;
using System.Xml;

namespace Task03_7
{
    class Program
    {
        public static void Print(int[] arr)
        {
            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
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
            int[] arr = new int[100];
            int[] count = new int[101];
            
            for (int i = 0; i < 100; i++)
            {
                numbers[i] = i + 1;
            }
            
            for (int i = 0; i < 100; i++)
            {
                numbers[i] = i + 1;
            }
            Shuffle(numbers);
            for (int i = 0; i < 99; i++)
            {
                arr[i] = numbers[i];
            }
            Shuffle(arr);
            Random random = new Random();
            int e = 0;
            do
            {
                e = random.Next(1, 101);

            } while (numbers[e] == arr[e]);
            arr[e] = numbers[e];
            Array.Sort(arr);
            Print(arr);
            for (int i = 0; i < 100; i++)
            {
                
                count[arr[i]] += 1;
                
            }
            for (int i = 0; i < 100; i++)
            {
                if (count[i] == 2)
                {
                    Console.WriteLine("Повторяющийся элемент: " + i);
                }

            }
        }
    }
}