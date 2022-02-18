using System;

namespace PizzaStuff
{
    public class PizzaException : Exception { 
        public PizzaException(string message) : base(message) { }
    }
}
