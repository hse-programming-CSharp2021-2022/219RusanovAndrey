using System;

namespace Task01_2

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите действительную часть первого комплексного числа: ");
            double re1 = double.Parse(Console.ReadLine());
            Console.Write("Введите вещественную часть комплексного числа: ");
            double im1 = double.Parse(Console.ReadLine());
            MyComplex c1 = new MyComplex(re1, im1);
            Console.Write("Введите действительную часть второго комплексного числа: ");
            double re2 = double.Parse(Console.ReadLine());
            Console.Write("Введите вещественную часть второго комплексного числа: ");
            double im2 = double.Parse(Console.ReadLine());
            MyComplex c2 = new MyComplex(re2, im1);
            Console.WriteLine(c1 + c2);
            Console.WriteLine(c1 - c2);
            Console.WriteLine(c1 * c2);
            Console.WriteLine(c1 / c2);
        }
    }
}