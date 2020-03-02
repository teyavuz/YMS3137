using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.OCP.Validate.Abstract
{
    public abstract class GoodCoffee
    {
        public abstract decimal GetTotalPrice(decimal amount);
    }
}
