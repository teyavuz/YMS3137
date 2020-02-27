using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierMovieProject.DAL.ORM.Entity
{
    public class Actor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string ActorImagePath { get; set; }

        public virtual List<MovieActor> MovieActors { get; set; }

    }
}
