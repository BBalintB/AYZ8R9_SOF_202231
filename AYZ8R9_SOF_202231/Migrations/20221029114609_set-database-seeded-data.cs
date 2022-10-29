using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AYZ8R9_SOF_202231.Migrations
{
    public partial class setdatabaseseededdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectAppUsersConnection",
                keyColumns: new[] { "AppUserId", "ProjectId" },
                keyValues: new object[] { "5bc7a3cd-0013-475d-b274-0a0f6f38f19d", "e9859847-955d-4a3a-853a-c79eeb208ea1" });

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "49d536f5-88cf-456f-9a2a-e4c98e893091");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "4b15de44-312d-4742-a184-1a25e1ee7cbf");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "76a02117-a8b9-4203-995b-a291e09f9f9b");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "99de54c8-03a7-43b6-a579-2960784438c7");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "1b223621-ac0d-4c67-a14d-85632be3fd71");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "aa54b9ff-d43b-418e-9326-c7cd059c8a9c");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: "e9859847-955d-4a3a-853a-c79eeb208ea1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bc7a3cd-0013-475d-b274-0a0f6f38f19d");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5bc7a3cd-0013-475d-b274-0a0f6f38f19d", 0, "4caaf443-bd38-472d-b2cc-165a29d8b34d", "admin@admin.com", true, "Big", "Boss", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEDTTD30LUxBPuiNaDisR21aEmqbNW5l/n05tYshnEE+iUqeivnKMGCXN2uPQp9LrGw==", null, false, null, null, "e7a9df78-507e-4a48-bd0e-a6748bbf09ee", false, "admin" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "OwnerId", "ProjectName" },
                values: new object[] { "e9859847-955d-4a3a-853a-c79eeb208ea1", "5bc7a3cd-0013-475d-b274-0a0f6f38f19d", "Test Project" });

            migrationBuilder.InsertData(
                table: "ProjectAppUsersConnection",
                columns: new[] { "AppUserId", "ProjectId" },
                values: new object[] { "5bc7a3cd-0013-475d-b274-0a0f6f38f19d", "e9859847-955d-4a3a-853a-c79eeb208ea1" });

            migrationBuilder.InsertData(
                table: "Sprints",
                columns: new[] { "SprintId", "ProjectId", "SprintDueDate", "SprintName" },
                values: new object[,]
                {
                    { "1b223621-ac0d-4c67-a14d-85632be3fd71", "e9859847-955d-4a3a-853a-c79eeb208ea1", "2022.12.14", "Test Sprint" },
                    { "49d536f5-88cf-456f-9a2a-e4c98e893091", "e9859847-955d-4a3a-853a-c79eeb208ea1", "2022.12.30", "Test Sprint2" },
                    { "aa54b9ff-d43b-418e-9326-c7cd059c8a9c", "e9859847-955d-4a3a-853a-c79eeb208ea1", "2022.12.24", "Test Sprint1" }
                });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "4b15de44-312d-4742-a184-1a25e1ee7cbf", "1b223621-ac0d-4c67-a14d-85632be3fd71", 0, "Just a test", "Test user story 2", 0 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "76a02117-a8b9-4203-995b-a291e09f9f9b", "aa54b9ff-d43b-418e-9326-c7cd059c8a9c", 0, "Just a test", "Test user story 3", 0 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "99de54c8-03a7-43b6-a579-2960784438c7", "1b223621-ac0d-4c67-a14d-85632be3fd71", 0, "Just a test", "Test user story 1", 0 });
        }
    }
}
