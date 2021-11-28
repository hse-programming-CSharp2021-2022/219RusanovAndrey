using System;
using System.Globalization;

namespace Cinderella
{
    public abstract class Something
    {
        protected static Random random = new Random();
    }

    public class Lentil : Something
    {
        
        private double _weight = random.Next(0,2)  + random.NextDouble();
        public override string ToString()
        {
            return $"Lentil with a weight of {_weight}";
        }
    }
    

    public class Ashes : Something
    {
        private double _volume = random.NextDouble();
        public override string ToString()
        {
            return $"Ashes with a volume of {_volume}";
        }
    }

}