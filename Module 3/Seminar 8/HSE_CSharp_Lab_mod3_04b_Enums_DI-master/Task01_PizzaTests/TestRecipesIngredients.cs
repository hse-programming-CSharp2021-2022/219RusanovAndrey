using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaStuff;
using PizzaStuff.Recipes;

namespace PizzaTests
{
    [TestClass]
    public class TestRecipesIngredients
    {
        [TestMethod]
        public void CheckPizzaHawaiiIngredients()
        {
            var pizza = new PizzaHawaii();
            Ingredients required = Ingredients.Dough | Ingredients.Pineapple
                | Ingredients.Ham | Ingredients.Mozzarella;


            Assert.AreEqual<Ingredients>(pizza.Ingredients ^ required, 0);
        }

        [TestMethod]
        public void CheckPizzaPeperoniIngredients()
        {
            var pizza = new PizzaPeperoni();
            Ingredients required = Ingredients.Dough | Ingredients.Peperoni | Ingredients.OliveOil | Ingredients.Mozzarella | Ingredients.Herbs;

            Assert.AreEqual<Ingredients>(pizza.Ingredients ^ required, 0);
        }

        [TestMethod]
        public void CheckPizzaSicilianIngredients()
        {
            var pizza = new PizzaSicilian();
            Ingredients required = Ingredients.Dough | Ingredients.TomatoSauce | Ingredients.Anchovies | Ingredients.Parmesan;

            Assert.AreEqual<Ingredients>(pizza.Ingredients ^ required, 0);
        }
    }
}
