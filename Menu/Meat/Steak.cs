using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Meat
{
    public class Steak : Meat
    {
        public Steak()
            : base(MeatType.Steak)
        {
            Type = MeatType.Steak;
        }

        protected override void AddPrice()
        {
            Price += 20;
        }
    }
}
