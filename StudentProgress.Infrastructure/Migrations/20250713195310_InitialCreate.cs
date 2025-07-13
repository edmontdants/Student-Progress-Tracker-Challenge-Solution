using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentProgress.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "ProgressRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompletionPercentage = table.Column<double>(type: "float", nullable: false),
                    Score = table.Column<double>(type: "float", nullable: false),
                    TimeSpent = table.Column<TimeSpan>(type: "time", nullable: false),
                    AssignmentCompleted = table.Column<int>(type: "int", nullable: false),
                    AssessmentScore = table.Column<double>(type: "float", nullable: false),
                    LastActivity = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgressRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgressRecords_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "FullName", "Grade", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("61875b10-945c-4216-940e-1d5083ce6090"), new DateTime(2010, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob Smith", "7", null },
                    { new Guid("afaa068b-6d34-49d8-b628-e9b5f30986d6"), new DateTime(2012, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice Johnson", "5", null }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FullName" },
                values: new object[] { new Guid("9f2d0a83-1ddb-4a23-a336-8464885d9b1e"), "Mr. Anderson" });

            migrationBuilder.InsertData(
                table: "ProgressRecords",
                columns: new[] { "Id", "AssessmentScore", "AssignmentCompleted", "CompletionPercentage", "LastActivity", "Score", "StudentId", "Subject", "TimeSpent" },
                values: new object[,]
                {
                    { new Guid("8440a85f-6905-443c-baf9-9bc9932cd99a"), 72.0, 8, 70.0, new DateTime(2025, 7, 8, 19, 53, 10, 282, DateTimeKind.Utc).AddTicks(6841), 75.0, new Guid("61875b10-945c-4216-940e-1d5083ce6090"), "Science", new TimeSpan(0, 10, 0, 0, 0) },
                    { new Guid("d689a6cc-acd2-4d1d-a975-f117fbf022d6"), 88.0, 10, 85.0, new DateTime(2025, 7, 11, 19, 53, 10, 282, DateTimeKind.Utc).AddTicks(6833), 90.0, new Guid("afaa068b-6d34-49d8-b628-e9b5f30986d6"), "Math", new TimeSpan(0, 15, 0, 0, 0) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProgressRecords_StudentId",
                table: "ProgressRecords",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_TeacherId",
                table: "Students",
                column: "TeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProgressRecords");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
