using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieStore.Core.MapCore;
using MovieStore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviestore.Map
{
   public class AppUserMap:CoreMap<AppUser>
    {

        public new void Configure(EntityTypeBuilder<AppUser> entity)
        {
            entity.ToTable("dbo.Users");
            entity.Property(x => x.FirstName).IsRequired(false);
            entity.Property(x => x.LastName).IsRequired(false); ;
            entity.Property(x => x.UserName).IsRequired(true);
            entity.Property(x => x.Role).IsRequired(true);
            entity.Property(x => x.Password).IsRequired(true);
            
            
        }
    }
}
