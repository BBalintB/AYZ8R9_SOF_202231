using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AYZ8R9_SOF_202231.Migrations
{
    public partial class AdminSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "ddf0b50b-e396-4784-987e-7b273c794dca" });

            migrationBuilder.DeleteData(
                table: "ProjectAppUsersConnection",
                keyColumns: new[] { "AppUserId", "ProjectId" },
                keyValues: new object[] { "ddf0b50b-e396-4784-987e-7b273c794dca", "1ca71cf3-49b0-4254-b95e-fe702f4b7e41" });

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "ca805e13-b7b9-47cf-a0fd-1276c9c1cea5");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "16e0b51a-a045-4156-b8a5-ae7bdfcb97c3");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "84b26e60-abe6-4de0-8713-0dfe6c7fb3e4");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "c48f3919-e508-4361-b57e-5ebbac4af3e6");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "1b5f2e8b-670f-42ff-a247-823e4a871a0c");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "20bbb238-7589-4da5-a3ac-0ad26ce52171");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: "1ca71cf3-49b0-4254-b95e-fe702f4b7e41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddf0b50b-e396-4784-987e-7b273c794dca");

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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "a9ccebd9-57d1-4cd7-a207-72f04ac4c390");

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
                columns: new[] { "AppUserId", "ProjectId" },
                values: new object[] { "106855e5-e3e9-46d6-8521-20b3beea8d50", "fb588160-f769-46c7-a762-29743ed1e679" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                value: "460408ee-506a-4de8-8500-ded173860eb8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "54ac8541-7b46-48ac-bb93-85a4625d231e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "93e20d07-23ab-40f5-a805-f2d7209cd62a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ddf0b50b-e396-4784-987e-7b273c794dca", 0, "a74a5dc1-6bd9-48c5-958d-cd44ddc02f20", "admin@admin.com", true, "Big", "Boss", false, null, null, "ADMIN@ADMIN.com", "AQAAAAEAACcQAAAAEOlEEzjosAjBcYJPUqaodOzDjIRyauV0goYBfgFAsVQwjrPz3u0CY3bp7DU450BRTA==", null, false, null, null, "0094ac2e-4861-4a8e-be68-32ebdd2f403a", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "ddf0b50b-e396-4784-987e-7b273c794dca" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "OwnerId", "ProjectName" },
                values: new object[] { "1ca71cf3-49b0-4254-b95e-fe702f4b7e41", "ddf0b50b-e396-4784-987e-7b273c794dca", "Test Project" });

            migrationBuilder.InsertData(
                table: "ProjectAppUsersConnection",
                columns: new[] { "AppUserId", "ProjectId" },
                values: new object[] { "ddf0b50b-e396-4784-987e-7b273c794dca", "1ca71cf3-49b0-4254-b95e-fe702f4b7e41" });

            migrationBuilder.InsertData(
                table: "Sprints",
                columns: new[] { "SprintId", "ProjectId", "SprintDueDate", "SprintName" },
                values: new object[,]
                {
                    { "1b5f2e8b-670f-42ff-a247-823e4a871a0c", "1ca71cf3-49b0-4254-b95e-fe702f4b7e41", "2022.12.14", "Test Sprint" },
                    { "20bbb238-7589-4da5-a3ac-0ad26ce52171", "1ca71cf3-49b0-4254-b95e-fe702f4b7e41", "2022.12.24", "Test Sprint1" },
                    { "ca805e13-b7b9-47cf-a0fd-1276c9c1cea5", "1ca71cf3-49b0-4254-b95e-fe702f4b7e41", "2022.12.30", "Test Sprint2" }
                });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "16e0b51a-a045-4156-b8a5-ae7bdfcb97c3", "1b5f2e8b-670f-42ff-a247-823e4a871a0c", 0, "Just a test", "Test user story 2", 3 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "84b26e60-abe6-4de0-8713-0dfe6c7fb3e4", "20bbb238-7589-4da5-a3ac-0ad26ce52171", 0, "Just a test", "Test user story 3", 11 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "c48f3919-e508-4361-b57e-5ebbac4af3e6", "1b5f2e8b-670f-42ff-a247-823e4a871a0c", 0, "Just a test", "Test user story 1", 5 });
        }
    }
}
