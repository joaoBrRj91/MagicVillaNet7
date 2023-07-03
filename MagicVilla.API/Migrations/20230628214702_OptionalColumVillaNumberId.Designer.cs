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
    [Migration("20230628214702_OptionalColumVillaNumberId")]
    partial class OptionalColumVillaNumberId
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

                    b.Property<Guid>("VillaNumberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("imageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f8a54b56-0d46-4b42-8ee7-12ede5b20cf2"),
                            Amenity = "",
                            CodVilla = "ROYAL VILLA-8767954731780689201",
                            CreatedDate = new DateTime(2023, 6, 28, 18, 47, 2, 142, DateTimeKind.Local).AddTicks(9550),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            Name = "Royal Villa",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UodatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VillaNumberId = new Guid("00000000-0000-0000-0000-000000000000"),
                            imageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg"
                        },
                        new
                        {
                            Id = new Guid("d110ed52-6d42-49cc-8db6-b1d23fe84e06"),
                            Amenity = "",
                            CodVilla = "PREMIUM POOL VILLA-2281914676658778937",
                            CreatedDate = new DateTime(2023, 6, 28, 18, 47, 2, 142, DateTimeKind.Local).AddTicks(9630),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            Name = "Premium Pool Villa",
                            Occupancy = 4,
                            Rate = 300.0,
                            Sqft = 550,
                            UodatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VillaNumberId = new Guid("00000000-0000-0000-0000-000000000000"),
                            imageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg"
                        },
                        new
                        {
                            Id = new Guid("fcd1318f-68d7-43f1-ba26-0d56d2015cb6"),
                            Amenity = "",
                            CodVilla = "LUXURY POOL VILLA-7420017339679392711",
                            CreatedDate = new DateTime(2023, 6, 28, 18, 47, 2, 142, DateTimeKind.Local).AddTicks(9650),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            Name = "Luxury Pool Villa",
                            Occupancy = 4,
                            Rate = 400.0,
                            Sqft = 750,
                            UodatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VillaNumberId = new Guid("00000000-0000-0000-0000-000000000000"),
                            imageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg"
                        },
                        new
                        {
                            Id = new Guid("549af96e-be1a-4992-a355-6f95f7a00ce6"),
                            Amenity = "",
                            CodVilla = "DIAMOND VILLA-7846735314691705611",
                            CreatedDate = new DateTime(2023, 6, 28, 18, 47, 2, 142, DateTimeKind.Local).AddTicks(9670),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            Name = "Diamond Villa",
                            Occupancy = 4,
                            Rate = 550.0,
                            Sqft = 900,
                            UodatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VillaNumberId = new Guid("00000000-0000-0000-0000-000000000000"),
                            imageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg"
                        },
                        new
                        {
                            Id = new Guid("6217edee-f9c8-4ee6-8733-d50fe47a6f0c"),
                            Amenity = "",
                            CodVilla = "DIAMOND POOL VILLA-8104256605992976954",
                            CreatedDate = new DateTime(2023, 6, 28, 18, 47, 2, 142, DateTimeKind.Local).AddTicks(9690),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            Name = "Diamond Pool Villa",
                            Occupancy = 4,
                            Rate = 600.0,
                            Sqft = 1100,
                            UodatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VillaNumberId = new Guid("00000000-0000-0000-0000-000000000000"),
                            imageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg"
                        });
                });

            modelBuilder.Entity("MagicVilla.API.Models.VillaNumber", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SpecialDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VillaNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VillaNo")
                        .IsUnique();

                    b.ToTable("VillaNumbers");
                });
#pragma warning restore 612, 618
        }
    }
}