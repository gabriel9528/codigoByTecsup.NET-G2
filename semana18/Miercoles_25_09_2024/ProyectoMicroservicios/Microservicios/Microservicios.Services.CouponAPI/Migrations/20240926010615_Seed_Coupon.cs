using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Microservicios.Services.CouponAPI.Migrations
{
    /// <inheritdoc />
    public partial class Seed_Coupon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coupon",
                columns: new[] { "CouponId", "CouponCode", "DiscountAmount", "MinimumAmount" },
                values: new object[,]
                {
                    { 1, "10OFF", 10.0, 20 },
                    { 2, "20OFF", 20.0, 40 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "CouponId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "CouponId",
                keyValue: 2);
        }
    }
}
