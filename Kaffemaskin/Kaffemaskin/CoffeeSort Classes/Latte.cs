using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskin
{
    public class Latte : IBeverageRecipe
    {
        public CoffeeCup MakeBeverage(CupSize cupSize)
        {
            CoffeeCup latte = new FluentCoffee()
                .ChooseCupSize(cupSize)
                .AddBeans(BeanSort.Robusta, 5)
                .AddWater(10)
                .AddMilk(20)
                .Heating(waterTemp => waterTemp >= 95)
                .ToBeverage();

            Console.WriteLine("Your Latte is ready!");
            Console.WriteLine();
            Console.WriteLine("You chose a " + cupSize.ToString() + " cup");
            Console.WriteLine("It was made with these ingredients: ");

            return latte;
        }
    }
}
