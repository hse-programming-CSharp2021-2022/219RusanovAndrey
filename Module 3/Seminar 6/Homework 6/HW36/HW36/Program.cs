using System;

namespace HW36
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Distance(Point p) =>
            Math.Sqrt((X - p.X) * (X - p.X) + (Y - p.Y) * (Y - p.Y));

        public override string ToString()
        {
            return $"X: {X}, Y:{Y}.";
        }
    }

    class Circle : IComparable<Circle>
    {
        public double Rad { get; set; }
        public Point Center { get; set; }

        public Circle(double rad, double x, double y)
        {
            Rad = rad;
            Center = new Point(x, y);
        }

        public override string ToString()
        {
            return $"Радиус: {Rad}; Координаты центра: {Center}";
        }

        public int CompareTo(Circle other)
        {
            if (Rad * Center.Distance(new Point(0, 0)) > (other.Rad * other.Center.Distance(new Point(0, 0))))
            {
                return 1;
            }

            if (Rad * Center.Distance(new Point(0, 0)) < (other.Rad * other.Center.Distance(new Point(0, 0))))
            {
                return -1;
            }

            return 0;
        }
    }

    struct PointStruct
    {
        public double X { get; set; }
        public double Y { get; set; }

        public PointStruct(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Distance(Point p) =>
            Math.Sqrt((X - p.X) * (X - p.X) + (Y - p.Y) * (Y - p.Y));

        public override string ToString()
        {
            return $"X: {X}, Y:{Y}.";
        }
    }

    class CircleStruct
    {
        public double Rad { get; set; }
        public Point Center { get; set; }

        public CircleStruct(double rad, double x, double y)
        {
            Rad = rad;
            Center = new Point(x, y);
        }

        public override string ToString()
        {
            return $"Радиус: {Rad}; Координаты центра: {Center}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите количество окружностей: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.Write("Неверный формат ввода! Введите неотрицательное целое число: ");
            }

            Circle[] circles = new Circle[n];
            for (int i = 0; i < n; i++)
            {
                double rad;
                Console.Write($"Введите длину радиуса окружности {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out rad) || n < 0)
                {
                    Console.Write("Неверный формат ввода! Введите неотрицательное вещественное число: ");
                }

                double x;
                Console.Write($"Введите абсциссу центра окружности {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Неверный формат ввода! Введите вещественное число: ");
                }

                double y;
                Console.Write($"Введите ординату центра окружности {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out y))
                {
                    Console.Write("Неверный формат ввода! Введите вещественное число: ");
                }

                circles[i] = new Circle(rad, x, y);
            }

            Array.Sort(circles);
            Array.ForEach(circles, Console.WriteLine);
        }
    }
}