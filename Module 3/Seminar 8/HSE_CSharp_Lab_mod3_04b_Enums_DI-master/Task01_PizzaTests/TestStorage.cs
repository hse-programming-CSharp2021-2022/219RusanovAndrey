using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaStuff;
using PizzaStuff.Recipes;
using System.Linq;

namespace PizzaTests
{
    [TestClass]
    public class TestStorage
    {
        [TestMethod]
        public void TestDeliverAndCheck()
        {
            Pizzeria pizzeria = new();
            pizzeria.DeliverIngredient(Ingredients.Mozzarella, 1);

            var storage = pizzeria.GetStorage();
            var ingredient = storage.First(pair => pair.name == Ingredients.Mozzarella.ToString());
            Assert.AreEqual(ingredient.amount, 1);

            pizzeria.DeliverIngredient(Ingredients.Mozzarella, 1);
            storage = pizzeria.GetStorage();
            ingredient = storage.First(pair => pair.name == Ingredients.Mozzarella.ToString());
            Assert.AreEqual(ingredient.amount, 2);
        }

        [TestMethod]
        public void TestDeliverMultipleIngredients()
        {
            Pizzeria pizzeria = new();
            pizzeria.DeliverIngredient(Ingredients.Parmesan, 1);
            pizzeria.DeliverIngredient(Ingredients.Mozzarella, 2);
            pizzeria.DeliverIngredient(Ingredients.Parmesan, 10);
            pizzeria.DeliverIngredient(Ingredients.Herbs, 10);
            pizzeria.DeliverIngredient(Ingredients.Parmesan, 15);
            pizzeria.DeliverIngredient(Ingredients.Ham, 61);
            pizzeria.DeliverIngredient(Ingredients.Parmesan, 2);

            var storage = pizzeria.GetStorage();
            Assert.AreEqual(storage.First(pair => pair.name == Ingredients.Parmesan.ToString()).amount, 28);
            Assert.AreEqual(storage.First(pair => pair.name == Ingredients.Mozzarella.ToString()).amount, 2);
            Assert.AreEqual(storage.First(pair => pair.name == Ingredients.Herbs.ToString()).amount, 10);
            Assert.AreEqual(storage.First(pair => pair.name == Ingredients.Ham.ToString()).amount, 61);
        }

        [TestMethod]
        public void TestFailRecipeAndCheck()
        {
            Pizzeria pizzeria = new();
            pizzeria.DeliverIngredient(Ingredients.Dough, 2);

            Assert.ThrowsException<PizzaException>(() => pizzeria.MakePizza(new PizzaPeperoni()));

            var storage = pizzeria.GetStorage();
            Assert.AreEqual(storage.First(pair => pair.name == Ingredients.Dough.ToString()).amount, 2);
        }

        [TestMethod]
        public void TestMakePizzaAndCheck()
        {
            Pizzeria pizzeria = new();
            pizzeria.DeliverIngredient(Ingredients.Dough, 2);
            pizzeria.DeliverIngredient(Ingredients.Mozzarella, 2);
            pizzeria.DeliverIngredient(Ingredients.Pineapple, 10);
            pizzeria.DeliverIngredient(Ingredients.Ham, 1);
            pizzeria.DeliverIngredient(Ingredients.Parmesan, 1);

            Assert.IsNotNull(pizzeria.MakePizza(new PizzaHawaii()));

            var storage = pizzeria.GetStorage();
            Assert.AreEqual(storage.First(pair => pair.name == Ingredients.Dough.ToString()).amount, 1);
            Assert.AreEqual(storage.First(pair => pair.name == Ingredients.Mozzarella.ToString()).amount, 1);
            Assert.AreEqual(storage.First(pair => pair.name == Ingredients.Pineapple.ToString()).amount, 9);
            Assert.AreEqual(storage.First(pair => pair.name == Ingredients.Parmesan.ToString()).amount, 1);
        }
    }
}
