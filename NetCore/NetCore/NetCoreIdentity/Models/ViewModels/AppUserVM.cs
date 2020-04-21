using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreIdentity.Models.ViewModels
{
    public class AppUserVM
    {
        [Required(ErrorMessage ="Kullanıcı adı boş geçilemez!")]
        [Display(Name ="Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email boş geçilemez!")]
        [EmailAddress(ErrorMessage ="Lütfen email formatında bir adres girin.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi tekrar yazın")]
        [Display(Name = "Şifre Tekrar")]
        [Compare("Password",ErrorMessage ="Şifreler aynı değil")]
        public string ConfirmPassword { get; set; }
        

    }
}
