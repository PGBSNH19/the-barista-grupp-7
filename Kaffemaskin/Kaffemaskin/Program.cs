using System;

namespace Kaffemaskin
{
    class Coffe : ICoffe 
    {
        private ICoffe<CoffePart> CoffeParts {get; set; }
        private string Name {get; set; }
    
        public Coffe (string name)
        {
            CoffeParts = new List<CoffePart>();
            Name = name;
        }
    
    
    }

    interface ICoffee
    {
        ICoffee GotMilk();
        ICoffee Size(int );

    }


    class Beans
    {
        string[] type = { "ljus", "mellan", "mörk" };
        string[] country = { "Colombia", "Central America", "Arabica" };
        bool eko;
        string[] manufacturer = {"Gevalia", "Lövbergs Lila", "Starbucks" };

    }
    class Machine
    {
        string sort;
        string bean;
        int temp;
        int[] water = {2,4,6};
        bool milk;
        
    }
    class Cup
    {
        string[] size = { "small", "medium", "large" };
        string[] sort = { "latte", "espresso", "black", "cappucino" };

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
