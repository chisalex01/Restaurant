﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.SideDish
{
    public class FrenchFries : SideDish
    {
        public FrenchFries()
              : base(SideDishType.FrenchFries)
        {
            Type = SideDishType.FrenchFries;
        }

        protected override void AddPrice()
        {
            Price = 10; VAT = (Price * VAT) / 100;
        }
    }
}
