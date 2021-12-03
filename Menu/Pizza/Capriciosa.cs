using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Pizza
{
    public class Capriciosa : Pizza
    {
        public Capriciosa()
            : base(PizzaType.Capriciosa)
        {
            Type = PizzaType.Capriciosa;
        }

        protected override void AddPrice()
        {
            Price = 25; VAT = (Price * VAT) / 100;
        }
    }
}
