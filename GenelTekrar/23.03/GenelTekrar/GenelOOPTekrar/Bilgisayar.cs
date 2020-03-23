using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelOOPTekrar
{
    public class Bilgisayar:Product
    {
        //public int ID { get; set; }
        public string Marka { get; set; }
        public string EkranKartiMarkasi { get; set; }
        public string Islemci { get; set; }

        public override string KDVHesapla()
        {
            return "Bilgisayar kdv oranı %18";
        }
    }
}
