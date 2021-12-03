using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Restaurant.Menu.Pasta
{
    public class SeaFood : Pasta
    {
        public SeaFood()
              : base(PastaType.SeaFood)
        {
            Type = PastaType.SeaFood;
        }

        protected override void AddPrice()
        {
            Price = 31; VAT = (Price * VAT) / 100;
        }
    }
}
