using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierEcommerce.MODEL.Map
{
   public class BaseMap<T>:EntityTypeConfiguration<T> where T:class
    {

    }
}
