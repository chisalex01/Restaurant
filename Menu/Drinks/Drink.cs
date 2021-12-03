using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Menu.Drinks;

namespace Restaurant.Menu.Drinks
{
    public abstract class Drink : Product
    {   
       
        public DrinkType Type { get; set; }

        protected Drink(DrinkType type)
        {
            this.VAT = 9;
            AddPrice();
        }

        public Drink CantMade()
        {
            return this;
        }
        protected abstract void AddPrice();
    }


}