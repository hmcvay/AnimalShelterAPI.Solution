using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Description", "Name", "Sex", "Species" },
                values: new object[,]
                {
                    { 1, 7, "Bites ankles to beg for food", "Matilda", "F", "Cat" },
                    { 2, 1, "This kitten hides in plastic bags", "Caserole", "M", "Cat" },
                    { 3, 4, "He only eats hotdogs with ketchup", "Nathan", "M", "Dog" },
                    { 4, 12, "She's on her way out, tbh", "Brenda", "F", "Dog" },
                    { 5, 1, "She stares at herself in the reflection", "Toothpick", "F", "Cat" },
                    { 6, 1, "She can barely eat a kibble she's so smol", "Sea Shell Girl", "F", "Dog" },
                    { 7, 3, "Will takes bites out of butter if left on the counter", "Butter", "M", "Dog" },
                    { 8, 2, "Loves to nap in dog beds", "Oyster", "F", "Cat" },
                    { 9, 2, "Just your basic golden retriever", "Chad", "M", "Cat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9);
        }
    }
}
