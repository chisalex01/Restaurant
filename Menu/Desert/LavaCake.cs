using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Desert
{
    public class LavaCake : Desert
    {
        public LavaCake()
            : base(DesertType.LavaCake)
        {
            Type = DesertType.LavaCake;
        }
        protected override void AddPrice()
        {
            Price = 20; VAT = (Price * VAT) / 100;
        }
    }
}