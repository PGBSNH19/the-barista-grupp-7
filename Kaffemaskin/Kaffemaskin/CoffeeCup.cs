using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskin
{
    public class CoffeeCup
    {
        public List<string> Ingredients { get; }
        public string CupType { get; set; }

        public CoffeeCup()
        {
            Ingredients = new List<string>();
        }

        internal void Print()
        {

            foreach (var item in Ingredients)
            {
                Console.WriteLine(item);
            }
        }
    }
}
