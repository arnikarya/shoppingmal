using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseLibrary.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingMallDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingMallName = table.Column<string>(type: "Varchar(50)", nullable: false),
                    City = table.Column<string>(type: "Varchar(50)", nullable: false),
                    State = table.Column<string>(type: "Varchar(50)", nullable: false),
                    Built_in_Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingMallDetails", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingMallDetails_ShoppingMallName",
                table: "ShoppingMallDetails",
                column: "ShoppingMallName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingMallDetails");
        }
    }
}
