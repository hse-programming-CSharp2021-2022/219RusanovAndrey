using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение длины первого катета: ");
            string a = Console.ReadLine();
            Console.Write("Введите значение длины второго катета: ");
            string b = Console.ReadLine();
            if ((double.TryParse(a, out double x)) && (double.TryParse(b, out double y)))
                Console.WriteLine("Длина гипотенузы равна " + (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))));
            else
                Console.WriteLine("Неверный формат ввода!");

        }
    }
}
