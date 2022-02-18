using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaStuff;
using PizzaStuff.Recipes;
using System;
using System.Linq;

internal class PizzaEmpty : PizzaRecipe
{
    public override string Name => "Empty recipe";

    public override Ingredients Ingredients => 0;
}

namespace PizzaTests
{
    [TestClass]
    public class TestImplementation
    {
        [TestMethod]
        public void TestIngredients()
        {
            foreach (var item in Enum.GetValues(typeof(Ingredients)))
            {
                Assert.AreNotEqual((int)item, 0);
            }
        }

        [TestMethod]
        public void TestPizzaHawaii()
        {
            PizzaHawaii recipe = new();
            Assert.AreNotEqual(recipe.Name, "");
            Assert.AreNotEqual(recipe.Ingredients, (Ingredients)0);
        }

        [TestMethod]
        public void TestPizzaPeperoni()
        {
            PizzaPeperoni recipe = new();
            Assert.AreNotEqual(recipe.Name, "");
            Assert.AreNotEqual(recipe.Ingredients, (Ingredients)0);
        }

        [TestMethod]
        public void TestPizzaSicilian()
        {
            PizzaSicilian recipe = new();
            Assert.AreNotEqual(recipe.Name, "");
            Assert.AreNotEqual(recipe.Ingredients, (Ingredients)0);
        }

        [TestMethod]
        public void TestPizza()
        {
            PizzaSicilian recipe = new();
            Pizza pizza = new(recipe);
            Assert.AreEqual(pizza.Name, recipe.Name);
        }

        [TestMethod]
        public void TestPizzaException()
        {
            string message = "This is an exception message.";
            PizzaException pizzaException = new(message);
            Assert.AreEqual(pizzaException.Message, message);
        }

        [TestMethod]
        public void TestPizzeria()
        {
            Pizzeria pizzeria = new();

            pizzeria.DeliverIngredient(Ingredients.OliveOil, 1);

            Assert.IsNotNull(pizzeria.GetStorage());
            Assert.IsNotNull(pizzeria.MakePizza(new PizzaEmpty()));
        }

    }
}