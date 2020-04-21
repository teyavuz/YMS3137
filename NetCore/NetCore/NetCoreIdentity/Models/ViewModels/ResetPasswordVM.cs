using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreIdentity.Models.ViewModels
{
    public class ResetPasswordVM
    {
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez!")]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email boş geçilemez!")]
        [EmailAddress(ErrorMessage = "Lütfen email formatında bir adres girin.")]
        public string Email { get; set; }

        [Display(Name = "Eski Şifre")]
        public string OldPassword { get; set; }

        [Display(Name = "Yeni Şifre")]
        public string NewPassword { get; set; }

        [Display(Name = "Yeni Şifre Tekrar")]
        [Compare("NewPassword",ErrorMessage ="Şifreler uyuşmuyor")]
        public string ConfirmNewPassword { get; set; }
    }
}
