using System;
using System.Collections.Generic;

namespace Kaffemaskin
{
    interface ICoffee
    {
        string MakeCoffee();

    }

    class CoffeePart
    {
        public string Name {get; set;}
        public bool gotMilk {get; set;}
        public int amount {get; set;}
        public string type {get; set;}
        public int size {get; set;} 
    }

    class Coffee : ICoffee 
    {
        private IEnumerable<CoffeePart> Coffee {get;set;}
        private string Name {get; set;}


        public Coffee (string name)
        {
            CoffeeParts = new List<CoffeePart>();
            Name = name;
        }

        public ICoffee Milk(bool gotMilk)
        {
            ((List<CoffeePart>)CoffeeParts).Add(new CoffeePart(){Name = "Milk", gotMilk = true});
            return this;
        }

        public ICoffee Water(int amount)
        {
            ((List<CoffeePart>)CoffeeParts).Add(new CoffeePart(){Name = "Water", amount = 30});
            return this;
        }

        public ICoffee BeanRoast(string type)
        {
            ((List<CoffeePart>)CoffeeParts).Add(new CoffeePart(){Name = "Roast", type="medium"});
            return this;
        }

        public ICoffee Size(string size)
        {
            ((List<CoffeePart>)CoffeeParts).Add(new CoffeePart(){Name = "Size", size="medium"});
            return this;
        }

        public void MakeCoffee()
        {
            foreach (var cp in CoffeParts)
            {
                Console.WriteLine($"{Name} has {cp.gotMilk} {cp.Name} {cp.amount} {cp.type} {cp.size}");
            }
        }
    }


    class Latte : ICoffee
    {
        public int water = 20;
        public string BeanRoast = "medium";
        public bool GotMilk = true;
        public string MakeCoffee()
        {
            string make = "Du har gjort en latte";
            return make;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {


            //new Coffee("Latte")
            //        .GotMilk()
            //        .Roast()
            //        .Size()
            //    .MakeCoffe();
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
