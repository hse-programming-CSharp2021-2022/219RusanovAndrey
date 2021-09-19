using System;

namespace Task02_2
{
    class Program
    {
        public static string MaxNum(int n)
        {
            int max = 0;
            int mid = 0;
            int min = 0;
            int d = 0;
            int t = 0;
            string res = "";
            max = n % 10;
            n /= 10;
            mid = n % 10;
            n /= 10;
            if (mid > max)
            {
                d = max;
                max = mid;
                mid = d;


            }
            min = n % 10;
            if (min > max)
            {
                d = max;
                t = mid;
                max = min;
                mid = d;
                min = t;


            }
            else if (min > mid)
            {
                d = mid;
                mid = min;
                min = d;
            }

            res += max;
            res += mid;
            res += min;
            return (res);



        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите натуральное трехзначное число: ");
                string s = Console.ReadLine();
                if ((int.TryParse(s, out int n)) && (n >= 100) && (n <= 999))
                {
                    Console.WriteLine(MaxNum(n));
                    Console.WriteLine("Для выхода из программы нажмите ESCAPE. Для продолжения нажмите любую другую кнопку.");
                }
                else
                {
                    Console.WriteLine("Неверный формат ввода!");
                    Console.WriteLine("Для выхода из программы нажмите ESCAPE. Для продолжения нажмите любую другую кнопку");
                }
                if (Console.ReadKey().Key == ConsoleKey.Escape) return;


            }


        }
    }

}