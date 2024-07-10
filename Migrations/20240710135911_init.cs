using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace hotel.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HotelRooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Flour = table.Column<int>(type: "int", nullable: false),
                    AmoundOfPeople = table.Column<int>(type: "int", nullable: false),
                    AmoundOfBed = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelRooms", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "HotelRooms",
                columns: new[] { "Id", "AmoundOfBed", "AmoundOfPeople", "Discount", "Flour", "Number", "Price", "Rating" },
                values: new object[,]
                {
                    { 1, 1, 2, 7m, 1, 101, 1400m, 3 },
                    { 2, 3, 3, 3m, 2, 201, 1500m, 5 },
                    { 3, 2, 2, 0m, 2, 202, 1250m, 3 },
                    { 4, 1, 1, 4m, 2, 203, 1130m, 3 },
                    { 5, 2, 4, 1m, 3, 301, 1376m, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelRooms");
        }
    }
}
