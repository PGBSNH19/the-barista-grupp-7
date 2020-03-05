﻿using System;
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

            return this;
        }

        public IBeverage ToBeverage()
        {
            return this;
        }
    }

    interface IFluentEspresso
    {
        IFluentEspresso AddWater();

        IFluentEspresso AddBeans();

        IFluentEspresso AddMilk();

        IBeverage ToBeverage();

    }
}
