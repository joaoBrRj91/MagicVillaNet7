using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla.API.Migrations
{
    /// <inheritdoc />
    public partial class OptionalColumVillaNumberId2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("549af96e-be1a-4992-a355-6f95f7a00ce6"));

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("6217edee-f9c8-4ee6-8733-d50fe47a6f0c"));

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("d110ed52-6d42-49cc-8db6-b1d23fe84e06"));

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("f8a54b56-0d46-4b42-8ee7-12ede5b20cf2"));

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("fcd1318f-68d7-43f1-ba26-0d56d2015cb6"));

            migrationBuilder.AlterColumn<Guid>(
                name: "VillaNumberId",
                table: "Villas",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "VillaNumberId",
                table: "Villas",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CodVilla", "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft", "UodatedDate", "VillaNumberId", "imageUrl" },
                values: new object[,]
                {
                    { new Guid("549af96e-be1a-4992-a355-6f95f7a00ce6"), "", "DIAMOND VILLA-7846735314691705611", new DateTime(2023, 6, 28, 18, 47, 2, 142, DateTimeKind.Local).AddTicks(9670), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Diamond Villa", 4, 550.0, 900, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg" },
                    { new Guid("6217edee-f9c8-4ee6-8733-d50fe47a6f0c"), "", "DIAMOND POOL VILLA-8104256605992976954", new DateTime(2023, 6, 28, 18, 47, 2, 142, DateTimeKind.Local).AddTicks(9690), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Diamond Pool Villa", 4, 600.0, 1100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg" },
                    { new Guid("d110ed52-6d42-49cc-8db6-b1d23fe84e06"), "", "PREMIUM POOL VILLA-2281914676658778937", new DateTime(2023, 6, 28, 18, 47, 2, 142, DateTimeKind.Local).AddTicks(9630), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Premium Pool Villa", 4, 300.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg" },
                    { new Guid("f8a54b56-0d46-4b42-8ee7-12ede5b20cf2"), "", "ROYAL VILLA-8767954731780689201", new DateTime(2023, 6, 28, 18, 47, 2, 142, DateTimeKind.Local).AddTicks(9550), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Royal Villa", 4, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg" },
                    { new Guid("fcd1318f-68d7-43f1-ba26-0d56d2015cb6"), "", "LUXURY POOL VILLA-7420017339679392711", new DateTime(2023, 6, 28, 18, 47, 2, 142, DateTimeKind.Local).AddTicks(9650), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Luxury Pool Villa", 4, 400.0, 750, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg" }
                });
        }
    }
}
