using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AYZ8R9_SOF_202231.Migrations
{
    public partial class newdataset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "24b4fea0-490e-4695-bb8a-4edb4105bb07" });

            migrationBuilder.DeleteData(
                table: "ProjectAppUsersConnection",
                keyColumns: new[] { "AppUserId", "ProjectId" },
                keyValues: new object[] { "24b4fea0-490e-4695-bb8a-4edb4105bb07", "e38d0daf-c878-42e9-ac4c-a485bfd3a77b" });

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "71f22f40-b04b-4535-9ea9-7cddfc785257");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "5938b15f-cab7-4424-8285-472ebefc6638");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "82a74005-892a-45a5-aac6-2efea8ae13a1");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "e8b01434-4a64-45a8-9222-0e8880ad8be1");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "bcee3f9d-06c6-41b7-9c11-c15074466399");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "f38492e9-d82f-4d82-b5f6-774818b25212");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: "e38d0daf-c878-42e9-ac4c-a485bfd3a77b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24b4fea0-490e-4695-bb8a-4edb4105bb07");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "aa645127-1d14-4782-b765-9b44b0465dce");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "eb0f2f83-c811-485f-a2b4-04a623f19229");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "8fa16004-643d-480c-8260-c8bedb8bbfd0");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "408b5c67-2ad2-4ed8-91f4-88627ab20a0f", 0, "4b1e9b80-a671-4961-b637-b11b7d62efa3", "admin@admin.com", true, "Big", "Boss", false, null, null, "ADMIN@ADMIN.com", "AQAAAAEAACcQAAAAEHew1oNsril+WzlOBb3HfRQzMrnLsZHIVHD+vWCFk6TeIzUd8QQLv5LZPq0EKYzPWA==", null, false, null, null, "94214fa3-f98f-4ba5-9bf9-469a3704b1e8", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "408b5c67-2ad2-4ed8-91f4-88627ab20a0f" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "OwnerId", "ProjectName" },
                values: new object[] { "88bac5c3-9a06-4b16-b72e-b0205e8d16ef", "408b5c67-2ad2-4ed8-91f4-88627ab20a0f", "Test Project" });

            migrationBuilder.InsertData(
                table: "ProjectAppUsersConnection",
                columns: new[] { "AppUserId", "ProjectId", "ConnectionId" },
                values: new object[] { "408b5c67-2ad2-4ed8-91f4-88627ab20a0f", "88bac5c3-9a06-4b16-b72e-b0205e8d16ef", "5f7097d6-50bd-4c73-a4f0-4ed83eb66615" });

            migrationBuilder.InsertData(
                table: "Sprints",
                columns: new[] { "SprintId", "ProjectId", "SprintDueDate", "SprintName" },
                values: new object[,]
                {
                    { "a6a2110e-8861-44da-9ec4-583057e82dc8", "88bac5c3-9a06-4b16-b72e-b0205e8d16ef", "2022.12.14", "Test Sprint" },
                    { "f0cafaf6-c765-4e45-a049-a95507d77008", "88bac5c3-9a06-4b16-b72e-b0205e8d16ef", "2022.12.30", "Test Sprint2" },
                    { "f86024d0-8dc2-4ace-834b-6e4e484b4326", "88bac5c3-9a06-4b16-b72e-b0205e8d16ef", "2022.12.24", "Test Sprint1" }
                });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserId", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "485d91c4-b9e8-4da5-8382-67a06db957e6", "a6a2110e-8861-44da-9ec4-583057e82dc8", 0, null, "Just a test", "Test user story 1", 5 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserId", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "d0d1cb39-b534-4830-bbbf-a494e8d296f0", "a6a2110e-8861-44da-9ec4-583057e82dc8", 0, null, "Just a test", "Test user story 2", 3 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserId", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "e19e293f-e818-443f-b7ba-8592795505c0", "f86024d0-8dc2-4ace-834b-6e4e484b4326", 0, null, "Just a test", "Test user story 3", 11 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "408b5c67-2ad2-4ed8-91f4-88627ab20a0f" });

            migrationBuilder.DeleteData(
                table: "ProjectAppUsersConnection",
                keyColumns: new[] { "AppUserId", "ProjectId" },
                keyValues: new object[] { "408b5c67-2ad2-4ed8-91f4-88627ab20a0f", "88bac5c3-9a06-4b16-b72e-b0205e8d16ef" });

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "f0cafaf6-c765-4e45-a049-a95507d77008");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "485d91c4-b9e8-4da5-8382-67a06db957e6");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "d0d1cb39-b534-4830-bbbf-a494e8d296f0");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "e19e293f-e818-443f-b7ba-8592795505c0");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "a6a2110e-8861-44da-9ec4-583057e82dc8");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "f86024d0-8dc2-4ace-834b-6e4e484b4326");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: "88bac5c3-9a06-4b16-b72e-b0205e8d16ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408b5c67-2ad2-4ed8-91f4-88627ab20a0f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c5ddbddc-1f35-4c92-95bd-a3dd9bcdb73f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "e8e5a889-eff7-4182-a6fd-cd86602a7806");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "aec4c6a0-1668-4862-b3fc-221e69a95737");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "24b4fea0-490e-4695-bb8a-4edb4105bb07", 0, "10bf0f45-d596-419b-bf12-2def7a9a7e11", "admin@admin.com", true, "Big", "Boss", false, null, null, "ADMIN@ADMIN.com", "AQAAAAEAACcQAAAAEHWF0dU6gizrMsrmDNbr05WS61srt50Sxmk371zLt3aLSIsAORrBIMwZl9IhoK0gog==", null, false, null, null, "62aade1a-6dc9-43b0-a4e7-53ff15c140c0", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "24b4fea0-490e-4695-bb8a-4edb4105bb07" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "OwnerId", "ProjectName" },
                values: new object[] { "e38d0daf-c878-42e9-ac4c-a485bfd3a77b", "24b4fea0-490e-4695-bb8a-4edb4105bb07", "Test Project" });

            migrationBuilder.InsertData(
                table: "ProjectAppUsersConnection",
                columns: new[] { "AppUserId", "ProjectId", "ConnectionId" },
                values: new object[] { "24b4fea0-490e-4695-bb8a-4edb4105bb07", "e38d0daf-c878-42e9-ac4c-a485bfd3a77b", "b7ee27dc-4c1f-445c-90f7-95a90b719f80" });

            migrationBuilder.InsertData(
                table: "Sprints",
                columns: new[] { "SprintId", "ProjectId", "SprintDueDate", "SprintName" },
                values: new object[,]
                {
                    { "71f22f40-b04b-4535-9ea9-7cddfc785257", "e38d0daf-c878-42e9-ac4c-a485bfd3a77b", "2022.12.30", "Test Sprint2" },
                    { "bcee3f9d-06c6-41b7-9c11-c15074466399", "e38d0daf-c878-42e9-ac4c-a485bfd3a77b", "2022.12.14", "Test Sprint" },
                    { "f38492e9-d82f-4d82-b5f6-774818b25212", "e38d0daf-c878-42e9-ac4c-a485bfd3a77b", "2022.12.24", "Test Sprint1" }
                });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserId", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "5938b15f-cab7-4424-8285-472ebefc6638", "bcee3f9d-06c6-41b7-9c11-c15074466399", 0, null, "Just a test", "Test user story 2", 3 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserId", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "82a74005-892a-45a5-aac6-2efea8ae13a1", "f38492e9-d82f-4d82-b5f6-774818b25212", 0, null, "Just a test", "Test user story 3", 11 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserId", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "e8b01434-4a64-45a8-9222-0e8880ad8be1", "bcee3f9d-06c6-41b7-9c11-c15074466399", 0, null, "Just a test", "Test user story 1", 5 });
        }
    }
}
