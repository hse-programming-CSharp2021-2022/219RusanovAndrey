using System;
using System.Threading.Channels;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            var points = new Point[3];
            for (int i = 0; i < 3; i++)
            {
                double x;
                double y;
                Console.Write($"Введите координату X точки {i + 1}:");
                string strX = Console.ReadLine();
                while (!double.TryParse(strX, out x))
                {
                    Console.Write($"Введите координату X точки {i + 1}:");
                    strX = Console.ReadLine();
                }

                Console.Write($"Введите координату Y точки {i + 1}:");
                string strY = Console.ReadLine();
                while (!double.TryParse(strY, out y))
                {
                    Console.Write($"Введите координату Y точки {i + 1}:");
                    strY = Console.ReadLine();
                }

                points[i] = new Point(x, y);
            }
            Array.Sort(points, (point, point1) =>
            {
                if (point.Rho > point1.Rho) return 1;
                if (point.Rho < point1.Rho) return -1;
                return 0;
            });

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Данные о точке {i+1}:");
                Console.WriteLine(points[i]);
            }
        }
    }
}