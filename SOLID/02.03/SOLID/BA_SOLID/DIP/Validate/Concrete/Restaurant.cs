using BA_SOLID.DIP.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.DIP.Validate.Concrete
{
    public class Restaurant
    {
        private List<IProduct> products;

        public Restaurant(List<IProduct> _product)
        {
            products = _product;
        }

        public string GenerateInstructions()
        {
            string instructions = string.Empty;
            foreach (var item in products)
            {
                instructions += item.GetCookingInstructions();
            }
            return instructions;
        }


    }
}
