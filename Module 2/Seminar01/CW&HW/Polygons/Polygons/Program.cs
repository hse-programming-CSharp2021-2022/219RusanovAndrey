using System;
using System.Globalization;

namespace Polygons
{
    
    class Program
    {
        static void Main(string[] args)
        {
            double max = 0;
            double min = double.MaxValue;
            int n = 0;
            RegularPolygon[] polygons = Array.Empty<RegularPolygon>();
            int s = 1;
            double r = 1;
            while (s!=0 && r!=0)
            {
                n++;
                do Console.Write($"Введите число углов {n}-го правильного многоугольника: ");
                while (!(int.TryParse(Console.ReadLine(), out s) && (s > 2 || s == 0)));
                do Console.Write($"Введите значение длины радиуса вписанной окружности {n}-го правильного многоугольника: ");
                while (!(double.TryParse(Console.ReadLine(), out r) && r >= 0 ));
                if (s != 0 && r != 0)
                {
                    Array.Resize(ref polygons, n);
                    polygons[n-1] = new RegularPolygon(s, r);
                }
            }

            for (int i = 0; i < polygons.Length; i++)
            {
                if (polygons[i].Square > max)
                {
                    max = polygons[i].Square;
                }

                if (polygons[i].Square < min)
                {
                    min = polygons[i].Square;
                }
            }

            for (int i = 0; i < polygons.Length; i++)
            {
                if (polygons[i].Square >= max)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                if (polygons[i].Square <= min)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine($"Площадь {i+1}-го многоугольника:{ polygons[i].Square}");
                Console.ResetColor();
            }
        }
    }
}