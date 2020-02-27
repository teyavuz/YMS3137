using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NTierMovieProject.DAL.ORM.Entity
{
    public class Category
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string CategoryName { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }

        public virtual List<MovieCategory> MovieCategories { get; set; }

    }
}
