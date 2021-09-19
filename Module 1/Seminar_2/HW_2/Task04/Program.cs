using System;

namespace Task04_2
{
    class Program
    {
        public static string ReversedNum(string s) 
        {
            string res = "";
            foreach (char c in s)
                res = c + res;
            return (res);

        
        }
        

        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Введтье четырехзначное натуральное число: ");
                string s = Console.ReadLine();
                if ((int.TryParse(s, out int n)) && (n >= 1000) && (n <= 9999))
                {
                    Console.WriteLine(ReversedNum(s));
                    Console.WriteLine("Для выхода из программы нажмите ESCAPE. Для продолжения нажмите любую другую кнопку");
                }
                else
                {
                    Console.WriteLine("Неверный формат ввода!");
                    Console.WriteLine("Для выхода из программы нажмите ESCAPE. Для продолжения нажмите любую другую кнопку");



                }
                if (Console.ReadKey().Key == ConsoleKey.Escape) return;


            }


        }
    }
}

