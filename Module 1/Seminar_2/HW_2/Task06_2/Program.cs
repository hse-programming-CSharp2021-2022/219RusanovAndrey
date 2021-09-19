using System;
using System.Globalization;

namespace Task06
{
    class Program
    {
        public static double GamingBudget(double budget, int persent)
        {
            return (budget * persent / 100);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите значение суммы бюджета: ");
                string strB = Console.ReadLine();
                Console.Write("Введите значение процента бюджета, выделенного на компьютерные игры: ");
                string strP = Console.ReadLine();
                if (double.TryParse(strB, out double b) && (int.TryParse(strP, out int p)))
                {
                    Console.WriteLine("Cумма, выделенная на компьютерные игры: " + GamingBudget(b,p).ToString("C3",CultureInfo.GetCultureInfo("en-US")));
                    Console.WriteLine("Для выхода из программы нажмите ESCAPE. Для продолжения нажмите любую другую кнопку.");

                }
                else
                {
                    Console.WriteLine("Неверный формат ввода!");
                    Console.WriteLine("Для выхода из программы нажмите ESCAPE. Для продолжения нажмите любую другую кнопку.");
                }
                if (Console.ReadKey().Key == ConsoleKey.Escape) return;


            }
            
            
        }
    }
}
