﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieStore.Data.Context;

namespace MovieStore.Data.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20190617132851_CreateCoreMovieStore1")]
    partial class CreateCoreMovieStore1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieStore.Entity.AppUser", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddDate");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<int>("Role");

                    b.Property<int>("Status");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UserName");

                    b.HasKey("ID");

                    b.ToTable("AppUsers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AddDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Muhammet",
                            LastName = "Şahmutoğlu",
                            Password = "1234",
                            Role = 1,
                            Status = 0,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "muhammet"
                        },
                        new
                        {
                            ID = 2,
                            AddDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Buğra",
                            LastName = "Tibin",
                            Password = "1234",
                            Role = 2,
                            Status = 0,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "bugra"
                        });
                });

            modelBuilder.Entity("MovieStore.Entity.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddDate");

                    b.Property<string>("CategoryDescription");

                    b.Property<string>("CategoryName");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<int>("Status");

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MovieStore.Entity.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddDate");

                    b.Property<int>("CategoryID");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<string>("Description");

                    b.Property<string>("MovieName");

                    b.Property<int>("Status");

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MovieStore.Entity.Movie", b =>
                {
                    b.HasOne("MovieStore.Entity.Category", "Category")
                        .WithMany("Movies")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
