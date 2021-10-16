using System;

namespace Task03_2
{
    class Program
    {
        public static double D(double a, double b, double c)
        {
            return (Math.Pow(b, 2) - (4 * a * c));

        }
        public static string Q(double a, double b, double c)
        {
            
            double x1 = (Math.Sqrt(D(a, b, c)) - b) / (2 * a);
            double x2 = (-(Math.Sqrt(D(a, b, c))) - b) / (2 * a);
            double x = -b / (2 * a);         
            string res = (D(a, b, c) > 0) ? ($"{x1}, {x2}") : ((D(a, b, c) == 0) ? ($"{x}") : ("Нет корней"));
            return res;

  


            
          
    
        }


        static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите значения коэффицентa A: ");
                string strA = Console.ReadLine();
                Console.Write("Введите значения коэффицентa B: ");
                string strB = Console.ReadLine();
                Console.Write("Введите значения коэффицентa C: ");
                string strC = Console.ReadLine();


                bool t = (double.TryParse(strA, out double A)) && (double.TryParse(strB, out double B)) && (double.TryParse(strC, out double C));
                switch (t)
                {
                    case true:
                        A = Convert.ToDouble(strA);
                        B = Convert.ToDouble(strB);
                        C = Convert.ToDouble(strC);
                        Console.WriteLine("Ответ: " + Q(A, B, C));
                        Console.WriteLine("Для выхода из программы нажмите ESCAPE. Для продолжения нажмите любую другую кнопку");
                        break;
                    case false:
                        Console.WriteLine("Неверный формат ввода!");
                        Console.WriteLine("Для выхода из программы нажмите ESCAPE. Для продолжения нажмите любую другую кнопку");
                        break;





                }
                






            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }








    }


    
}



    
   

