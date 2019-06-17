﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieStore.Core.MapCore;
using MovieStore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviestore.Map
{
    public class CategoryMap:CoreMap<Category>
    {
        public new void Configure(EntityTypeBuilder<Category> entity)
        {
            entity.ToTable("dbo.Categories");
            entity.Property(x => x.CategoryName);
            entity.Property(x => x.CategoryDescription);
            entity.HasMany(x => x.Movies).WithOne(x => x.Category).OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);
            
        }
    }
}
