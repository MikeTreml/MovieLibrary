﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPISample.Data;

namespace WebAPISample.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20201031230757_initial1")]
    partial class initial1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPISample.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Actors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Actors = "",
                            Director = "Martin Scorsese",
                            Genre = "Drama",
                            ImageURL = "https://i.pinimg.com/originals/86/f9/d1/86f9d1a47d81531f1e12e343d7a6ae0e.png",
                            Rating = "",
                            Summary = "",
                            Title = "The Departed",
                            Year = ""
                        },
                        new
                        {
                            MovieId = 2,
                            Actors = "",
                            Director = "Christopher Nolan",
                            Genre = "Drama",
                            ImageURL = "https://i.pinimg.com/originals/28/1d/03/281d03d7e0fae42cf27ebf513c00c6eb.jpg",
                            Rating = "",
                            Summary = "",
                            Title = "The Dark Knight",
                            Year = ""
                        },
                        new
                        {
                            MovieId = 3,
                            Actors = "",
                            Director = "Christopher Nolan",
                            Genre = "Drama",
                            ImageURL = "https://i.pinimg.com/originals/77/bb/6d/77bb6d11954d639e10affff6565b213a.jpg",
                            Rating = "",
                            Summary = "",
                            Title = "Inception",
                            Year = ""
                        },
                        new
                        {
                            MovieId = 4,
                            Actors = "",
                            Director = "David Gordon Green",
                            Genre = "Comedy",
                            ImageURL = "https://i.pinimg.com/originals/8c/f2/4a/8cf24aa1b78365ea504eb5948470bfd4.jpg",
                            Rating = "",
                            Summary = "",
                            Title = "Pineapple Express",
                            Year = ""
                        },
                        new
                        {
                            MovieId = 5,
                            Actors = "",
                            Director = "John McTiernan",
                            Genre = "Action",
                            ImageURL = "https://2.bp.blogspot.com/-LrHDd4vdHHw/Tw6fI1XEoRI/AAAAAAAAAPY/ov2jgvNQt4k/w1200-h630-p-k-no-nu/poster-die-hard1resize.jpg",
                            Rating = "",
                            Summary = "",
                            Title = "Die Hard",
                            Year = ""
                        },
                        new
                        {
                            MovieId = 6,
                            Actors = "",
                            Director = "",
                            Genre = "",
                            ImageURL = "",
                            Rating = "",
                            Summary = "",
                            Title = "",
                            Year = ""
                        },
                        new
                        {
                            MovieId = 7,
                            Actors = "",
                            Director = "",
                            Genre = "",
                            ImageURL = "",
                            Rating = "",
                            Summary = "",
                            Title = "",
                            Year = ""
                        },
                        new
                        {
                            MovieId = 8,
                            Actors = "",
                            Director = "",
                            Genre = "",
                            ImageURL = "",
                            Rating = "",
                            Summary = "",
                            Title = "",
                            Year = ""
                        },
                        new
                        {
                            MovieId = 9,
                            Actors = "",
                            Director = "",
                            Genre = "",
                            ImageURL = "",
                            Rating = "",
                            Summary = "",
                            Title = "",
                            Year = ""
                        },
                        new
                        {
                            MovieId = 10,
                            Actors = "",
                            Director = "",
                            Genre = "",
                            ImageURL = "",
                            Rating = "",
                            Summary = "",
                            Title = "",
                            Year = ""
                        },
                        new
                        {
                            MovieId = 11,
                            Actors = "",
                            Director = "",
                            Genre = "",
                            ImageURL = "",
                            Rating = "",
                            Summary = "",
                            Title = "",
                            Year = ""
                        },
                        new
                        {
                            MovieId = 12,
                            Actors = "",
                            Director = "",
                            Genre = "",
                            ImageURL = "",
                            Rating = "",
                            Summary = "",
                            Title = "",
                            Year = ""
                        },
                        new
                        {
                            MovieId = 13,
                            Actors = "",
                            Director = "",
                            Genre = "",
                            ImageURL = "",
                            Rating = "",
                            Summary = "",
                            Title = "",
                            Year = ""
                        },
                        new
                        {
                            MovieId = 14,
                            Actors = "",
                            Director = "",
                            Genre = "",
                            ImageURL = "",
                            Rating = "",
                            Summary = "",
                            Title = "",
                            Year = ""
                        },
                        new
                        {
                            MovieId = 15,
                            Actors = "",
                            Director = "",
                            Genre = "",
                            ImageURL = "",
                            Rating = "",
                            Summary = "",
                            Title = "",
                            Year = ""
                        });
                });
#pragma warning restore 612, 618
        }
    }
}