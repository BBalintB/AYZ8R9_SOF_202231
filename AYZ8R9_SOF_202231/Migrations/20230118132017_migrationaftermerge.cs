using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AYZ8R9_SOF_202231.Migrations
{
    public partial class migrationaftermerge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "106855e5-e3e9-46d6-8521-20b3beea8d50" });

            migrationBuilder.DeleteData(
                table: "ProjectAppUsersConnection",
                keyColumns: new[] { "AppUserId", "ProjectId" },
                keyValues: new object[] { "106855e5-e3e9-46d6-8521-20b3beea8d50", "fb588160-f769-46c7-a762-29743ed1e679" });

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "f19d1ffc-f2f1-453a-bfda-5a84a7d73859");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "5e6b4924-7bae-4fb3-904e-989b93a83c5c");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "b0a07a2a-827b-4c92-90d3-9a3b2af8abac");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "b6c5cd95-8b13-4a20-836d-db99910b1b26");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "42975a27-b3a5-494d-a8ba-167d08f87bd4");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "fd5a8ddc-3b9c-4fac-8afd-31b9c2043a07");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: "fb588160-f769-46c7-a762-29743ed1e679");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106855e5-e3e9-46d6-8521-20b3beea8d50");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "48470392-b4ec-4cb7-85f1-5584471d4bc6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7f3b65bc-49ac-46e5-8c24-8336a6f621cc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3", "a9ccebd9-57d1-4cd7-a207-72f04ac4c390", "Developer", "DEVELOPER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "106855e5-e3e9-46d6-8521-20b3beea8d50", 0, "7f2835f7-4279-452f-bba1-c0c7ff05a0b1", "admin@admin.com", true, "Big", "Boss", false, null, null, "ADMIN@ADMIN.com", "AQAAAAEAACcQAAAAEOKcz++/rffMYlBa/wtG+KMCEBF6P9fvoS/m9vKJq9IFK/zbLikGxH6rWKeqJKTskw==", null, false, null, null, "d50ceaba-3934-44c7-8ad9-845e318ab15a", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "106855e5-e3e9-46d6-8521-20b3beea8d50" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "OwnerId", "ProjectName" },
                values: new object[] { "fb588160-f769-46c7-a762-29743ed1e679", "106855e5-e3e9-46d6-8521-20b3beea8d50", "Test Project" });

            migrationBuilder.InsertData(
                table: "ProjectAppUsersConnection",
                columns: new[] { "AppUserId", "ProjectId", "ConnectionId" },
                values: new object[] { "106855e5-e3e9-46d6-8521-20b3beea8d50", "fb588160-f769-46c7-a762-29743ed1e679", null });

            migrationBuilder.InsertData(
                table: "Sprints",
                columns: new[] { "SprintId", "ProjectId", "SprintDueDate", "SprintName" },
                values: new object[,]
                {
                    { "42975a27-b3a5-494d-a8ba-167d08f87bd4", "fb588160-f769-46c7-a762-29743ed1e679", "2022.12.24", "Test Sprint1" },
                    { "f19d1ffc-f2f1-453a-bfda-5a84a7d73859", "fb588160-f769-46c7-a762-29743ed1e679", "2022.12.30", "Test Sprint2" },
                    { "fd5a8ddc-3b9c-4fac-8afd-31b9c2043a07", "fb588160-f769-46c7-a762-29743ed1e679", "2022.12.14", "Test Sprint" }
                });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "5e6b4924-7bae-4fb3-904e-989b93a83c5c", "42975a27-b3a5-494d-a8ba-167d08f87bd4", 0, "Just a test", "Test user story 3", 11 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "b0a07a2a-827b-4c92-90d3-9a3b2af8abac", "fd5a8ddc-3b9c-4fac-8afd-31b9c2043a07", 0, "Just a test", "Test user story 1", 5 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "b6c5cd95-8b13-4a20-836d-db99910b1b26", "fd5a8ddc-3b9c-4fac-8afd-31b9c2043a07", 0, "Just a test", "Test user story 2", 3 });
        }
    }
}
