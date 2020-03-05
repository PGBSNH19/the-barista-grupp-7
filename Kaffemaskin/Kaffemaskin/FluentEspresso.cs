using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskin
{
    class FluentEspresso : IFluentEspresso
    {
        public IFluentEspresso AddBeans()
        {
            throw new NotImplementedException();
        }

        public IFluentEspresso AddMilk()
        {
            throw new NotImplementedException();
        }

        public IFluentEspresso AddWater(int amount)
        {
            string size;
            if (amount == 20)
            {
                size = "small";
            }
            else if (amount == 40)
            {
                size = "medium";
            }
            else if (amount == 60)
            {
                size = "large";
            }

            return size;

        }

        public IBeverage ToBeverage()
        {
            throw new NotImplementedException();
        }
    }

    interface IFluentEspresso
    {
        IFluentEspresso AddWater(int amount);

        IFluentEspresso AddBeans();

        IFluentEspresso AddMilk();

        IBeverage ToBeverage();

    }
}
