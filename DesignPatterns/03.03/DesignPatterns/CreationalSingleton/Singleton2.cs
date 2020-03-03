using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalSingleton
{
    public class Singleton2
    {
        private Singleton2()
        {

        }
        private static Singleton2 sinif;
        public static Singleton2 Sinif
        {
            get
            {
                if (sinif == null)
                {
                    sinif = new Singleton2();
                }
                return sinif;
            }
            
        }

        public string Get()
        {
            return "instance alındı";
        }
    }
}
