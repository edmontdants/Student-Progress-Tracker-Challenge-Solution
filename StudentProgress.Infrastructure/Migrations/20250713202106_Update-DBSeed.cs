using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentProgress.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDBSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProgressRecords",
                keyColumn: "Id",
                keyValue: new Guid("8440a85f-6905-443c-baf9-9bc9932cd99a"));

            migrationBuilder.DeleteData(
                table: "ProgressRecords",
                keyColumn: "Id",
                keyValue: new Guid("d689a6cc-acd2-4d1d-a975-f117fbf022d6"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("9f2d0a83-1ddb-4a23-a336-8464885d9b1e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("61875b10-945c-4216-940e-1d5083ce6090"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("afaa068b-6d34-49d8-b628-e9b5f30986d6"));

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "FullName", "Grade", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("04dfb491-d17d-48aa-a3ed-dea663221b53"), new DateTime(2008, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tyler Vasquez", "11", null },
                    { new Guid("10010fbc-7f1a-4b53-b487-d38f6a73f001"), new DateTime(2009, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sophia Upton", "10", null },
                    { new Guid("1dfb94ac-e4e6-4c73-a599-cb347d9e8e7c"), new DateTime(2013, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriel Harris", "6", null },
                    { new Guid("249b8e7e-a11d-4bc3-a541-b29f9d699e00"), new DateTime(2016, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diana Evans", "3", null },
                    { new Guid("33874a99-f0c5-4aba-aa22-e215d1c113e9"), new DateTime(2011, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quinn Smith", "8", null },
                    { new Guid("36e13d97-7999-4259-866b-965ab7c6ae0b"), new DateTime(2012, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hannah Ibrahim", "7", null },
                    { new Guid("42269daf-6352-463b-b129-2bc139f3fa1f"), new DateTime(2014, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fiona Gomez", "5", null },
                    { new Guid("64dd9809-3856-40dc-9b5e-d26cd8b1f3c9"), new DateTime(2012, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olivia Quinn", "7", null },
                    { new Guid("966131a9-28e4-472e-9903-92f2620cdece"), new DateTime(2011, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ian Jackson", "8", null },
                    { new Guid("9f9c3a49-7c19-4196-8892-41986dc371ad"), new DateTime(2008, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liam Martinez", "11", null },
                    { new Guid("a1785ad7-9bf2-4c98-b425-7fdc6731a7b8"), new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aiden Carter", "K", null },
                    { new Guid("ac589662-1e08-4d48-98aa-89ba6d8909f7"), new DateTime(2017, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caleb Davis", "2", null },
                    { new Guid("b224b27e-eb60-480a-87a5-c4918eace424"), new DateTime(2015, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ethan Flores", "4", null },
                    { new Guid("b6a2ad45-a18d-4620-8c04-54ce07440f6d"), new DateTime(2009, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kai Lee", "10", null },
                    { new Guid("c60d716c-22fc-46cb-9475-797f9f1d5e91"), new DateTime(2010, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jasmine Kim", "9", null },
                    { new Guid("c69cc368-dc8f-4ba6-a207-dd4536c27917"), new DateTime(2014, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noah Patel", "5", null },
                    { new Guid("d94a3809-0a05-4fcc-94f9-80f58702e8a2"), new DateTime(2010, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Riley Thompson", "9", null },
                    { new Guid("e249763a-5c2e-476d-bfba-92074f35ab42"), new DateTime(2007, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mia Nguyen", "12", null },
                    { new Guid("fdad5b13-e4c6-40e6-b523-299c5543b6f5"), new DateTime(2017, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parker Rivera", "2", null },
                    { new Guid("fdea37af-a680-4f04-b0a0-586af2ab6785"), new DateTime(2018, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bella Chen", "1", null }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FullName" },
                values: new object[] { new Guid("9214c21c-24bf-4e04-94fb-eb4a119c4e69"), "Emily Johnson" });

            migrationBuilder.InsertData(
                table: "ProgressRecords",
                columns: new[] { "Id", "AssessmentScore", "AssignmentCompleted", "CompletionPercentage", "LastActivity", "Score", "StudentId", "Subject", "TimeSpent" },
                values: new object[,]
                {
                    { new Guid("0408b65e-781a-41d8-8e6c-88d2284c1f90"), 68.0, 3, 70.0, new DateTime(2025, 7, 3, 20, 21, 5, 842, DateTimeKind.Utc).AddTicks(5292), 72.0, new Guid("b224b27e-eb60-480a-87a5-c4918eace424"), "Math", new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("268fcba3-5f37-4172-8594-21839bde4b08"), 88.0, 4, 80.0, new DateTime(2025, 7, 8, 20, 21, 5, 842, DateTimeKind.Utc).AddTicks(5284), 85.0, new Guid("fdea37af-a680-4f04-b0a0-586af2ab6785"), "Reading", new TimeSpan(0, 10, 0, 0, 0) },
                    { new Guid("27629f06-9e5a-44f2-9db6-17bae490a961"), 60.0, 3, 65.0, new DateTime(2025, 7, 12, 20, 21, 5, 842, DateTimeKind.Utc).AddTicks(5273), 68.0, new Guid("a1785ad7-9bf2-4c98-b425-7fdc6731a7b8"), "Math", new TimeSpan(0, 4, 0, 0, 0) },
                    { new Guid("3796ec0c-5a52-4314-a44b-aa41b8aa1383"), 95.0, 5, 95.0, new DateTime(2025, 7, 10, 20, 21, 5, 842, DateTimeKind.Utc).AddTicks(5287), 93.0, new Guid("ac589662-1e08-4d48-98aa-89ba6d8909f7"), "Science", new TimeSpan(0, 12, 0, 0, 0) },
                    { new Guid("587726af-7c3b-4e81-b42b-358d0899e0a6"), 83.0, 4, 85.0, new DateTime(2025, 7, 7, 20, 21, 5, 842, DateTimeKind.Utc).AddTicks(5309), 88.0, new Guid("c60d716c-22fc-46cb-9475-797f9f1d5e91"), "Reading", new TimeSpan(0, 10, 0, 0, 0) },
                    { new Guid("7d6f6b81-afba-49e8-8c3c-76e9c7e909e9"), 75.0, 3, 78.0, new DateTime(2025, 7, 9, 20, 21, 5, 842, DateTimeKind.Utc).AddTicks(5305), 80.0, new Guid("966131a9-28e4-472e-9903-92f2620cdece"), "Math", new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("87cb4a63-52ec-4cea-81b4-767b918bb863"), 91.0, 5, 92.0, new DateTime(2025, 7, 12, 20, 21, 5, 842, DateTimeKind.Utc).AddTicks(5299), 94.0, new Guid("1dfb94ac-e4e6-4c73-a599-cb347d9e8e7c"), "Science", new TimeSpan(0, 11, 0, 0, 0) },
                    { new Guid("9436714d-586f-47a3-8ce2-4e1343bd5b70"), 52.0, 2, 50.0, new DateTime(2025, 6, 13, 20, 21, 5, 842, DateTimeKind.Utc).AddTicks(5290), 55.0, new Guid("249b8e7e-a11d-4bc3-a541-b29f9d699e00"), "Social Studies", new TimeSpan(0, 3, 0, 0, 0) },
                    { new Guid("d0376791-7a72-4ac0-a387-670ee141c61c"), 42.0, 1, 40.0, new DateTime(2025, 5, 29, 20, 21, 5, 842, DateTimeKind.Utc).AddTicks(5301), 45.0, new Guid("36e13d97-7999-4259-866b-965ab7c6ae0b"), "Social Studies", new TimeSpan(0, 2, 0, 0, 0) },
                    { new Guid("f3137381-2edc-4f32-9e6c-81abeae40f9d"), 85.0, 4, 88.0, new DateTime(2025, 7, 11, 20, 21, 5, 842, DateTimeKind.Utc).AddTicks(5296), 90.0, new Guid("42269daf-6352-463b-b129-2bc139f3fa1f"), "Reading", new TimeSpan(0, 9, 0, 0, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProgressRecords",
                keyColumn: "Id",
                keyValue: new Guid("0408b65e-781a-41d8-8e6c-88d2284c1f90"));

            migrationBuilder.DeleteData(
                table: "ProgressRecords",
                keyColumn: "Id",
                keyValue: new Guid("268fcba3-5f37-4172-8594-21839bde4b08"));

            migrationBuilder.DeleteData(
                table: "ProgressRecords",
                keyColumn: "Id",
                keyValue: new Guid("27629f06-9e5a-44f2-9db6-17bae490a961"));

            migrationBuilder.DeleteData(
                table: "ProgressRecords",
                keyColumn: "Id",
                keyValue: new Guid("3796ec0c-5a52-4314-a44b-aa41b8aa1383"));

            migrationBuilder.DeleteData(
                table: "ProgressRecords",
                keyColumn: "Id",
                keyValue: new Guid("587726af-7c3b-4e81-b42b-358d0899e0a6"));

            migrationBuilder.DeleteData(
                table: "ProgressRecords",
                keyColumn: "Id",
                keyValue: new Guid("7d6f6b81-afba-49e8-8c3c-76e9c7e909e9"));

            migrationBuilder.DeleteData(
                table: "ProgressRecords",
                keyColumn: "Id",
                keyValue: new Guid("87cb4a63-52ec-4cea-81b4-767b918bb863"));

            migrationBuilder.DeleteData(
                table: "ProgressRecords",
                keyColumn: "Id",
                keyValue: new Guid("9436714d-586f-47a3-8ce2-4e1343bd5b70"));

            migrationBuilder.DeleteData(
                table: "ProgressRecords",
                keyColumn: "Id",
                keyValue: new Guid("d0376791-7a72-4ac0-a387-670ee141c61c"));

            migrationBuilder.DeleteData(
                table: "ProgressRecords",
                keyColumn: "Id",
                keyValue: new Guid("f3137381-2edc-4f32-9e6c-81abeae40f9d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("04dfb491-d17d-48aa-a3ed-dea663221b53"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("10010fbc-7f1a-4b53-b487-d38f6a73f001"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("33874a99-f0c5-4aba-aa22-e215d1c113e9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("64dd9809-3856-40dc-9b5e-d26cd8b1f3c9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("9f9c3a49-7c19-4196-8892-41986dc371ad"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b6a2ad45-a18d-4620-8c04-54ce07440f6d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c69cc368-dc8f-4ba6-a207-dd4536c27917"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d94a3809-0a05-4fcc-94f9-80f58702e8a2"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e249763a-5c2e-476d-bfba-92074f35ab42"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fdad5b13-e4c6-40e6-b523-299c5543b6f5"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("9214c21c-24bf-4e04-94fb-eb4a119c4e69"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("1dfb94ac-e4e6-4c73-a599-cb347d9e8e7c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("249b8e7e-a11d-4bc3-a541-b29f9d699e00"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("36e13d97-7999-4259-866b-965ab7c6ae0b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("42269daf-6352-463b-b129-2bc139f3fa1f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("966131a9-28e4-472e-9903-92f2620cdece"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a1785ad7-9bf2-4c98-b425-7fdc6731a7b8"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ac589662-1e08-4d48-98aa-89ba6d8909f7"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b224b27e-eb60-480a-87a5-c4918eace424"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c60d716c-22fc-46cb-9475-797f9f1d5e91"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fdea37af-a680-4f04-b0a0-586af2ab6785"));

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
        }
    }
}
