using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder
{
    public class AmericanExpressConcreteBuilder : KrediKartiBuilder
    {
        public AmericanExpressConcreteBuilder()
        {
            kart = new KrediKarti();
        }
        public override void BankaAdi()
        {
            kart.BankaAdi = "Garanti Bankası";
        }

        public override void KartLimit()
        {
            kart.KartLimit = 100000;
        }

        public override void KartTipi()
        {
            kart.KartTipi = "Apex";
        }

        public override void Taksit()
        {
            kart.Taksit = false;
        }
    }
}
