using System;

namespace Task06_5
{
    class Program
    {
        public static double Factorial(double x)
        {

            if (x == 0)
            {
                return 1;
            }
            if (x > 0)
            {
                return (x * Factorial(x - 1));

            }
            else
            {
                return 0;
            }
            
        }
        
        public static double F1(double x)
        {
            double res = x*x;
            double d = 4;
            while (res < (res + (-Math.Pow(2, d - 1) * Math.Pow(x, d) / Factorial(d)) + (Math.Pow(2, d + 1) * Math.Pow(x, d+2) / Factorial(d))))
            {
                res += (-Math.Pow(2, d - 1) * Math.Pow(x, d) / Factorial(d)) + (Math.Pow(2, d + 1) * Math.Pow(x, d+2) / Factorial(d+2));
                d += 4;
            }
            return (res);
        }

        public static double F2(double x)
        {
            double res = 1;
            double n = 1;
            while (res < (res += Math.Pow(x, n) / Factorial(n)))
            {
                res += Math.Pow(x, n) / Factorial(n);
                n += 1;
            }

            return (res);
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (double.TryParse(s, out double x))
            {
                Console.WriteLine(F1(x));
                Console.WriteLine(F2(x));
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}