using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_CodeFirst.ORM.Entity
{
    //Bu class ortak olan class'lara miras verecek ve ortak sütunların oluşturulmasına yardımcı olacaktır. Bu yüzden Abstract (Soyut) tanımlandı. Bu classın tablo haline gelmesini değil diğer classlara bünyesindeki özellikleri aktrabilmesi için tanımlandı.
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
