using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalFactory
{
    class Program
    {

        /*
         Factory Method

            Cretional grubuna ait aynı arayüzü kullanan nesnelerin üretiminden sorumlu tsarım desenidir.

            Örneği incelediğimizde;
                ilk olarak MobileApplication isminde bir class oluşturulduğunu görmekteyiz. yani her bir uygulamanın barındığı platform bu class sayesinde oluşacak.
                Daha sonra her bir işletim sistemi için farklı nesneler(classlar) tanımlandı (örn. IPhoneOS, AndroidOS ve WindowsOs) bu nesneler MobileApplication 'den türetilmiştir. Çünkü MobileApplication özünde soyut bir nesnedir. Ancak IPhoneOs classına miras verildiğinde somut hale gelmektedir. 
                Creator isminde oluşturulan nesnenin görevi ise FactoryMetod'un tanımında da bahsedildiği üzere aynı arayüze sahip nesneleri oluşturmakla yükümlü bir class dır. İçerisinde FactoryMethod isminde bir metot oluşturularak parametre imzasına her bir platformu temsil eden ve projede tanımlanan AllMobileOS (enum) almaktadır. Dışarıdan almış olduğu tip ile beraber içerisinde o tipe ait sadece bir adet instance oluşturmaktadır. Detay için Bknz. (Creator.cs içerisinde tanımlı olan FactoryMethod)

             */
        static void Main(string[] args)
        {
            Creator creator = new Creator();

            MobileApplication mobileAndroid = creator.FactoryMethod(AllMobileOS.AndroidOS);
            MobileApplication mobileIphone = creator.FactoryMethod(AllMobileOS.IphoneOs);
            MobileApplication mobileWindows = creator.FactoryMethod(AllMobileOS.WindowsOS);

            mobileAndroid.Platform();
            mobileIphone.Platform();
            mobileWindows.Platform();

            Console.Read();
        }
    }
}
