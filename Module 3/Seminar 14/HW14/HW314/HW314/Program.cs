using System;
using System.Linq;

namespace HW314
{
    class Program
    {
        public static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];


            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-1000, 1001);
            }

            PrintArray(array);

            var array1 = array.Select(x => x * x).ToArray();
            PrintArray(array1);

            var array2 = array.Where(x => x > 0 && x >= 10 && x <= 99).ToArray();
            PrintArray(array2);

            var array3 = array.Where(x => x % 2 == 0).OrderByDescending(x => x).ToArray();
            PrintArray(array3);

            var array4 = array.GroupBy(x => x.ToString().Length).ToArray();
            Array.ForEach(array4, x => { Array.ForEach(x.ToArray(), x => Console.Write(x + " ")); });
        }
    }
}