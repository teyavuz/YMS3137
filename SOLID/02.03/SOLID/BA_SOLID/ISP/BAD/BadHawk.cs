using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.ISP.BAD
{
    public class BadHawk : IBird
    {
        public string Fly()
        {
            return "Şahin iyi uçar.";
        }

        public string Walk()
        {
            return "Bu şahin yürüyebilir";
        }
    }
}
