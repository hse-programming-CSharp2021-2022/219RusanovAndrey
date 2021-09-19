using System;

namespace Task02_3
{
    class Program
    {
        public static double F(double x, double y)
        {
            if ((x < y) && (x > 0))
            {
                return (x + Math.Sin(y));
            }
            else if ((x > y) && (x < 0))
            {
                return (y - Math.Sin(y));

            }
            else
                return (0.5 * x * y);
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
