using System;
using System.Collections.Generic;

namespace Kaffemaskin
{
    interface ICoffee
    {
        string MakeCoffee();
    }

    class Latte : ICoffee
    {
        //vatten
        //bönor
        //mjölk
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
