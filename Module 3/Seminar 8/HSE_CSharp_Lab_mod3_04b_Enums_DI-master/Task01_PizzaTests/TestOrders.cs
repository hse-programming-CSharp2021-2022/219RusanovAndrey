using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaStuff;
using PizzaStuff.Recipes;
using System.Linq;


namespace PizzaTests
{
    [TestClass]
    public class TestOrders
    {
        [TestMethod]
        public void MakeOnlyOnePizza()
        {
            Pizzeria pizzeria = new();
            pizzeria.DeliverIngredient(Ingredients.Dough, 1);
            pizzeria.DeliverIngredient(Ingredients.Parmesan, 1);
            pizzeria.DeliverIngredient(Ingredients.Anchovies, 1);
            pizzeria.DeliverIngredient(Ingredients.TomatoSauce, 1);

            // Первая пицца успешно создается.
            Assert.AreEqual(pizzeria.MakePizza(new PizzaSicilian()).Name, "Sicilian");

            // Вторая пицца не создается из-за нехватки ингредиентов.
            Assert.ThrowsException<PizzaException>(() => pizzeria.MakePizza(new PizzaSicilian()));
        }

        [TestMethod]
        public void OneIngredientMissing()
        {
            Pizzeria pizzeria = new();
            pizzeria.DeliverIngredient(Ingredients.Dough, 1);
            pizzeria.DeliverIngredient(Ingredients.Parmesan, 1);
            pizzeria.DeliverIngredient(Ingredients.Ham, 1);
            pizzeria.DeliverIngredient(Ingredients.TomatoSauce, 1);

            // Не хватает ингредиента.
            Assert.ThrowsException<PizzaException>(() => pizzeria.MakePizza(new PizzaSicilian()));
        }

        [TestMethod]
        public void TestOrder()
        {
            Pizzeria pizzeria = new();
            PizzaRecipe[] order = new int[10].Select(_ => new PizzaSicilian()).ToArray();

            pizzeria.DeliverIngredient(Ingredients.Dough, 10);
            pizzeria.DeliverIngredient(Ingredients.Parmesan, 10);
            pizzeria.DeliverIngredient(Ingredients.Anchovies, 10);
            pizzeria.DeliverIngredient(Ingredients.TomatoSauce, 10);
            pizzeria.DeliverIngredient(Ingredients.Tomatoes, 10);
            pizzeria.DeliverIngredient(Ingredients.Ham, 10);

            foreach (var recipe in order)
            {
                pizzeria.MakePizza(recipe);
            }

            Assert.ThrowsException<PizzaException>(() => pizzeria.MakePizza(new PizzaSicilian()));
        }

        [TestMethod]
        public void TestEmptyStorage()
        {
            Pizzeria pizzeria = new();
            Assert.ThrowsException<PizzaException>(() => pizzeria.MakePizza(new PizzaSicilian()));
            Assert.ThrowsException<PizzaException>(() => pizzeria.MakePizza(new PizzaPeperoni()));
            Assert.ThrowsException<PizzaException>(() => pizzeria.MakePizza(new PizzaHawaii()));
        }

        [TestMethod]
        public void MakeThree()
        {
            Pizzeria pizzeria = new();
            pizzeria.DeliverIngredient(Ingredients.Dough, 6);
            pizzeria.DeliverIngredient(Ingredients.Ham, 1);
            pizzeria.DeliverIngredient(Ingredients.Pineapple, 1);
            pizzeria.DeliverIngredient(Ingredients.Mozzarella, 2);
            pizzeria.DeliverIngredient(Ingredients.Peperoni, 1);
            pizzeria.DeliverIngredient(Ingredients.OliveOil, 1);
            pizzeria.DeliverIngredient(Ingredients.Herbs, 1);
            pizzeria.DeliverIngredient(Ingredients.TomatoSauce, 1);
            pizzeria.DeliverIngredient(Ingredients.Anchovies, 1);
            pizzeria.DeliverIngredient(Ingredients.Parmesan, 1);

            PizzaRecipe[] order = { new PizzaPeperoni(), new PizzaSicilian(),  new PizzaHawaii() };

            foreach(var recipe in order)
            {
                Assert.IsNotNull(pizzeria.MakePizza(recipe));
            }

            foreach(var recipe in order)
            {
                Assert.ThrowsException<PizzaException>(() => pizzeria.MakePizza(recipe));
            }
        }

        [TestMethod]
        public void DeliverAfterMakingPizza()
        {
            Pizzeria pizzeria = new();
            pizzeria.DeliverIngredient(Ingredients.Dough, 2);
            pizzeria.DeliverIngredient(Ingredients.Ham, 1);
            pizzeria.DeliverIngredient(Ingredients.Pineapple, 1);
            pizzeria.DeliverIngredient(Ingredients.Mozzarella, 1);
            pizzeria.DeliverIngredient(Ingredients.Peperoni, 1);
            pizzeria.DeliverIngredient(Ingredients.OliveOil, 1);
            pizzeria.DeliverIngredient(Ingredients.Herbs, 1);

            pizzeria.MakePizza(new PizzaHawaii());
            Assert.ThrowsException<PizzaException>(() => pizzeria.MakePizza(new PizzaPeperoni()));

            pizzeria.DeliverIngredient(Ingredients.Mozzarella, 1);
            
            pizzeria.MakePizza(new PizzaPeperoni());
        }
    }
}