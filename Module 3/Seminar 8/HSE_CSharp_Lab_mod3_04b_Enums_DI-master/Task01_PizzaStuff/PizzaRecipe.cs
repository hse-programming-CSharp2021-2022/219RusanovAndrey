using System;

namespace PizzaStuff
{
    /// <summary>
    /// Базовый класс для рецепта пиццы.
    /// </summary>
    public abstract class PizzaRecipe
    {
        /// <summary>
        /// Название рецепта.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Множество ингредиентов, которые входят в рецепт.
        /// </summary>
        public abstract Ingredients Ingredients { get; }
    }
}
