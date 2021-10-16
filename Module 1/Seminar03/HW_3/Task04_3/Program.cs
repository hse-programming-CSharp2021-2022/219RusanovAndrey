using System;

namespace Task04_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            int min = 9999;
            if ((int.TryParse(s1, out int n1)) && (int.TryParse(s2, out int n2)) && (int.TryParse(s3, out int n3)) && (s1.Length == 3) && (s2.Length == 3) && (s3.Length == 3))
            {   
               
                int[] numbers = { n1, n2, n3 };
                foreach (int n in numbers)
                {
                    if ((n % 100) < min%100)
                        min = n;


                }
                Console.WriteLine(min);
               
            }
            else
            {
                Console.WriteLine("Неверный формат ввода!");
            }

        }
    }
}
