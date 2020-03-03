using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             tasarım desenleri arasında creational grubuna ait en popüler yapılardan biridir. Uluslararası standartlarda kullanım oranı yaklaşık %80'dir. esas amaç; her daim nesnenin kullanım süresi boyunca bir nesnenin bir kez oluşturulup defalarca farklı konumlarda kullanılmasını sağlamaktır.
             */

            //Singleton singleton = new Singleton();
            //int toplam1=singleton.Topla(3, 5);
            //int toplam2 = singleton.Topla(5, 3);
            //int toplam3 = singleton.Topla(10, 3);
            //int toplam4 = singleton.Topla(25, 3);

            //Console.WriteLine(toplam1.ToString());
            //Console.Read();

            //int toplam1= Singleton.Nesne.Topla(3, 5);
            // int toplam2 = Singleton.Nesne.Topla(3, 5);
            // int toplam3 = Singleton.Nesne.Topla(3, 5);
            // int toplam4 = Singleton.Nesne.Topla(3, 5);

            // Singleton s = Singleton.Nesne2();
            //int sonuc= s.Topla(15, 6);
            // int sonuc2 = s.Topla(25, 6);

            Singleton2 singleton2 = Singleton2.Sinif;
            Console.WriteLine(singleton2.Get());
            Console.WriteLine(singleton2.Get());
        }
    }
}
