using BA_SOLID.OCP.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.OCP.Validate.Concrete
{
    public class Latte : GoodCoffee
    {
        public override decimal GetTotalPrice(decimal amount)
        {
            decimal totalPrice = amount * 8;
            return totalPrice;
        }
    }
}
