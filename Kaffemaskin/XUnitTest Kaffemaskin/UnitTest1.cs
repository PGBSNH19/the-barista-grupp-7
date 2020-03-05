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
            IBeverage espresso = new Espresso().AddBeans(new Bean).AddWater();
            

            

        }
    }
}
