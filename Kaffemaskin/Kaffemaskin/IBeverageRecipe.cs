using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskin
{
    public interface IBeverageRecipe
    {
        CoffeeCup MakeBeverage(CupSize cupSize);
    }
}
