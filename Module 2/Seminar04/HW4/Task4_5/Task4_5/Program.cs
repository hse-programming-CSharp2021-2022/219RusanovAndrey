using System;

namespace Task4_5
{
    class Shape
    {
        public virtual double Area()
        {
            return 0.0;
        }

        public override string ToString()
        {
            return $"площадь: {Area():0.000}";
        }
    }

    class Circle : Shape
    {
        public double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double Area()
        {
            return 2 * _radius * Math.PI;
        }
    }

    class Cylinder : Shape
    {
        public double _radius;
        public double _height;

        public Cylinder(double radius, double height)
        {
            _radius = radius;
            _height = height;
        }

        public override double Area()
        {
            return 2 * _radius * Math.PI * (_radius + _height);
        }
    }

    class Sphere : Shape
    {
        public double _radius;

        public Sphere(double radius)
        {
            _radius = radius;
        }

        public override double Area()
        {
            return 4 * _radius * _radius * Math.PI;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n1 = random.Next(3, 6);
            int n2 = random.Next(3, 6);
            int n3 = random.Next(3, 6);
            Shape[] shapes = new Shape[n1 + n2 + n3];
            for (int i = 0; i < n1; i++)
            {
                shapes[i] = new Circle(random.Next());
            }

            for (int i = n1; i < n1 + n2; i++)
            {
                shapes[i] = new Cylinder(random.Next(), random.Next());
            }

            for (int i = n1 + n2; i < n1 + n2 + n3; i++)
            {
                shapes[i] = new Sphere(random.Next());
            }

            foreach (var shape in shapes)
            {
                if (shape is Circle)
                {
                    Console.WriteLine($"Круг, {shape}");
                }

                if (shape is Cylinder)
                {
                    Console.WriteLine($"Цилиндр, {shape}");
                }

                if (shape is Sphere)
                {
                    Console.WriteLine($"Сфера, {shape}");
                }
            }
        }
    }
}