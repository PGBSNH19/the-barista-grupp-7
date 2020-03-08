using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskin
{
    public class Macchiato : IBeverageRecipe
    {
        public CoffeeCup MakeBeverage(CupSize cupSize)
        {
            CoffeeCup macchiato = new FluentCoffee()
                .ChooseCupSize(cupSize)
                .AddBeans(BeanSort.Robusta, 8)
                .AddWater(10)
                .Heating(waterTemp => waterTemp >= 95)
                .AddMilk(20)
                .AddMilkFoam(5)
                .ToBeverage();

            Console.WriteLine("Your Macchiato is ready!");
            Console.WriteLine();
            Console.WriteLine("You chose a " + cupSize.ToString() + " cup");
            Console.WriteLine("It was made with these ingredients: ");

            return macchiato;
        }
    }
}
