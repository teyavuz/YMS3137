using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenelOOPTekrar
{
    public abstract class Product
    {

        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

        private short _unitsinstock;
        public short Unitsinstock
        {
            get
            {
                return _unitsinstock;
            }
            set
            {
                if (value < 200)
                {
                    MessageBox.Show("200 den küçük bir değer girilemez.");
                }
                else
                {
                    _unitsinstock = value;
                }
            }

        }

        //public virtual string KDVHesapla()
        //{
        //    return "KDV oranı hesaplandı";
        //}

        public abstract string KDVHesapla()
        {
            return "KDV Oranı";
        }



        //OOP 4 Temel Prensibi

        /*
         Inheritance => Miras
         Polymorphism =>Çok biçimlilik. (isteğe bağlı ezme işlemi)
         Abstraction => Soyutlama (zorunlu ezme işlemi)
         Encapsulation => Kapsulleme
         */

    }
}
