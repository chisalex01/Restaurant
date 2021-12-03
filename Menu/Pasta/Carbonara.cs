using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Pasta
{
    public class Carbonara : Pasta
    {
        public Carbonara()
              : base(PastaType.Carbonara)
        {
            Type = PastaType.Carbonara;
        }

        protected override void AddPrice()
        {
            Price = 26; VAT = (Price * VAT) / 100;
        }
    }
}
