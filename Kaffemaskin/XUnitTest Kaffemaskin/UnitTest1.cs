using System;
using Xunit;
using Kaffemaskin;

namespace XUnitTest_Kaffemaskin
{
    public class UnitTest1
    {
        [Fact]
        public void MakeBeverage()
        {
            IBeverage espresso = new Espresso().AddBeans(new Bean()
            {
                AmountInG = 5,
                Sort = CoffeeSorts.Robusta
            }).AddWater(30).Validate(e => e.Temperature > 90)
            .ToBeverage();
            

        }
    }
}
