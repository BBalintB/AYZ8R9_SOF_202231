using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AYZ8R9_SOF_202231.Migrations
{
    public partial class setstringlimits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "f9fe9bcd-c399-4024-b79c-21c611114f2b" });

            migrationBuilder.DeleteData(
                table: "ProjectAppUsersConnection",
                keyColumns: new[] { "AppUserId", "ProjectId" },
                keyValues: new object[] { "f9fe9bcd-c399-4024-b79c-21c611114f2b", "fd23257e-e81e-48d9-b120-3eef99f4881a" });

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "0ddb9361-3aad-4a53-9101-679b275b760f");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "14d7967d-6186-46b1-a5ba-b83d2b2b5dcf");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "15140f58-9218-4134-b03e-e61dd2dee2e0");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "c3815974-b0ec-48c4-a400-8eae7a0287bf");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "c3d8fa14-5b4f-4c0d-a876-88b45ed682c2");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "d3a0de28-9e27-4c4b-8bd6-c56698c55642");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: "fd23257e-e81e-48d9-b120-3eef99f4881a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9fe9bcd-c399-4024-b79c-21c611114f2b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "da7d3346-21d4-404e-823d-5a2a716a7484");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "671cee80-e8f1-4508-8b36-254ef115bc8d");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7a053559-3aee-4694-b3e2-4df94d387435", 0, "a30ae17d-dc8b-4863-9a39-4cc9097366fc", "admin@admin.com", true, "Big", "Boss", false, null, null, "ADMIN@ADMIN.com", "AQAAAAEAACcQAAAAEGvkCp8lrZsxgvdOFekkRaJEEwvnMUf9TdOSUxTMMTuY2xEq8A3cStEYik8wBZM7Hg==", null, false, null, null, "045f39a9-18ef-4b83-9c76-fabe947a2b42", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "7a053559-3aee-4694-b3e2-4df94d387435" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "OwnerId", "ProjectName" },
                values: new object[] { "14fe05bb-4233-4ceb-8e95-21e771149cc5", "7a053559-3aee-4694-b3e2-4df94d387435", "Test Project" });

            migrationBuilder.InsertData(
                table: "ProjectAppUsersConnection",
                columns: new[] { "AppUserId", "ProjectId", "ConnectionId" },
                values: new object[] { "7a053559-3aee-4694-b3e2-4df94d387435", "14fe05bb-4233-4ceb-8e95-21e771149cc5", "d866a276-b73b-4d06-b63e-d2a2a70847a9" });

            migrationBuilder.InsertData(
                table: "Sprints",
                columns: new[] { "SprintId", "ProjectId", "SprintDueDate", "SprintName" },
                values: new object[,]
                {
                    { "75091cbf-29f2-4e32-aea3-be5f20cf0d74", "14fe05bb-4233-4ceb-8e95-21e771149cc5", "2022.12.30", "Test Sprint2" },
                    { "b5bd0446-be2d-4dbf-a506-493a3b3cad12", "14fe05bb-4233-4ceb-8e95-21e771149cc5", "2022.12.24", "Test Sprint1" },
                    { "e1e16999-05ec-4b3a-8e31-46a090b47f4a", "14fe05bb-4233-4ceb-8e95-21e771149cc5", "2022.12.14", "Test Sprint" }
                });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "9f3c76ae-abb9-4e56-993e-4c74189f14f7", "e1e16999-05ec-4b3a-8e31-46a090b47f4a", 0, "Just a test", "Test user story 1", 5 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "e9214ed0-4e98-4929-992d-e0c792ff3b37", "b5bd0446-be2d-4dbf-a506-493a3b3cad12", 0, "Just a test", "Test user story 3", 11 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "f34deffe-7361-4e0f-9c49-de7cdfda8e74", "e1e16999-05ec-4b3a-8e31-46a090b47f4a", 0, "Just a test", "Test user story 2", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "7a053559-3aee-4694-b3e2-4df94d387435" });

            migrationBuilder.DeleteData(
                table: "ProjectAppUsersConnection",
                keyColumns: new[] { "AppUserId", "ProjectId" },
                keyValues: new object[] { "7a053559-3aee-4694-b3e2-4df94d387435", "14fe05bb-4233-4ceb-8e95-21e771149cc5" });

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "75091cbf-29f2-4e32-aea3-be5f20cf0d74");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "9f3c76ae-abb9-4e56-993e-4c74189f14f7");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "e9214ed0-4e98-4929-992d-e0c792ff3b37");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "f34deffe-7361-4e0f-9c49-de7cdfda8e74");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "b5bd0446-be2d-4dbf-a506-493a3b3cad12");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "e1e16999-05ec-4b3a-8e31-46a090b47f4a");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: "14fe05bb-4233-4ceb-8e95-21e771149cc5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a053559-3aee-4694-b3e2-4df94d387435");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "674d31e5-b6db-4688-8da7-e493271ae6e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "e6e5a0b2-003f-4409-93d3-a34cd65b7028");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f9fe9bcd-c399-4024-b79c-21c611114f2b", 0, "0ad6661c-1551-4d59-a5b1-320d0f500049", "admin@admin.com", true, "Big", "Boss", false, null, null, "ADMIN@ADMIN.com", "AQAAAAEAACcQAAAAENcrTREooKKdTIx5v1h+b+EpiUyeI/B2HqzyfJsRdyeTxBG45+mDipC9/Up9l48oYQ==", null, false, null, null, "46ad68d1-6dc9-4584-b5f6-0a76551a84f9", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "f9fe9bcd-c399-4024-b79c-21c611114f2b" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "OwnerId", "ProjectName" },
                values: new object[] { "fd23257e-e81e-48d9-b120-3eef99f4881a", "f9fe9bcd-c399-4024-b79c-21c611114f2b", "Test Project" });

            migrationBuilder.InsertData(
                table: "ProjectAppUsersConnection",
                columns: new[] { "AppUserId", "ProjectId", "ConnectionId" },
                values: new object[] { "f9fe9bcd-c399-4024-b79c-21c611114f2b", "fd23257e-e81e-48d9-b120-3eef99f4881a", "7a2187e9-ac25-48df-95fc-543e14f50e87" });

            migrationBuilder.InsertData(
                table: "Sprints",
                columns: new[] { "SprintId", "ProjectId", "SprintDueDate", "SprintName" },
                values: new object[,]
                {
                    { "0ddb9361-3aad-4a53-9101-679b275b760f", "fd23257e-e81e-48d9-b120-3eef99f4881a", "2022.12.30", "Test Sprint2" },
                    { "c3d8fa14-5b4f-4c0d-a876-88b45ed682c2", "fd23257e-e81e-48d9-b120-3eef99f4881a", "2022.12.14", "Test Sprint" },
                    { "d3a0de28-9e27-4c4b-8bd6-c56698c55642", "fd23257e-e81e-48d9-b120-3eef99f4881a", "2022.12.24", "Test Sprint1" }
                });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "14d7967d-6186-46b1-a5ba-b83d2b2b5dcf", "c3d8fa14-5b4f-4c0d-a876-88b45ed682c2", 0, "Just a test", "Test user story 2", 3 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "15140f58-9218-4134-b03e-e61dd2dee2e0", "d3a0de28-9e27-4c4b-8bd6-c56698c55642", 0, "Just a test", "Test user story 3", 11 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "c3815974-b0ec-48c4-a400-8eae7a0287bf", "c3d8fa14-5b4f-4c0d-a876-88b45ed682c2", 0, "Just a test", "Test user story 1", 5 });
        }
    }
}
