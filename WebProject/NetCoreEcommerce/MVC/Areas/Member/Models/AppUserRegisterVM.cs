using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Areas.Member.Models
{
    public class AppUserRegisterVM
    {
        [Required(ErrorMessage = "Kullanıcı adı boş olamaz!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email boş olamaz!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre boş olamaz!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre boş olamaz!")]
        [Compare("Password",ErrorMessage ="Şifreler eşleşmiyor.")]
        public string ConfirmPassword { get; set; }
    }
}
