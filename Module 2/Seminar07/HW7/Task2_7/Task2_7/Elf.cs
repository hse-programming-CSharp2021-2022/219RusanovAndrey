using System;

namespace Task2_7
{
    public class Elf : Creature
    {
        private readonly int _age;

        public Elf(string name, double speed) : base(name, speed)
        {
            Random random = new Random();
            _age = random.Next(100, 201);
        }

        public override string Run()
        {
            double x = _speed + _age / 77;
            return $"I am running with a speed of {x}. My age is {_age}.";
        }
    }
}