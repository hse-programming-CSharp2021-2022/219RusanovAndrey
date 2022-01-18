using System;

namespace Task1_3
{
    delegate void SquareSizeChanged(double d);
    class Square
    {
        private double x1;
        private double y1;
        private double x2;
        private double y2;
        public event SquareSizeChanged OnSizeChanged;

        private double X1
        {
            get => x1;
            set
            {
                OnSizeChanged?.Invoke(Math.Abs(x2 - x1));
                x1 = value;
            }
        }

        double Y1
        {
            get => y1;
            set
            {
                OnSizeChanged?.Invoke(Math.Abs(y2 - y1));
                y1 = value;
            }
        }

        public double X2
        {
            get => x2;
            set
            {
                OnSizeChanged?.Invoke(Math.Abs(x2 - x1));
                x2 = value;
            }
        }

        public double Y2
        {
            get => y2;
            set
            {
                OnSizeChanged?.Invoke(Math.Abs(y2 - y1));
                y2 = value;
            }
        }

        public Square(double x1, double y1, double x2, double y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        
    }

    class Program
    {
        static void SquareConsoleInfo(double A)
        {
            Console.WriteLine(A.ToString("F2"));
        }

        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Square S = new Square(x1, y1, x2, y2);
            S.OnSizeChanged += SquareConsoleInfo;
            string s = Console.ReadLine();
            while (s!="*")
            {
                x2 = double.Parse(s);
                s = Console.ReadLine();
                S.X2 = x2;
                y2 = double.Parse(s);
                S.Y2 = y2;
            }
        }
    }
}