using System;

namespace Task02_Composition
{
    class Engine
    {
    }

    class Car
    {
        Engine engine;

        public Car()
        {
        }

        internal void StartMoving()
        {
            throw new NotImplementedException();
        }

        internal void StopMoving()
        {
            throw new NotImplementedException();
        }
    }

    class Program {
        static void Main() {
            Car car = new();
            car.StartMoving();
            Console.WriteLine(car);
            car.StopMoving();
            Console.WriteLine(car);
        }
    }
}
