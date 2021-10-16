using System;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 32 до 127: ");
            string s = Console.ReadLine();
            if ((int.TryParse(s, out int n)) && (n >= 32) && (n <= 127))
            {   
                char c = Convert.ToChar(n);
                Console.WriteLine(c);
            }
            else
                Console.WriteLine("Некорректный формат ввода!");
                


        }
    }
}
