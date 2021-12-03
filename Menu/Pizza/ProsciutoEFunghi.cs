﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Pizza
{
    public class ProsciutoEFunghi : Pizza
    {
        public ProsciutoEFunghi()
            : base(PizzaType.ProsciutoEFunghi)
        {
            Type = PizzaType.ProsciutoEFunghi;
        }
        protected override void AddPrice()
        {
            Price = 20; VAT = (Price * VAT) / 100;
        }
    }
}
