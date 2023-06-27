using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CodVilla", "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft", "UodatedDate", "imageUrl" },
                values: new object[,]
                {
                    { new Guid("464f8841-b2fa-41bb-9707-61f17240549b"), "", "ROYAL VILLA-5721420465042486550", new DateTime(2023, 6, 27, 13, 15, 18, 507, DateTimeKind.Local).AddTicks(5940), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Royal Villa", 4, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg" },
                    { new Guid("8c1db540-b036-4c7a-82d9-05022e41ce8c"), "", "LUXURY POOL VILLA-2922632524336248896", new DateTime(2023, 6, 27, 13, 15, 18, 507, DateTimeKind.Local).AddTicks(6040), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Luxury Pool Villa", 4, 400.0, 750, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg" },
                    { new Guid("bdaf817a-b8a7-47c0-be84-557ca227641e"), "", "PREMIUM POOL VILLA-4389313556231890347", new DateTime(2023, 6, 27, 13, 15, 18, 507, DateTimeKind.Local).AddTicks(6020), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Premium Pool Villa", 4, 300.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg" },
                    { new Guid("e7d003e8-69be-4736-8edf-edecde943a12"), "", "DIAMOND VILLA-5443141168746691926", new DateTime(2023, 6, 27, 13, 15, 18, 507, DateTimeKind.Local).AddTicks(6070), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Diamond Villa", 4, 550.0, 900, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg" },
                    { new Guid("f3976252-a470-4dc9-8970-a03fc1034c89"), "", "DIAMOND POOL VILLA-4322195011927034176", new DateTime(2023, 6, 27, 13, 15, 18, 507, DateTimeKind.Local).AddTicks(6080), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Diamond Pool Villa", 4, 600.0, 1100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("464f8841-b2fa-41bb-9707-61f17240549b"));

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("8c1db540-b036-4c7a-82d9-05022e41ce8c"));

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("bdaf817a-b8a7-47c0-be84-557ca227641e"));

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("e7d003e8-69be-4736-8edf-edecde943a12"));

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("f3976252-a470-4dc9-8970-a03fc1034c89"));
        }
    }
}
