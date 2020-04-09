using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Kaffemaskin
{
    class FluentCoffee : IFluentCoffee
    {

        private CoffeeCup coffeeCup { get; set; }
        private int temperature { get; set; }

        public FluentCoffee()
        {
            coffeeCup = new CoffeeCup();
            temperature = 89;
        }

        public IFluentCoffee ChooseCupSize(CupSize cupSize)
        {
            coffeeCup.CupType = cupSize.ToString();
            return this;
        }

        public IFluentCoffee AddBeans(BeanSort beanSort, int amountIg)
        {
            coffeeCup.Ingredients.Add("Beansort: " + beanSort.ToString() + ", " + amountIg + " grams");
            return this;
        }


        public IFluentCoffee AddWater(int amountIcl)
        {
            coffeeCup.Ingredients.Add("Water in milliliter: " + amountIcl);

            return this;
        }

        // Spy: @BenYtt, Gruppen hade en funktion för att simulera att vattnet värms upp. 
        public IFluentCoffee Heating(Func<int, bool> heatingWater)
        {
            while (heatingWater.Invoke(temperature) == false)
            {
                Thread.Sleep(500);
                temperature++;
                Console.WriteLine("Heating water.. Current temperature: " + temperature + "°C");

            }
            Console.WriteLine("Heating done");
            Thread.Sleep(2000);
            //Console.Clear();

            coffeeCup.Ingredients.Add("Temperature: " + temperature + "°C");

            return this;
        }
        public IFluentCoffee AddMilk(int amountIcl)
        {
            coffeeCup.Ingredients.Add("Milk in milliliter: " + amountIcl);
            return this;
        }

        public IFluentCoffee AddMilkFoam(int amountImsk)
        {
            coffeeCup.Ingredients.Add("Topped with " + amountImsk + " msk of Milk Foam");

            return this;
        }
        public IFluentCoffee AddChocolateSyrup(int amountIcl)
        {
            coffeeCup.Ingredients.Add("Added: " + amountIcl + "cl of Chocolate Syrup");

            return this;
        }

        public CoffeeCup ToBeverage()
        {
            return coffeeCup;
        }
    }
}
