using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalFactory
{
    public class Creator
    {
        public MobileApplication FactoryMethod(AllMobileOS osType)
        {
            MobileApplication ma = null;
            switch (osType)
            {
                case AllMobileOS.IphoneOs:
                    ma = new IPhoneOS();
                    break;
                case AllMobileOS.AndroidOS:
                    ma = new AndroidOS();
                    break;
                case AllMobileOS.WindowsOS:
                    ma = new WindowsOS();
                    break;
            }
            return ma;
        }
    }
}
