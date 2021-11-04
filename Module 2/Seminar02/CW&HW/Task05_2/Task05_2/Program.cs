using System;

namespace Task05_2
{
    static class Program
    {
        public static bool TryGetColor(this string str, out ConsoleColor color)
        {
            color = ConsoleColor.Black;
            switch (str)
            {
                case "Black":
                    color = ConsoleColor.Black;
                    break;
                case "DarkBlue":
                    color = ConsoleColor.DarkBlue;
                    break;
                case "DarkGreen":
                    color = ConsoleColor.DarkGreen;
                    break;
                case "DarkCyan":
                    color = ConsoleColor.DarkCyan;
                    break;
                case "DarkRed":
                    color = ConsoleColor.DarkRed;
                    break;
                case "DarkMagenta":
                    color = ConsoleColor.DarkMagenta;
                    break;
                case "DarkYellow":
                    color = ConsoleColor.DarkYellow;
                    break;
                case "Gray":
                    color = ConsoleColor.Gray;
                    break;
                case "DarkGray":
                    color = ConsoleColor.DarkGray;
                    break;
                case "Blue":
                    color = ConsoleColor.Blue;
                    break;
                case "Green":
                    color = ConsoleColor.Green;
                    break;
                case "Cyan":
                    color = ConsoleColor.Cyan;
                    break;
                case "Red":
                    color = ConsoleColor.Red;
                    break;
                case "Magenta":
                    color = ConsoleColor.Magenta;
                    break;
                case "Yellow":
                    color = ConsoleColor.Yellow;
                    break;
                case "White":
                    color = ConsoleColor.White;
                    break;
                default: return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            var array = new ConsolePlate[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите символ №{i+1}: ");
                var symbol = Console.ReadLine();
                while (symbol.Length != 1)
                {
                    Console.WriteLine("Неверный формат ввода!");
                    Console.Write($"Введите символ №{i+1}: ");
                    symbol = Console.ReadLine();
                }

                Console.Write($"Введите цвет символа №{i+1}: ");
                ConsoleColor color;
                var strColor = Console.ReadLine();
                while (!strColor.TryGetColor(out color))
                {
                    Console.WriteLine("Неверный формат ввода!");
                    Console.Write($"Введите цвет символа №{i+1}: ");
                    strColor = Console.ReadLine();
                }

                array[i] = new ConsolePlate(symbol[0], color);
            }

            foreach (var item in array)
            {
                item.Write();
                Console.Write(" ");
                
            }
        }
    }
}