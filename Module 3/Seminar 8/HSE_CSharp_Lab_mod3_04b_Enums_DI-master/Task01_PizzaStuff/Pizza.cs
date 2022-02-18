using System;

namespace PizzaStuff
{
    public sealed class Pizza
    {
        public string Name { get; init; }
        public Pizza(PizzaRecipe recipe)
        {
            Name = recipe.Name;
        }
    }
}
