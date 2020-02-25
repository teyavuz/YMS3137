using System.ComponentModel.DataAnnotations;
namespace WFA_CodeFirst.ORM.Entity
{
    public class Category:BaseEntity
    {
        //public int ID { get; set; }
        //public string CategoryName { get; set; }
        [MaxLength(150)]
        public string Description { get; set; }

    }
}
