﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskin
{
    public class Cappuccino : IBeverageRecipe
    {
        public CoffeeCup MakeBeverage(CupSize cupSize)
        {
            CoffeeCup cappuccino = new FluentCoffee()
                .ChooseCupSize(cupSize)
                .AddBeans(BeanSort.Columbia, 6)
                .AddWater(15)
                .Heating(waterTemp => waterTemp >= 95)
                .AddMilk(10)
                .AddMilkFoam(6)
                .ToBeverage();

            Console.WriteLine("Your Cappuccino is ready!");
            Console.WriteLine();
            Console.WriteLine("You chose a " + cupSize.ToString() + " cup");
            Console.WriteLine("It was made with these ingredients: ");

            return cappuccino;
        }
    }
}
