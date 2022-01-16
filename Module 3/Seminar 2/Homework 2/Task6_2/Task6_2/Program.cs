using System;
using System.Threading.Channels;

namespace Task6_2
{
    class Plant
    {
        private double _growth;
        private double _photosensitivity;
        private double _frostresistance;

        public double Growth
        {
            get => _growth;
            private set => _growth = value;
        }

        public double Photosensitivity
        {
            get => _photosensitivity;
            set
            {
                if (value > 100 || value < 0)
                {
                    throw new ArgumentException("Недопустимое значение!");
                }
                else
                {
                    _photosensitivity = value;
                }
            }
        }

        public double Frostresistance
        {
            get => _frostresistance;
            set
            {
                if (value > 100 || value < 0)
                {
                    throw new ArgumentException("Недопустимое значение!");
                }
                else
                {
                    _frostresistance = value;
                }
            }
        }

        public Plant(double growth, double photosensitivity, double frostresistance)
        {
            Growth = growth;
            Photosensitivity = photosensitivity;
            Frostresistance = frostresistance;
        }


        public override string ToString()
        {
            return
                $"Growth: {Growth:F3}; Photosensitivity: {Photosensitivity:F3}; Frostresistance: {Frostresistance:F3}.";
        }
    }

    class Program
    {
        public static int SortPlants(Plant plant, Plant plant1)
        {
            if ((int) plant.Photosensitivity % 2 != 0 && (int) plant1.Photosensitivity % 2 == 0) return 1;
            if ((int) plant.Photosensitivity % 2 == (int) plant1.Photosensitivity % 2) return 0;
            return -1;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество растений: ");
            string s = Console.ReadLine();
            int n = 0;
            while (!int.TryParse(s, out n))
            {
                Console.WriteLine();
                Console.WriteLine("Неверный формат ввода!");
                Console.WriteLine("Введите количество растений:");
                s = Console.ReadLine();
            }

            Random random = new Random();
            Plant[] plants = new Plant[n];
            for (int i = 0; i < n; i++)
            {
                plants[i] = new Plant(random.Next(25, 100) + random.NextDouble(),
                    random.Next(100) + random.NextDouble(), random.Next(80) + random.NextDouble());
            }

            Array.ForEach(plants, Console.WriteLine);
            Console.WriteLine();
            Array.Sort(plants, delegate(Plant plant, Plant plant1)
            {
                if (plant.Growth < plant1.Growth) return 1;
                if (plant.Growth > plant1.Growth) return -1;
                return 0;
            });
            Array.ForEach(plants, Console.WriteLine);
            Console.WriteLine();
            Array.Sort(plants, (plant, plant1) =>
            {
                if (plant.Frostresistance > plant1.Frostresistance) return 1;
                if (plant.Frostresistance < plant1.Frostresistance) return -1;
                return 0;
            });
            Array.ForEach(plants, Console.WriteLine);
            Console.WriteLine();
            Array.Sort(plants, SortPlants);
            Array.ForEach(plants, Console.WriteLine);
            Console.WriteLine();
            Array.ConvertAll(plants,
                plant => plant.Frostresistance = ((int)plant.Frostresistance % 2 == 0)
                    ? plant.Frostresistance / 3
                    : plant.Frostresistance / 2);
            Array.ForEach(plants, Console.WriteLine);
            Console.WriteLine();
        }
    }
}