using System;

namespace Homework5
{
    public interface IFunction
    {
        public double Function(double x);
    }

    public delegate double Calculate(double x);

    class F : IFunction
    {
        private Calculate calc;

        public F(Calculate calc)
        {
            this.calc = calc;
        }

        public double Function(double x) => calc(x);
    }

    class G
    {
        private F f1;
        private F f2;

        public G(F f1, F f2)
        {
            this.f1 = f1;
            this.f2 = f2;
        }

        public double GF(double x0) => f1.Function(f2.Function(x0));
    }

    class Program
    {
        static void Main(string[] args)
        {
            G g = new G(new F(x => x * x - 4), new F(x => Math.Sin(x)));
            for (double i = 0; i <= Math.PI; i += Math.PI / 16)
            {
                Console.WriteLine(g.GF(i).ToString("F4"));
            }
        }
    }
}