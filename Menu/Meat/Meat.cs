using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Meat
{
    public abstract class Meat : Product
    { 
        
        public MeatType Type { get; set; }
        public SideDish.SideDish SideDishType{ get; set; } = SideDish.SideDishFactory.MakeSideDish(SideDish.SideDishType.FrenchFries);
        public CookType CookType { get; set; } = CookType.rareCooked;
        
        protected Meat(MeatType type)
        {
            Price = SideDishType.Price;
            this.VAT = 9;
            AddPrice();
        }

        public Meat ChangeCookType(CookType cookType)
        {
            CookType = cookType;

            return this;
        }

        public Meat changeSideDish(SideDish.SideDish sideDishType)
        {
            Price = Price - SideDishType.Price;
            SideDishType = sideDishType;
            Price = Price + sideDishType.Price;
            return this; 
        }

        public Meat RemoveSideDish() {
            Price = Price - SideDishType.Price;
            SideDishType = null;
            ;
            return this;
        }
        protected abstract void AddPrice();
    }


}

public enum CookType
{
    rareCooked, 
    mediumCooked,
    wellCooked
}

