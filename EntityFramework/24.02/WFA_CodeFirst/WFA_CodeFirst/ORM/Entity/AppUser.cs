using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WFA_CodeFirst.ORM.Entity
{
    public class AppUser:BaseEntity
    {
        //Attribute kullanarak propertyleri kolon haline getirirken belli başlı kısıtlamalar kullanabiliriz.
        [MaxLength(30)]
        public string LastName { get; set; }
        [NotMapped]
        public string FullName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(LastName))
                {
                    return Name;
                }
                else
                {
                    return Name + " " + LastName;
                }
            }
        }
        [MaxLength(25)]
        [Required]

        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool Gender { get; set; }

    }
}
