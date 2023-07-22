using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.DataAccessLayer.Migrations
{
    public partial class hotelupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Staffs");
        }
    }
}
