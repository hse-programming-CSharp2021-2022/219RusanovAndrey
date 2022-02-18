using System;

namespace PizzaStuff
{
    [Flags]
    public enum Ingredients
    {
        Dough = 1,
        Mozzarella = 2,
        Parmesan = 4,
        TomatoSauce = 8,
        Peperoni = 16,
        Olives = 32,
        Mushrooms = 64,
        Tomatoes = 128,
        Herbs = 256,
        Pineapple = 512,
        Anchovies = 1024,
        Ham = 2048,
        OliveOil = 4096,
    }
}
