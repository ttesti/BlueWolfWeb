﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlueWolfRazor_Temp.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryTodB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Displayorder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Displayorder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Action" },
                    { 2, 2, "Science Fiction" },
                    { 3, 3, "History" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
