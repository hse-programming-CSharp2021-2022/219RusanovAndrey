using System;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace Task05_3
{
    class Program
    {
        public static string GenerateName()
        {
            string name = "";
            var rand = new Random();
            int len = rand.Next(2, 10);
            int t;
            t = rand.Next(0, 2);
            for (int i = 0; i < len; i++)
            {
                t = rand.Next(0, 2);
                if (t == 0)
                {
                    name += Convert.ToChar(rand.Next(65, 91));
                }

                if (t == 1)
                {
                    name += Convert.ToChar(rand.Next(97, 123));
                }
            }

            return name;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                var rand = new Random();
                var vf = new VideoFile(GenerateName(), rand.Next(60, 361),
                    rand.Next(100, 1001));
                Console.WriteLine(vf);
                int n = rand.Next(5, 15);
                var array = new VideoFile[n];
                for (int i = 0; i < n; i++)
                {
                    array[i] = new VideoFile(GenerateName(), rand.Next(60, 361),
                        rand.Next(100, 1001));
                    if (array[i].Size > vf.Size)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
                Console.WriteLine("Нажмите ESCAPE, чтобы выйти. Чтобы заново запустить прорамму, нажмите любую другую кнопку.");
                if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                Console.WriteLine();
            }

        }
    }
}