using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder
{
    public class VisaConcreteBuilder : KrediKartiBuilder
    {
        public VisaConcreteBuilder()
        {
            kart = new KrediKarti();
        }
        public override void BankaAdi()
        {
            kart.BankaAdi = "Garanti Bankası";
        }

        public override void KartLimit()
        {
            kart.KartLimit = 20000;
        }

        public override void KartTipi()
        {
            kart.KartTipi = "Genç  Kart";
        }

        public override void Taksit()
        {
            kart.Taksit = true;
        }
    }
}
