using System;
using System.Collections.Generic;

namespace Kaffemaskin
{
    interface IBeverage
    {
        IBeverage AddMilk(bool gotMilk);
        IBeverage AddWater(int amount);
        IBeverage AddBeans(string type);
  
        void MakeCoffee(); 
    }

    class CoffeePart
    {
        public string Name {get; set;}
        public bool gotMilk {get; set;}
        public int amount {get; set;}
        public string type {get; set;}
        public int size {get; set;} 
    }

    class Espresso : IBeverage 
    {
        private IEnumerable<CoffeePart> CoffeeParts {get;set;}
        private string Name {get; set;}


        public Espresso (string name)
        {
            CoffeeParts = new List<CoffeePart>();
            Name = name;
        }

        public IBeverage AddMilk(bool gotMilk)
        {
            ((List<CoffeePart>)CoffeeParts).Add(new CoffeePart(){Name = "Milk", gotMilk = true});
            return this;
        }

        public IBeverage AddWater(int amount)
        {
            ((List<CoffeePart>)CoffeeParts).Add(new CoffeePart(){Name = "Water", amount = 30});
            return this;
        }

        public IBeverage AddBeans(string type)
        {
            ((List<CoffeePart>)CoffeeParts).Add(new CoffeePart(){Name = "Roast", type="medium"});
            return this;
        }

        public void MakeCoffee()
        {
            foreach (var cp in CoffeeParts)
            {
                Console.WriteLine($"{Name} has {cp.gotMilk} {cp.Name} {cp.amount} {cp.type} {cp.size}");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {


            new Espresso("Latte")
                    .Milk(true)
                    .BeanRoast("Dark")
                    .Size(20)
                .MakeCoffee();
        }
    }
    //class Coffee : ICoffee 
    //{
    //    public ICoffee GotMilk();
    //    private IEnumerable<CoffeePart> CoffeParts {get; set; }
    //    private string Name {get; set; }
    
    //    public Coffee (string name)
    //    {
    //        CoffeParts = new List<CoffeePart>();
    //        Name = name;
    //    }

    //}

    //interface ICoffee
    //{
    //    ICoffee GotMilk();
    //    ICoffee Size(int number);
    //    ICoffee AddWater(int number);

    //}

    //class CoffeePart
    //{

    //}


    //class Beans
    //{
    //    string[] roast = { "ljus", "mellan", "mörk" };
    //    string[] country = { "Colombia", "Central America", "Arabica" };
    //    bool eko;
    //    string[] manufacturer = {"Gevalia", "Lövbergs Lila", "Starbucks" };

    //}
    //class Machine
    //{
    //    string sort;
    //    string bean;
    //    int temp;
    //    int[] water = {2,4,6};
    //    bool milk;
        
    //}
    //class Cup
    //{
    //    string[] size = { "small", "medium", "large" };
    //    string[] sort = { "latte", "espresso", "black", "cappucino" };

    //}
}
