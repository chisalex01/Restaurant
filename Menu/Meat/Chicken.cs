using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Meat
{
    public class Chicken : Meat
    {
        public Chicken()
            : base(MeatType.Chicken)
        {
            Type = MeatType.Chicken;
        }
        protected override void AddPrice()
        {
            Price += 10;
        }


    }
}
