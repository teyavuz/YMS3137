using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.OCP.Bad
{
    public enum CoffeeType
    {
        Latte,//8 TL
        Americano,//12 TL
        Mocha,//14 TL
    }
    public class BadCoffee
    {
        public decimal GetTotalPrice(decimal amount, CoffeeType coffeeType)
        {
            decimal totalPrice = 0;
            if (coffeeType == CoffeeType.Latte)
            {
                totalPrice = amount * 8;
            }
            else if (coffeeType == CoffeeType.Americano)
            {
                totalPrice = amount * 12;
            }
            else if (coffeeType == CoffeeType.Mocha)
            {
                totalPrice = amount *14;

            }

            return totalPrice;
        }
    }
}
