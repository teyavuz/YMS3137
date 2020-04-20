using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreIdentity.Models.Entity
{
    //Appuser classı IdentityUser classından miras aldığı için bir kullanıcı için gerekli olan bütün propertyleri bünyesine alacaktır. Fakat Id alanı varsayılan olarak string tipte tanımlıdır. Eğer id alanının tipini değiştirmek isterseniz IdentityUser<TKey> kullanabilirsiniz. string olarak kalmasını tavsiye ediyorum! ayrıca dilersek standart olarak oluşturulan propertylere ek olarak AppUser classı içerisinde farklı propertyleri dahil edebiliriz.
    //Örn. DoğumTarihi, cinsiyet vs...
    public class AppUser:IdentityUser
    {
        //public int ID { get; set; }
        //public string UserName { get; set; }
        //public string Email { get; set; }
        //public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }

    }
}
