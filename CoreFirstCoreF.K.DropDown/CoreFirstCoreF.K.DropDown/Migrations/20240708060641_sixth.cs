﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreFirstCoreF.K.DropDown.Migrations
{
    /// <inheritdoc />
    public partial class sixth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_Did",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Did",
                table: "Employees");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Employees_Did",
                table: "Employees",
                column: "Did");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_Did",
                table: "Employees",
                column: "Did",
                principalTable: "Departments",
                principalColumn: "Did",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
