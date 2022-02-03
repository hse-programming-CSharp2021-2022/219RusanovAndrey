using System;

namespace Task6_4
{
    public class RingIsFoundEventArgs : EventArgs
    {
        public RingIsFoundEventArgs(string s)
        {
            Message = s;
        }

        public String Message { get; set; }
    }

    public abstract class Creature
    {
        public string Name { get; set; }
        public string? Location { get; set; }

        public Creature(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public virtual void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Нахожусь в {Location}. Покидаю {Location}. Направляюсь в {e.Message}");
            Location = e.Message;
        }
    }


    public class Wizard : Creature
    {
        public delegate void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs a);

        public event RingIsFoundEventHandler? RaiseRingIsFoundEvent;

        public Wizard(string name, string location) : base(name, location)
        {
        }

        public void SomeThisIsChangedInTheAir()
        {
            Console.WriteLine($"{Name} >> Кольцо найдено у старого Бильбо! Призываю вас в Ривендейл! ");
            RaiseRingIsFoundEvent?.Invoke(this, new RingIsFoundEventArgs("Ривендейл"));
        }
    }


    public class Dwarf : Creature
    {
        public Dwarf(string name, string location) : base(name, location)
        {
        }

        public override void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Точим топоры, собираем припасы! Оставляем {Location}. Выдвигаемся в " +
                              e.Message);
            Location = e.Message;
        }
    }

    public class Elf : Creature
    {
        public Elf(string name, string location) : base(name, location)
        {
        }

        public override void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine(
                $"{Name} >> Звёзды светят не так ярко как обычно. Цветы увядают. Листья предсказывают покинуть {Location} и идти в " +
                e.Message);
            Location = e.Message;
        }
    }


    public class Hobbit : Creature
    {
        public Hobbit(string name, string location) : base(name, location)
        {
        }

        public override void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Покидаю {Location}! Иду в " + e.Message);
            Location = e.Message;
        }
    }

    public class Human : Creature
    {
        public Human(string name, string location) : base(name, location)
        {
        }

        public override void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine(
                $"{Name} >> Волшебник {((Wizard) sender).Name} позвал. Покидаю {Location}. Моя цель {e.Message}");
            Location = e.Message;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var gandalf = new Wizard("Гэндальф", "Изенгард");
            var fellowshipOfTheRing = new Creature[8];
            fellowshipOfTheRing[0] = new Hobbit("Бильбо", "Шир");
            fellowshipOfTheRing[1] = new Hobbit("Сэм", "Шир");
            fellowshipOfTheRing[2] = new Hobbit("Мерри", "Шир");
            fellowshipOfTheRing[3] = new Hobbit("Пиппин", "Шир");
            fellowshipOfTheRing[4] = new Human("Арагорн", "Бри");
            fellowshipOfTheRing[5] = new Human("Боромир", "Гондор");
            fellowshipOfTheRing[6] = new Elf("Леголас", "Лихолесье");
            fellowshipOfTheRing[7] = new Dwarf("Гимли", "Эребор");
            foreach (var character in fellowshipOfTheRing)
            {
                gandalf.RaiseRingIsFoundEvent += character.RingIsFoundEventHandler;
            }

            gandalf.SomeThisIsChangedInTheAir();
        }
    }
}