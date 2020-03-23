using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelOOPTekrar
{
    public class Ayakkabi:Product,IProduct
    {
        //bir ayakkabının ..... sı olur.
        public string Malzeme { get; set; }
        public Tip Tip { get; set; }

        public string AddProduct()
        {
            return "Ürün Eklendi";
        }

        public override string KDVHesapla()
        {
            return "Ayakkabı kdv oranı";
        }

    }
}
