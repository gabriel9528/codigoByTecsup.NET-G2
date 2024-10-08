using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Microservicios.Services.AuthAPI.Migrations
{
    /// <inheritdoc />
    public partial class addNombresToUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nombres",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombres",
                table: "AspNetUsers");
        }
    }
}
