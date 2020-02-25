using System.ComponentModel.DataAnnotations;
namespace WFA_CodeFirst.ORM.Entity
{
    public class Product:BaseEntity
    {
        //public int ID { get; set; }
        //public string ProductName { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public short UnitsInStock { get; set; }

    }
}
