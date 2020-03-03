using BA_SOLID.DIP.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.DIP.Validate.Concrete
{
    public class Fish : IProduct
    {
        public string GetCookingInstructions()
        {
            return "Balık böyle yapılır";
        }
    }
}
