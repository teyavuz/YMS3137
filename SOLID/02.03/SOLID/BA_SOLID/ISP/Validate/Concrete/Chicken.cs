using BA_SOLID.ISP.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.ISP.Validate.Concrete
{
    public class Chicken : IFlightlessBird
    {
        public string Walk()
        {
            return "Gezen tavuk";
        }
    }
}
