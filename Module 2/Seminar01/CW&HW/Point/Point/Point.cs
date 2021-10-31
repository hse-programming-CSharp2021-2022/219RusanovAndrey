using System;

namespace Point
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
            
        }

        public double Rho => (Math.Sqrt(X * X + Y * Y));

        public double Phi
        {
            get
            {
                if (X > 0 && Y >= 0)
                    return Math.Atan(Y / X);
                if (X > 0 && Y < 0)
                    return Math.Atan(Y / X) + 2 * Math.PI;
                if (X < 0)
                    return Math.Atan(Y / X) + Math.PI;
                if (X == 0 && Y > 0)
                    return Math.PI / 2;
                if (X == 0 && Y < 0)
                    return 3 * Math.PI / 2;
                return 0;
            }                                                               
        }

        public override string ToString()
        {
            return ($"Координата X: {X}\nКоордината Y: {Y}\nРадиальная координата: {Rho}\nУгловая координата: {Phi}");
        }

       
    }
}