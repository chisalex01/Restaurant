using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant;

namespace Restaurant.Menu.Pizza
{
   public abstract class Pizza : Product
    {
        
        public PizzaType Type { get; set; }
       
    protected Pizza(PizzaType type)
    { 
            this.VAT = 9;
            ;
            AddPrice();
        }

        protected abstract void AddPrice();
    }

    

}
