using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FolderExplorer.Models.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Folders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentFolderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Folders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Folders",
                columns: new[] { "Id", "Name", "ParentFolderId" },
                values: new object[,]
                {
                    { new Guid("0ebca07b-2579-4f2a-ad6c-8d6d7d61a10b"), "Final Product", new Guid("b16eccef-7a17-49bb-813b-e96d539e7d57") },
                    { new Guid("4955e8ab-a3f9-4d46-8432-412f15ce7956"), "Resources", new Guid("eb1c85ee-e1a6-484f-a506-01fa84d0a9a2") },
                    { new Guid("8a403497-333b-41b8-91d3-1a1c71cb4a68"), "Primary Sources", new Guid("4955e8ab-a3f9-4d46-8432-412f15ce7956") },
                    { new Guid("a789d8d4-2708-4413-b1da-8bb727766b81"), "Evidence", new Guid("eb1c85ee-e1a6-484f-a506-01fa84d0a9a2") },
                    { new Guid("ac5024fd-7204-40e3-89b3-aa3bc1805be2"), "Secondary Sources", new Guid("4955e8ab-a3f9-4d46-8432-412f15ce7956") },
                    { new Guid("b16eccef-7a17-49bb-813b-e96d539e7d57"), "Graphic Products", new Guid("eb1c85ee-e1a6-484f-a506-01fa84d0a9a2") },
                    { new Guid("bde3b420-4a76-4c84-817d-a839efe6bc98"), "Process", new Guid("b16eccef-7a17-49bb-813b-e96d539e7d57") },
                    { new Guid("eb1c85ee-e1a6-484f-a506-01fa84d0a9a2"), "Creating Digital Images", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Folders");
        }
    }
}
