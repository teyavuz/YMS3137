using Microsoft.AspNetCore.Identity;
using System;

namespace DAL.Entity
{
    public class AppUser:IdentityUser<Guid>
    {
        //install-package Microsoft.AspNetCore.Identity.EntityFrameworkCore

    }
}