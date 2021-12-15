using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Task01
{
    abstract class Person
    {
        public static Random random = new Random();
        public string Name { get; set; }
        public string Pocket { get; set; }
        public abstract void Receive(string present);

        public Person(string name)
        {
            Name = name;
            Pocket = string.Empty;
        }

        public override string ToString()
        {
            return $"Name = {Name} Pocket = {Pocket}";
        }
    }

    class SnowMaiden : Person
    {
        public SnowMaiden(string name) : base(name)
        {
        }

        private string CreateName()
        {
            int len = random.Next(3, 11);
            StringBuilder str = new StringBuilder(len);
            for (int i = 0; i < len; i++)
                str.Append((char) random.Next('a', 'z' + 1));
            return str.ToString();
        }

        public string[] CreatePresent(int amount)
        {
            string[] gifts = new string[amount];
            for (int i = 0; i < amount; i++)
            {
                gifts[i] = CreateName();
            }

            return gifts;
        }

        public override void Receive(string present)
        {
            if (Pocket.Equals(string.Empty))
                Pocket = present;
            else
                throw new ArgumentException(">1 gifts");
        }
    }

    class Santa : Person
    {
        public List<string> sack;

        public void Request(SnowMaiden snowMaiden, int amount)
        {
            sack.AddRange(snowMaiden.CreatePresent(amount));
        }

        public Santa(string name) : base(name)
        {
            sack = new List<string>();
        }

        public void Give(Person person)
        {
            if (sack.Count == 0)
            {
                throw new Exception("Santa's sack is empty!");
            }
            var r = new Random();
            var indOfPresent = r.Next(0, sack.Count);
            person.Receive(sack[indOfPresent]);
            sack.RemoveAt(indOfPresent);
        }

        public override void Receive(string present)
        {
            if (Pocket.Equals(string.Empty))
                Pocket = present;
            else
                throw new ArgumentException("Santa's pocket is full!");
        }
    }

    class Child : Person
    {
        public string AdditionalPocket { get; set; }

        public Child(string name) : base(name)
        {
            AdditionalPocket = string.Empty;
        }

        public override void Receive(string present)
        {
            if (Pocket.Equals(string.Empty))
                Pocket = present;
            else if (AdditionalPocket.Equals(string.Empty))
                AdditionalPocket = present;
            else
                throw new ArgumentException($"{Name}'s pockets are full!");
        }

        public override string ToString()
        {
            return base.ToString() + $" AdditionalPocket = {AdditionalPocket}";
        }
    }

    class Program
    {
        private static void Main()
        {
            while (true)
            {
                var maiden = new SnowMaiden("Snow Maiden");
                var santa = new Santa("Santa");
                var persons = new List<Person>(12);
                persons.Add(santa);
                persons.Add(maiden);
                for (var i = 0; i < 10; i++)
                {
                    persons.Add(new Child($"Child {i + 1}"));
                }

                var flag = true;
                var isDeleted = false;
                while (true)
                {
                    var r = new Random();
                    if (r.Next(1, 11) == 1)
                    {
                        try
                        {
                            santa.Give(santa);
                            Console.WriteLine(santa);
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            if (flag)
                                santa.Request(maiden, r.Next(1, 5));
                            if (isDeleted)
                                break;
                            goto Label;
                        }
                    }
                    else
                    {
                        var who = r.Next(1, persons.Count);
                        try
                        {
                            santa.Give(persons[who]);
                            Console.WriteLine(persons[who]);
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                            persons.RemoveAt(who);
                            if (who == 1 && !isDeleted)
                            {
                                flag = false;
                                isDeleted = true;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            if (flag)
                                santa.Request(maiden, r.Next(1, 5));
                            if (isDeleted)
                                break;
                            goto Label;
                        }
                    }

                    if (flag)
                        santa.Request(maiden, r.Next(1, 5));
                    Label:
                    if (santa.sack.Count == 0)
                    {
                        break;
                    }

                    if (persons.Count == 1)
                    {
                        break;
                    }
                }

                Console.WriteLine("Чтобы завершить работу программы, нажмите Escape.");
                Console.WriteLine("Чтобы начать заново, нажмите любую другую кнопку.");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    return;
            }
        }
    }
}