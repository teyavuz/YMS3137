using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreIntroduction.Models
{
    public class User
    {
        [Display(Name ="Kullanıcı Adı")]
        public string UserName { get; set; }
        [Display(Name = "Şifre")]
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
