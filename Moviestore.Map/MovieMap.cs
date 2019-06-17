using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieStore.Core.MapCore;
using MovieStore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviestore.Map
{
    public class MovieMap:CoreMap<Movie>
    {
        public new void Configure(EntityTypeBuilder<Movie> entity)
        {
            entity.ToTable("dbo.Movies");
            entity.Property(x => x.MovieName);
            entity.Property(x => x.Description);
            entity.HasOne(x => x.Category).WithMany(x => x.Movies).OnDelete(DeleteBehavior.Cascade);
            
            

        }
    }
}
