using System;

namespace Task22_3
{
    delegate void CoordChanged(Dot dot);

    class Dot
    {
        public double x;
        public double y;

        public Dot(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public event CoordChanged OnCoordChanged;

        public void DotFlow()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                x = random.Next(-10, 10) + random.NextDouble();
                y = random.Next(-10, 10) + random.NextDouble();
                if (x<0 && y<0)
                {
                    OnCoordChanged?.Invoke(this);
                }
            }
        }

    }
    class Program
    {
        public static void PrintInfo(Dot A)
        {
            string s = $"X: {(A.x).ToString("F3")}; Y:{(A.y).ToString("F3")}";
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Dot dot = new Dot(x, y);
            dot.OnCoordChanged += PrintInfo;
            dot.DotFlow();
        }
    }
}