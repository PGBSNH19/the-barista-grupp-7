using System;
using Xunit;
using Kaffemaskin;

namespace XUnitTest_Kaffemaskin
{
    public class BeverageTests
    {
        [Fact]
        public void MakeEspresso()  
        {
            BeverageRecipeFactory beverageRecipeFactory = new BeverageRecipeFactory();
            IBeverageRecipe recipe = beverageRecipeFactory.getRecipe(CoffeeSort.Espresso);

            CoffeeCup coffeeCup = recipe.MakeBeverage(CupSize.small);

            Assert.Equal("Beansort: Arabica, 5 grams", coffeeCup.Ingredients[0]);
        }
    }
}
