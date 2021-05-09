using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class addprice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Crusts",
                keyColumn: "EntityID",
                keyValue: 1L,
                column: "Price",
                value: 2m);

            migrationBuilder.UpdateData(
                table: "Crusts",
                keyColumn: "EntityID",
                keyValue: 2L,
                column: "Price",
                value: 2m);

            migrationBuilder.UpdateData(
                table: "Crusts",
                keyColumn: "EntityID",
                keyValue: 3L,
                column: "Price",
                value: 2m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityID",
                keyValue: 1L,
                column: "Price",
                value: 2m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityID",
                keyValue: 2L,
                column: "Price",
                value: 3m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityID",
                keyValue: 3L,
                column: "Price",
                value: 4m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 1L,
                column: "Price",
                value: 2m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 2L,
                column: "Price",
                value: 2m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 3L,
                column: "Price",
                value: 2m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 4L,
                column: "Price",
                value: 2m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 5L,
                column: "Price",
                value: 2m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 6L,
                column: "Price",
                value: 2m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Crusts",
                keyColumn: "EntityID",
                keyValue: 1L,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Crusts",
                keyColumn: "EntityID",
                keyValue: 2L,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Crusts",
                keyColumn: "EntityID",
                keyValue: 3L,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityID",
                keyValue: 1L,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityID",
                keyValue: 2L,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityID",
                keyValue: 3L,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 1L,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 2L,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 3L,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 4L,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 5L,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 6L,
                column: "Price",
                value: 0m);
        }
    }
}
