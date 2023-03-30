﻿// <auto-generated />
using System;
using MagicVillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MagicVillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 3, 30, 11, 59, 47, 260, DateTimeKind.Local).AddTicks(8229),
                            Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                            ImageUrl = "C:\\Users\\nerme\\full-stack-learning-projects\\DotNetMastery_RESTAPIS\\ASP.NET MVC\\MagicVilla\\MagicVilla_VillaAPI\\Images\\01.jpg",
                            Name = "Royal Villa",
                            Occupancy = 5,
                            Rate = 220.0,
                            Sqft = 550
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 3, 30, 11, 59, 47, 260, DateTimeKind.Local).AddTicks(8271),
                            Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                            ImageUrl = "C:\\Users\\nerme\\full-stack-learning-projects\\DotNetMastery_RESTAPIS\\ASP.NET MVC\\MagicVilla\\MagicVilla_VillaAPI\\Images\\01.jpg",
                            Name = "Ghoyal Villa",
                            Occupancy = 4,
                            Rate = 120.0,
                            Sqft = 230
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 3, 30, 11, 59, 47, 260, DateTimeKind.Local).AddTicks(8273),
                            Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                            ImageUrl = "C:\\Users\\nerme\\full-stack-learning-projects\\DotNetMastery_RESTAPIS\\ASP.NET MVC\\MagicVilla\\MagicVilla_VillaAPI\\Images\\01.jpg",
                            Name = "Shriya Ghoshal Villa",
                            Occupancy = 3,
                            Rate = 320.0,
                            Sqft = 140
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 3, 30, 11, 59, 47, 260, DateTimeKind.Local).AddTicks(8275),
                            Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                            ImageUrl = "C:\\Users\\nerme\\full-stack-learning-projects\\DotNetMastery_RESTAPIS\\ASP.NET MVC\\MagicVilla\\MagicVilla_VillaAPI\\Images\\01.jpg",
                            Name = "Social Villa",
                            Occupancy = 2,
                            Rate = 310.0,
                            Sqft = 400
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 3, 30, 11, 59, 47, 260, DateTimeKind.Local).AddTicks(8278),
                            Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                            ImageUrl = "C:\\Users\\nerme\\full-stack-learning-projects\\DotNetMastery_RESTAPIS\\ASP.NET MVC\\MagicVilla\\MagicVilla_VillaAPI\\Images\\01.jpg",
                            Name = "Ghost Villa",
                            Occupancy = 1,
                            Rate = 780.0,
                            Sqft = 480
                        },
                        new
                        {
                            Id = 6,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 3, 30, 11, 59, 47, 260, DateTimeKind.Local).AddTicks(8280),
                            Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                            ImageUrl = "C:\\Users\\nerme\\full-stack-learning-projects\\DotNetMastery_RESTAPIS\\ASP.NET MVC\\MagicVilla\\MagicVilla_VillaAPI\\Images\\01.jpg",
                            Name = "KOyal Ka Ghosla Villa",
                            Occupancy = 6,
                            Rate = 447.0,
                            Sqft = 700
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
