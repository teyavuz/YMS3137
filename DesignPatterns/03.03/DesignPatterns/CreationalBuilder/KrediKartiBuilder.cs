using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder
{
    public abstract class KrediKartiBuilder
    {
        protected KrediKarti kart;

        public KrediKarti Kart
        {
            get
            {
                return kart;
            }
        }

        public abstract void BankaAdi();
        public abstract void KartTipi();
        public abstract void KartLimit();
        public abstract void Taksit();



    }
}
