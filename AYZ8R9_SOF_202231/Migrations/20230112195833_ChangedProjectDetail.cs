using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AYZ8R9_SOF_202231.Migrations
{
    public partial class ChangedProjectDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectAppUsersConnection",
                keyColumns: new[] { "AppUserId", "ProjectId" },
                keyValues: new object[] { "fd835a59-53e9-46e6-b6b9-fe8303af403f", "c811e763-413f-4c52-8229-2ad2e678e2e2" });

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "f26840f7-d126-4410-9161-b0f4f3323d18");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "7495cee1-423f-4e9c-9883-49337903f2fa");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "af357de0-0c8d-4617-b14a-8ef24959da09");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "c6e8e660-3d76-4c90-8e11-ebb68514e6ab");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "2894df00-7282-49a8-8cf2-9a210e355dd9");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "bc93897d-52b3-4d76-b494-9df321d38cee");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: "c811e763-413f-4c52-8229-2ad2e678e2e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd835a59-53e9-46e6-b6b9-fe8303af403f");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Projects",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b5906e3e-3cf5-46c9-bc13-79eff7aa4dfd", 0, "7ab23f7c-7b5c-43b5-a375-8af3197db851", "admin@admin.com", true, "Big", "Boss", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEMwJMbEO5shEEo+RSxNxBprMYAzH1pDaAUiLOCyAEwXHvKHFs1/WxanS7DBVPPt4bA==", null, false, null, null, "3e3d5cce-ea70-43d0-adce-1aac1ca653be", false, "admin" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "OwnerId", "ProjectName" },
                values: new object[] { "503193da-c766-49d5-a3c1-f5ec9368ddab", "b5906e3e-3cf5-46c9-bc13-79eff7aa4dfd", "Test Project" });

            migrationBuilder.InsertData(
                table: "ProjectAppUsersConnection",
                columns: new[] { "AppUserId", "ProjectId" },
                values: new object[] { "b5906e3e-3cf5-46c9-bc13-79eff7aa4dfd", "503193da-c766-49d5-a3c1-f5ec9368ddab" });

            migrationBuilder.InsertData(
                table: "Sprints",
                columns: new[] { "SprintId", "ProjectId", "SprintDueDate", "SprintName" },
                values: new object[,]
                {
                    { "1e90ebe3-b4c3-48f0-8a7b-45c801196b16", "503193da-c766-49d5-a3c1-f5ec9368ddab", "2022.12.14", "Test Sprint" },
                    { "692e9db4-67ce-45eb-bd41-ac88dc736c7d", "503193da-c766-49d5-a3c1-f5ec9368ddab", "2022.12.30", "Test Sprint2" },
                    { "d4d0f9e7-dc04-4357-8445-eb3a422bb4f1", "503193da-c766-49d5-a3c1-f5ec9368ddab", "2022.12.24", "Test Sprint1" }
                });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "3919af6f-073b-4ad8-984f-0a30c73add7d", "d4d0f9e7-dc04-4357-8445-eb3a422bb4f1", 0, "Just a test", "Test user story 3", 11 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "8dd1c464-aa70-4757-8587-1bee4596f4ab", "1e90ebe3-b4c3-48f0-8a7b-45c801196b16", 0, "Just a test", "Test user story 2", 3 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "b9f9ed0d-7ec2-45c5-be56-54e68ae6d92f", "1e90ebe3-b4c3-48f0-8a7b-45c801196b16", 0, "Just a test", "Test user story 1", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectAppUsersConnection",
                keyColumns: new[] { "AppUserId", "ProjectId" },
                keyValues: new object[] { "b5906e3e-3cf5-46c9-bc13-79eff7aa4dfd", "503193da-c766-49d5-a3c1-f5ec9368ddab" });

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "692e9db4-67ce-45eb-bd41-ac88dc736c7d");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "3919af6f-073b-4ad8-984f-0a30c73add7d");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "8dd1c464-aa70-4757-8587-1bee4596f4ab");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "b9f9ed0d-7ec2-45c5-be56-54e68ae6d92f");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "1e90ebe3-b4c3-48f0-8a7b-45c801196b16");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "d4d0f9e7-dc04-4357-8445-eb3a422bb4f1");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: "503193da-c766-49d5-a3c1-f5ec9368ddab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5906e3e-3cf5-46c9-bc13-79eff7aa4dfd");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Projects",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fd835a59-53e9-46e6-b6b9-fe8303af403f", 0, "b473adcb-24a0-4892-9faf-de2e2fd8c98a", "admin@admin.com", true, "Big", "Boss", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEHH9GxWwsC/mCOFJix1SMJb4iiqqJ3gP5Z5x6EFa78nqUVxbEuPOPViqvTVUV85A5A==", null, false, null, null, "75a8a037-527f-4505-8c8e-d1d19755876e", false, "admin" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "OwnerId", "ProjectName" },
                values: new object[] { "c811e763-413f-4c52-8229-2ad2e678e2e2", "fd835a59-53e9-46e6-b6b9-fe8303af403f", "Test Project" });

            migrationBuilder.InsertData(
                table: "ProjectAppUsersConnection",
                columns: new[] { "AppUserId", "ProjectId" },
                values: new object[] { "fd835a59-53e9-46e6-b6b9-fe8303af403f", "c811e763-413f-4c52-8229-2ad2e678e2e2" });

            migrationBuilder.InsertData(
                table: "Sprints",
                columns: new[] { "SprintId", "ProjectId", "SprintDueDate", "SprintName" },
                values: new object[,]
                {
                    { "2894df00-7282-49a8-8cf2-9a210e355dd9", "c811e763-413f-4c52-8229-2ad2e678e2e2", "2022.12.14", "Test Sprint" },
                    { "bc93897d-52b3-4d76-b494-9df321d38cee", "c811e763-413f-4c52-8229-2ad2e678e2e2", "2022.12.24", "Test Sprint1" },
                    { "f26840f7-d126-4410-9161-b0f4f3323d18", "c811e763-413f-4c52-8229-2ad2e678e2e2", "2022.12.30", "Test Sprint2" }
                });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "7495cee1-423f-4e9c-9883-49337903f2fa", "2894df00-7282-49a8-8cf2-9a210e355dd9", 0, "Just a test", "Test user story 1", 5 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "af357de0-0c8d-4617-b14a-8ef24959da09", "2894df00-7282-49a8-8cf2-9a210e355dd9", 0, "Just a test", "Test user story 2", 3 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "c6e8e660-3d76-4c90-8e11-ebb68514e6ab", "bc93897d-52b3-4d76-b494-9df321d38cee", 0, "Just a test", "Test user story 3", 11 });
        }
    }
}
