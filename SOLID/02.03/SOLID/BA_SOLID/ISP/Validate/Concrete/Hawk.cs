using BA_SOLID.ISP.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.ISP.Validate.Concrete
{
    public class Hawk : IFliyingBird,IFlightlessBird
    {
        public string Fly()
        {
            throw new NotImplementedException();
        }

        public string Walk()
        {
            throw new NotImplementedException();
        }
    }
}
