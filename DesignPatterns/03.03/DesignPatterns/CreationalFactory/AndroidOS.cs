using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalFactory
{
    public class AndroidOS : MobileApplication
    {
        public override void Platform()
        {
            Console.WriteLine("Bu uygulama Android cihazlarda çalışır");

        }
    }
}
