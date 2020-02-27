using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierMovieProject.DAL.ORM.Entity
{
    public class Movie
    {
           //Her bir filmin .....'sı olur.
   
        public int ID { get; set; }
        [MaxLength(50)]
        public string MovieName { get; set; }
        public string MovieLanguage { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int? Duration { get; set; }

        public string MoviePosterPath { get; set; }

        //Map

        //Bir filmin birden fazla kategorisi olur.
        public virtual List<MovieCategory> MovieCategories { get; set; }
        public virtual List<MovieActor> MovieActors { get; set; }

    }
}
