using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_CodeFirstSamples.ORM.Entity.ManyToMany
{
    public class Student
    {
        //bir öğrencinin birden fazla öğretmeni olur.
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentSurName { get; set; }
        //Mapping
        public virtual List<Teacher> Teachers { get; set; }

    }
}
