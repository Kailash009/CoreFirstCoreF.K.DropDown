using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreFirstCoreF.K.DropDown.Migrations
{
    /// <inheritdoc />
    public partial class fivth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Cities_city_id1",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Departments_DepartmentDid",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_DepartmentDid",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Cities_city_id1",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "DepartmentDid",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "city_id1",
                table: "Cities");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentDid",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "city_id1",
                table: "Cities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DepartmentDid",
                table: "Departments",
                column: "DepartmentDid");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_city_id1",
                table: "Cities",
                column: "city_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Cities_city_id1",
                table: "Cities",
                column: "city_id1",
                principalTable: "Cities",
                principalColumn: "city_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Departments_DepartmentDid",
                table: "Departments",
                column: "DepartmentDid",
                principalTable: "Departments",
                principalColumn: "Did");
        }
    }
}
