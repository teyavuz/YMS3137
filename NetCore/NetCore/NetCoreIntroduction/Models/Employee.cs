using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreIntroduction.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Employee sınıfı içerisinde kullanmak istediğimiz propertyleri tanımladıktan sonra View içerisinde Employee sınıfından bir nesne üreterek bu nesneyi view içerisine gönderip ekranda görüntülenmesini sağlayacağız.
    }
}
