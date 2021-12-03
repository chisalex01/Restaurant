using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Meat
{
    public class Duck : Meat
    {
        public Duck()
            : base(MeatType.Duck)
        {
            Type = MeatType.Duck;
        }
        protected override void AddPrice()
        {
            Price += 40;
        }
    }
}