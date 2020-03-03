using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalSingleton
{
    public class Singleton
    {
        //constructor private yapılarak bu sınıf dışından instance alınmasını engelliyoruz.
       private Singleton()
        {   

        }

        
        private static Singleton nesne = new Singleton();
        /*oluşturulan static nesnenin dışarıdan erişilmesini sağlamak için property tanımlıyoruz.*/
        public static Singleton Nesne
        {
            get
            {
                return nesne;
            }
        }

        public static Singleton Nesne2()
        {
            return nesne;
        }
        public int Topla(int s1, int s2)
        {
            return s1 + s2;
        }
    }
}
