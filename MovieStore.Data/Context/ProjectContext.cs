using Microsoft.EntityFrameworkCore;
using Moviestore.Map;
using MovieStore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Data.Context
{
    public class ProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=202--11;Database=CoreMovieStore1;UID=sa;PWD=1234;");
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                ID = 1,
                FirstName = "Muhammet",
                LastName = "Şahmutoğlu",
                UserName = "muhammet",
                Password = "1234",
                Role = MovieStore.Core.Enum.Role.Admin

            }, new AppUser
            {

                ID = 2,
                FirstName = "Buğra",
                LastName = "Tibin",
                UserName = "bugra",
                Password = "1234",
                Role = MovieStore.Core.Enum.Role.Member

            });
            modelBuilder.ApplyConfiguration(new AppUserMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new MovieMap());
        }
    }
}
