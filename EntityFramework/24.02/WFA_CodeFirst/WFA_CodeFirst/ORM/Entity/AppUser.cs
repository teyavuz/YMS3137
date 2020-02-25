using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WFA_CodeFirst.ORM.Entity
{
    public class AppUser:BaseEntity
    {
        //Attribute kullanarak propertyleri kolon haline getirirken belli başlı kısıtlamalar kullanabiliriz.

            //MaxLength default oalrak nvarchar(Max) olan stringleri belirtilen sayı kadar yer alabileceğini belirleyecektir.
        [MaxLength(30)]
        public string LastName { get; set; }
        //NotMapped entity içerisinde var olmasına rağmen database'de tabloda bir sütun olarak oluşturulmayacaktır.
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
        //Reference type olmasına rağmen Required denilerek "Not Null" bir sütun oluşturuldu.
        [MaxLength(25)]
        [Required]

        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool Gender { get; set; }

    }
}
