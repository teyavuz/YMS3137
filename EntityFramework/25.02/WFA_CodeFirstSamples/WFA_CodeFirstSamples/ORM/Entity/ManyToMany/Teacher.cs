using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_CodeFirstSamples.ORM.Entity.ManyToMany
{
    public class Teacher
    {
        //bir öğretmenin birden fazla öğrencisi olur.
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurName { get; set; }
        //Mapping
        public virtual List<Student> Students { get; set; }
    }
}
