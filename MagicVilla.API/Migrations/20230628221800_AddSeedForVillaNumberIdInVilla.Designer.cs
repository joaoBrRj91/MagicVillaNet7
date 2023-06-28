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
    [Migration("20230628221800_AddSeedForVillaNumberIdInVilla")]
    partial class AddSeedForVillaNumberIdInVilla
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

                    b.Property<Guid?>("VillaNumberId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("imageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("VillaNumberId")
                        .IsUnique();

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = new Guid("99e4a417-fea3-4009-ab44-5c4b5729022e"),
                            Amenity = "",
                            CodVilla = "ROYAL VILLA-958370548417775862",
                            CreatedDate = new DateTime(2023, 6, 28, 19, 18, 0, 199, DateTimeKind.Local).AddTicks(6810),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            Name = "Royal Villa",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UodatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VillaNumberId = new Guid("95ca3dfb-8ffe-430e-9e3d-da2b4b6f9486"),
                            imageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg"
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

            modelBuilder.Entity("MagicVilla.API.Models.Villa", b =>
                {
                    b.HasOne("MagicVilla.API.Models.VillaNumber", "VillaNumber")
                        .WithOne("Villa")
                        .HasForeignKey("MagicVilla.API.Models.Villa", "VillaNumberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VillaNumber");
                });

            modelBuilder.Entity("MagicVilla.API.Models.VillaNumber", b =>
                {
                    b.Navigation("Villa")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
