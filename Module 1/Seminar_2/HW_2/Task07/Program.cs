using System;

namespace Task07
{
    class Program
    {
        public static void FloorFractional(double n, out double fl, out double fr)
        {
            fl = (int)n;
            fr = n % 1;
        }
        public static void PowSqrt(double n, out double p, out double s)
        {
            p = Math.Pow(n, 2);
            if (n > 0)
            {
                s = Math.Sqrt(n);
            }
            else
                s = -1;
           
        }
    
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите дробное число: ");
                string str = Console.ReadLine();
                while ((!(double.TryParse(str, out double N))) || (N % 1 == 0))
                {
                    Console.WriteLine("Неверный формат ввода!");
                    Console.Write("Введите дробное число: ");
                    str = Console.ReadLine();
                }
                double n = Convert.ToDouble(str);
                double floor, fractional, square, sqrt;
                FloorFractional(n, out floor, out fractional);
                PowSqrt(n, out square, out sqrt);
                Console.WriteLine("Целая часть числа: " + floor);
                Console.WriteLine("Дробная часть числа: " + fractional);
                Console.WriteLine("Квадрат числа: " + square);
                if (sqrt == -1)
                {
                    Console.WriteLine("Квадратный корень числа не является вещественным числом");
                }
                else
                    Console.WriteLine("Квадратный корень числа: " + sqrt);
                    Console.WriteLine("Для выхода из программы нажмите ESCAPE. Для продолжения нажмите любую другую кнопку.");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);


        }
    }
}
