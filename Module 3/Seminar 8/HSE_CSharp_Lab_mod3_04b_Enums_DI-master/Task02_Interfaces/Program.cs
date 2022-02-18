using System;

namespace Task02_Interfaces
{
    interface IMovable
    {
        public void Start();
        public void Stop();
    }

    class Engine : IMovable
    {
        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }


    class ElectoEngine : IMovable
    {
        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    class Car
    {
        IMovable mover;
        public Car(IMovable someMover) {
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

    class Program
    {
        static void Main()
        {
            IMovable engine = new Engine();

            Car car = new(engine);
            car.StartMoving();
            Console.WriteLine(car);
            car.StopMoving();
            Console.WriteLine(car);


            IMovable engine2 = new ElectoEngine();

            Car car2 = new(engine2);
            car.StartMoving();
            Console.WriteLine(car2);
            car.StopMoving();
            Console.WriteLine(car2);
        }
    }
}
