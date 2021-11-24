using System;
using System.Threading.Channels;

namespace Task2_7
{
    class Program
    {
        public static string GenerateName()
        {
            Random random = new Random();
            string name = "";
            name += Convert.ToChar(random.Next(65, 91));
            int n = random.Next(2, 10);
            for (int i = 0; i < n; i++)
            {
                name += Convert.ToChar(random.Next(97, 123));
            }

            return name;
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            do
            {
                int n;
                Console.Write("Введите количество существ: ");
                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Неверный формат ввода!");
                    Console.Write("Введите количество существ: ");
                }

                Creature[] creatures = new Creature[n];
                for (int i = 0; i < n; i++)
                {
                    int r = random.Next(0, 10);
                    if (r <= 1)
                    {
                        creatures[i] = new Creature(GenerateName(), random.Next(10, 18) + Math.Round(random.NextDouble(),2));
                    }
                    else if (r >= 2 && r <= 5)
                    {
                        creatures[i] = new Dwarf(GenerateName(), random.Next(10, 18) + Math.Round(random.NextDouble(),2), random.Next(-50, 51));
                    }
                    else
                    {
                        creatures[i] = new Elf(GenerateName(), random.Next(10, 18) + Math.Round(random.NextDouble(),2));
                    }
                }


                foreach (var creature in creatures)
                {
                    Console.WriteLine(creature);
                    if (creature is Dwarf)
                    {
                        Dwarf.MakeNewStaff();
                    }
                }

                Console.WriteLine("Чтобы начать заново, нажмите ПРОБЕЛ.");
                Console.WriteLine("Чтобы закончить, нажмите любую другую клавишу.");
            } while (Console.ReadKey().Key == ConsoleKey.Spacebar);
        }
    }
}