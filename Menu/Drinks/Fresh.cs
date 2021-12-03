using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Restaurant.Menu.Drinks
{
    public class Fresh : Drink
    {
        public Fresh()
              : base(DrinkType.Fresh)
        {
        }
        protected override void AddPrice()
        {
            Price = 5; VAT = (Price * VAT) / 100;
        }
    }
}
