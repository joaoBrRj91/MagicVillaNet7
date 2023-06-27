﻿// <auto-generated />
using System;
using MagicVilla.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230627161518_SeedVillaTable")]
    partial class SeedVillaTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla.API.Models.Villa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Amenity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodVilla")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UodatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("imageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = new Guid("464f8841-b2fa-41bb-9707-61f17240549b"),
                            Amenity = "",
                            CodVilla = "ROYAL VILLA-5721420465042486550",
                            CreatedDate = new DateTime(2023, 6, 27, 13, 15, 18, 507, DateTimeKind.Local).AddTicks(5940),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            Name = "Royal Villa",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UodatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            imageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg"
                        },
                        new
                        {
                            Id = new Guid("bdaf817a-b8a7-47c0-be84-557ca227641e"),
                            Amenity = "",
                            CodVilla = "PREMIUM POOL VILLA-4389313556231890347",
                            CreatedDate = new DateTime(2023, 6, 27, 13, 15, 18, 507, DateTimeKind.Local).AddTicks(6020),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            Name = "Premium Pool Villa",
                            Occupancy = 4,
                            Rate = 300.0,
                            Sqft = 550,
                            UodatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            imageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg"
                        },
                        new
                        {
                            Id = new Guid("8c1db540-b036-4c7a-82d9-05022e41ce8c"),
                            Amenity = "",
                            CodVilla = "LUXURY POOL VILLA-2922632524336248896",
                            CreatedDate = new DateTime(2023, 6, 27, 13, 15, 18, 507, DateTimeKind.Local).AddTicks(6040),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            Name = "Luxury Pool Villa",
                            Occupancy = 4,
                            Rate = 400.0,
                            Sqft = 750,
                            UodatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            imageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg"
                        },
                        new
                        {
                            Id = new Guid("e7d003e8-69be-4736-8edf-edecde943a12"),
                            Amenity = "",
                            CodVilla = "DIAMOND VILLA-5443141168746691926",
                            CreatedDate = new DateTime(2023, 6, 27, 13, 15, 18, 507, DateTimeKind.Local).AddTicks(6070),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            Name = "Diamond Villa",
                            Occupancy = 4,
                            Rate = 550.0,
                            Sqft = 900,
                            UodatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            imageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg"
                        },
                        new
                        {
                            Id = new Guid("f3976252-a470-4dc9-8970-a03fc1034c89"),
                            Amenity = "",
                            CodVilla = "DIAMOND POOL VILLA-4322195011927034176",
                            CreatedDate = new DateTime(2023, 6, 27, 13, 15, 18, 507, DateTimeKind.Local).AddTicks(6080),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            Name = "Diamond Pool Villa",
                            Occupancy = 4,
                            Rate = 600.0,
                            Sqft = 1100,
                            UodatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            imageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
