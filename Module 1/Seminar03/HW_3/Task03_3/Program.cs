using System;

namespace Task03_3
{
    class Program
    {
        public static double F(double x)
        {
            if (x <= 0.5)
            {
                return Math.Sin((Math.PI/2));
            }
            else
            {
                return Math.Sin((Math.PI*(x-1)) / 2);

            }
        }
        static void Main(string[] args)
        {
            string strX = Console.ReadLine();
           
            if (double.TryParse(strX, out double x))
            {
                Console.WriteLine(F(x));

            }
            else
            {
                Console.WriteLine("Неверный формат ввода!");
            }
        }
        
        
    }
}
