using System.Collections.Generic;
namespace NetCoreSample.Models
{
    public class Person
    {
        public static List<Person> person=new List<Person>(){
            new Person{PersonID=1,PersonName="Bilal",PersonSurName="Kırkgül"},
            new Person{PersonID=2,PersonName="Cem",PersonSurName="Onur"},
            new Person{PersonID=3,PersonName="İhsan",PersonSurName="Açan"}
        };
        public int PersonID { get; set; }
        public string PersonName { get; set; }
        public string PersonSurName { get; set; }

    }
}