﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskin
{
    public class Espresso : IBeverageRecipe
    {
        public CoffeeCup MakeBeverage(CupSize cupSize)
        {
            CoffeeCup espresso = new FluentCoffee()
                .ChooseCupSize(cupSize)
                .AddBeans(BeanSort.Arabica, 5)
                .AddWater(20)
                .Heating(waterTemp => waterTemp >= 95)
                .ToBeverage();

            Console.WriteLine("Your Espresso is ready!");
            Console.WriteLine();
            Console.WriteLine("You chose a " + cupSize.ToString() + " cup");
            Console.WriteLine("It was made with these ingredients: ");

            return espresso;
        }
    }
}
