using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla.API.Migrations
{
    /// <inheritdoc />
    public partial class Teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("99e4a417-fea3-4009-ab44-5c4b5729022e"));

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CodVilla", "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft", "UodatedDate", "VillaNumberId", "imageUrl" },
                values: new object[] { new Guid("233bbcfe-1bdb-4314-82ab-12885ad3e778"), "", "ROYAL VILLA-6824952426154566397", new DateTime(2023, 6, 28, 19, 31, 29, 390, DateTimeKind.Local).AddTicks(1440), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Royal Villa", 4, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7d766478-c76a-4e99-8408-9e4ddd75a416"), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("233bbcfe-1bdb-4314-82ab-12885ad3e778"));

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CodVilla", "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft", "UodatedDate", "VillaNumberId", "imageUrl" },
                values: new object[] { new Guid("99e4a417-fea3-4009-ab44-5c4b5729022e"), "", "ROYAL VILLA-958370548417775862", new DateTime(2023, 6, 28, 19, 18, 0, 199, DateTimeKind.Local).AddTicks(6810), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Royal Villa", 4, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7d766478-c76a-4e99-8408-9e4ddd75a416"), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg" });
        }
    }
}
