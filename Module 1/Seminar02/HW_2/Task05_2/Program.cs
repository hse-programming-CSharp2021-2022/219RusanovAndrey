using System;

namespace Task05
{
    class Program
    {
        public static bool Triangle(double a, double b, double c)
        {
            return ((a + b > c) && (a + c > b) && (c + b > a));
                                                      
        }           
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите значение длины отрезка a: ");
                string strA = Console.ReadLine();
                Console.Write("Введите значение длины отрезка b: ");
                string strB = Console.ReadLine();
                Console.Write("Введите значение длины отрезка c: ");
                string strC = Console.ReadLine();
                double a = Convert.ToDouble(strA);
                double b = Convert.ToDouble(strB);
                double c = Convert.ToDouble(strC);


                bool t = ((double.TryParse(strA, out double A)) && (double.TryParse(strB, out double B)) && (double.TryParse(strC, out double C)));
                {
                    switch (t)
                    {
                        case true:
                            switch (Triangle(a, b, c))
                            {
                                case true:
                                    Console.WriteLine("Из отрезков можно составить треугольник.");
                                    Console.WriteLine("Для выхода из программы нажмите ESCAPE. Для продолжения нажмите любую другую кнопку");
                                    break;
                                case false:
                                    Console.WriteLine("Из отрезков невозможно составить треугольник.");
                                    Console.WriteLine("Для выхода из программы нажмите ESCAPE. Для продолжения нажмите любую другую кнопку");
                                    break;

                            }
                            break;
                        case false:
                            Console.WriteLine("Неверный формат ввода!");
                            Console.WriteLine("Для выхода из программы нажмите ESCAPE. Для продолжения нажмите любую другую кнопку");
                            break;
                       
                    }

                }   
            }while (Console.ReadKey().Key != ConsoleKey.Escape);
                 
            
        }
        
            
        
    }
}
