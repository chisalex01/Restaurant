using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Desert
{
    public abstract class Desert : Product
    {
       
        public DesertType Type { get; set; }

        protected Desert(DesertType type)
        {
            this.VAT = 10;
            AddPrice();
        }

        protected abstract void AddPrice();
    }


}
