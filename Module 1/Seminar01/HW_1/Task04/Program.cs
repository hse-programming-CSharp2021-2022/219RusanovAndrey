using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение напряжения U: ");
            string u = Console.ReadLine();
            Console.Write("Введите значение сопротивления R: ");
            string r = Console.ReadLine();
            if ((double.TryParse(u, out double U)) && (double.TryParse(r, out double R)))
            {
                Console.WriteLine("Сила тока: " + (U / R));
                Console.WriteLine("Потребляемая мощность: " + (Math.Pow(U,2) / R));
            }
            else
            {
                Console.WriteLine("Некорректный формат ввода!");
            }
        }
    }
}
