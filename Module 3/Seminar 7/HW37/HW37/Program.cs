using System;

namespace HW37
{
    struct Person : IComparable<Person>
    {
        private string name;
        private string lastname;
        private int age;

        public Person(string name, string lastname, string strAge)
        {
            this.name = name;
            this.lastname = lastname;
            if (!int.TryParse(strAge, out int age) || age < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.age = age;
        }

        public int CompareTo(Person other)
        {
            if (age > other.age)
            {
                return 1;
            }

            if (age < other.age)
            {
                return -1;
            }

            return 0;
        }

        public override string ToString()
        {
            return $"Имя: {name}, Фамилия: {lastname}, Возраст: {age} лет.";
        }
    }

    class Program
    {
        public static string GenerateName()
        {
            string name = "";
            var rand = new Random();
            name += Convert.ToChar(rand.Next(65, 91));
            int len = rand.Next(3, 12);
            for (int i = 0; i < len; i++)
            {
                name += Convert.ToChar(rand.Next(97, 123));
            }

            return name;
        }

        static void Main(string[] args)
        {
            int n;
            var rand = new Random();
            Console.Write("Введите количество персонажей: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.Write("Неверный формат ввода! Введите неотрицательное целое число:");
            }

            var characters = new Person[n];
            for (int i = 0; i < n; i++)
            {
                characters[i] = new Person(GenerateName(), GenerateName(), rand.Next(1, 101).ToString());
            }

            Array.ForEach(characters, x => Console.WriteLine(x));
            Console.WriteLine();
            Array.Sort(characters);
            Array.ForEach(characters, x => Console.WriteLine(x));
        }
    }
}