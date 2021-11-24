using System;
using System.Text;

namespace Task2_7
{
    public class Creature
    {
        protected readonly string _name;
        protected readonly double _speed;


        public Creature(string name, double speed)
        {
            _name = name;
            _speed = speed;
        }

        public virtual string Run()
        {
            return $"I am running with a speed of {_speed}.";
        }

        public override string ToString()
        {
            return $"{Run()} My name is {_name}.";
        }
    }
}