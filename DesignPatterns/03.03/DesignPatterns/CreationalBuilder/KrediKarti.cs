﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder
{
    public class KrediKarti
    {
        public string BankaAdi { get; set; }
        public string KartTipi { get; set; }
        public decimal KartLimit { get; set; }
        public bool Taksit { get; set; }

        public override string ToString()
        {
            return $"{BankaAdi} bankasına ait müşteri {KartTipi} ni kullanmakta ve {KartLimit} limi vardır ayrıca taksit imkanı ise: {Taksit}";
        }
    }
}
