using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCFilters.Models.Entity
{
    [Table("Users")]
    public class AppUser
    {
        public int ID { get; set; }
        [MaxLength(25,ErrorMessage ="Ad alanı maksimum 25 karakter olmalı")]
        public string Name { get; set; }
        [MaxLength(50, ErrorMessage = "Ad alanı maksimum 25 karakter olmalı")]
        public string SurName { get; set; }
        [Required(ErrorMessage ="Kullanıcı adı boş geçilemez")]
        public string UserName { get; set; }
        public string Password { get; set; }


    }
}