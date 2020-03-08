using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskin
{
    public class Mocha : IBeverageRecipe
    {
        public CoffeeCup MakeBeverage(CupSize cupSize)
        {
            CoffeeCup mocha = new FluentCoffee()
                .ChooseCupSize(cupSize)
                .AddBeans(BeanSort.Arabica, 5)
                .AddWater(15)
                .Heating(waterTemp => waterTemp >= 95)
                .AddChocolateSyrup(5)
                .AddMilk(20)
                .ToBeverage();

            Console.WriteLine("Your Mocha is ready!");
            Console.WriteLine();
            Console.WriteLine("You chose a " + cupSize.ToString() + " cup");
            Console.WriteLine("It was made with these ingredients: ");

            return mocha;
        }
    }
}
