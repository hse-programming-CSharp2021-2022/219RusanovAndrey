using System;

namespace Task2_7
{
    public class Dwarf : Creature
    {
        private int _strenght;
        public Dwarf(string name, double speed, int strength) : base(name, speed)
        {
            
            Strength = strength;
        }
        
        public int Strength
        {
            get => _strenght;
            set
            {
                if (value >= 1 && value <= 20)
                {
                    _strenght = value;
                }
                else
                {
                    Random random = new Random();
                    _strenght = random.Next(1, 21);
                }
            }


        }

        public static void MakeNewStaff()
        {
            Console.WriteLine("I've created a new staff!");
        }

        public override string Run()
        {
            return $"I am running with a speed of {_speed}. My strength is {_strenght}";
        }
        
        public override string ToString()
        {
            return $"{Run()}. My name is {_name}.";
        }
    }
}