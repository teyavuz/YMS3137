using BA_SOLID.OCP.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.OCP.Validate.Concrete
{
    public class Americano : GoodCoffee
    {
        public override decimal GetTotalPrice(decimal amount)
        {
            decimal totalPrice = amount * 12;
            return totalPrice;

        }
    }
}
