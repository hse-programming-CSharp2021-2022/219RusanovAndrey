using System;

namespace Task01_3
{
    class Program
    {
        public static bool F(double x, double y)
        {
            return ((x >= y) && (x >= 0) && (x * x + y * y == 2));
        }
        static void Main(string[] args)
        {
            string strX = Console.ReadLine();
            string strY = Console.ReadLine();
            if ((double.TryParse(strY, out double x)) && (double.TryParse(strY, out double y)))
            {
                Console.WriteLine(F(x, y));

            }
            else
            {
                Console.WriteLine("Неверный формат ввода!");

            }






        }
    }
}
