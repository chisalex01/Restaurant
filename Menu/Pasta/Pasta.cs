using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Pasta
{
    public abstract class Pasta : Product
    {
        public PastaType Type { get; set; }

        protected Pasta(PastaType type)
        {
            this.VAT = 9;
            ;
            AddPrice();
        }

        protected abstract void AddPrice();
    }


}

