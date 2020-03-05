using NtierEcommerce.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NtierEcommerce.MODEL.Map
{
    public class AppUserMap:BaseMap<AppUser>
    {
        public AppUserMap()
        {
            ToTable("Users");
            Property(x => x.Address).IsOptional();
            Property(x => x.BirthDate).HasColumnType("datetime2").IsOptional();
            Property(x => x.Name).HasMaxLength(50).IsOptional();
        }
    }
}
