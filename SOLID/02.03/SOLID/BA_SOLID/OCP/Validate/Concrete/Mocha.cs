using BA_SOLID.OCP.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.OCP.Validate.Concrete
{
    public class Mocha : GoodCoffee
    {
        public override decimal GetTotalPrice(decimal amount)
        {
            decimal totalPrice = amount * 14;
            return totalPrice;
        }
    }
}
