using System;

namespace Task01_2
{
    public class MyComplex
    {
        public double re { get; set; }
        public double im { get; set; }

        public MyComplex(double xre, double xim)
        {
            re = xre;
            im = xim;
        }

        public static MyComplex operator --(MyComplex mc)
        {
            return new MyComplex(mc.re - 1, mc.im - 1);
        }

        public double Mod()
        {
            return Math.Abs(re * re + im * im);
        }

        static public bool operator true(MyComplex f)
        {
            if (f.Mod() > 1.0) return true;
            return false;
        }

        public static bool operator false(MyComplex f)
        {
            if (f.Mod() <= 1.0) return true;
            return false;
        }

        public static MyComplex operator +(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.re + b.re, a.im + b.im);
        }

        public static MyComplex operator -(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.re - b.re, a.im - b.im);
        }

        public static MyComplex operator *(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.re * b.re - a.im * b.im, a.im * b.re + a.re * b.im);
        }

        static public MyComplex operator /(MyComplex a, MyComplex b)
        {
            return new MyComplex((a.re * b.re + a.im * b.im) / (Math.Pow(b.re, 2) + Math.Pow(b.im, 2)),
                (a.im * b.re - a.re * b.im) / (Math.Pow(b.re, 2) + Math.Pow(b.im, 2)));
        }

        public override string ToString()
        {
            return $"{re}+{im}i";
        }
    }
}