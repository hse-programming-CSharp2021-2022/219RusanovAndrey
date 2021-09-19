using System;

namespace Task01_02
{
    class Program
    {
        public static double Mult(double x, double n)
        {
            double res = 0;
            for (int j = 1; j <= n; j++)
            {
                res += x;
            }
            return (res);
        }

        public static double Exp(double x, int n)
        {
            double res = 1;
            for (int i = 1; i <= n; i++)
            { 
                res = Mult(res, x);
            }
            return (res);
        }
        public static double Polynomial(double x)
        {
            double ans = Mult(Exp(x, 4), 12) + Mult(Exp(x, 3), 9) - Mult(Exp(x, 2), 3) + Mult(x, 2) - 4;
            return(ans);

        }
               
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Введите значение x: ");
                string s = Console.ReadLine();
                if (double.TryParse(s, out double x))
                {
                    Console.WriteLine("Значение полинома: " + Polynomial(x));
                    Console.WriteLine("Для выхода из программы нажмите ESCAPE. Для продолжения нажмите любую другую кнопку");

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
