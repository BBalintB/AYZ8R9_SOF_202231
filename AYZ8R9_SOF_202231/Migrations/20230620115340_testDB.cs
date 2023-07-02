using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AYZ8R9_SOF_202231.Migrations
{
    public partial class testDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "08c1bf1e-93e8-4014-8a0c-034c1103ae52");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2eb471a8-7900-4b20-b50f-cbbf0110262c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "4cc977dd-7cb9-445b-80a0-465b185e81e1");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c25e15fc-8ee2-41c9-be82-9823be744e13", 0, "d219baec-49eb-48f4-adcb-2168d62033c8", "admin@admin.com", true, "Big", "Boss", false, null, null, "ADMIN@ADMIN.com", "AQAAAAEAACcQAAAAEL/QVEpm9pwaeCFfaOXp+DD25abAb8VtD9nG/CB/FS1ZGbloOUl3ZWr4eW4HR9O5Gw==", null, false, null, null, "dda8746a-444c-4ea1-afac-4cbe04c4ca45", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "c25e15fc-8ee2-41c9-be82-9823be744e13" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "OwnerId", "ProjectName" },
                values: new object[] { "decffb60-ee7c-40a1-afc4-4b99bdc5663e", "c25e15fc-8ee2-41c9-be82-9823be744e13", "Test Project" });

            migrationBuilder.InsertData(
                table: "ProjectAppUsersConnection",
                columns: new[] { "AppUserId", "ProjectId", "ConnectionId" },
                values: new object[] { "c25e15fc-8ee2-41c9-be82-9823be744e13", "decffb60-ee7c-40a1-afc4-4b99bdc5663e", "4e40fbf0-82aa-4594-9f5e-82b59ea8a2d2" });

            migrationBuilder.InsertData(
                table: "Sprints",
                columns: new[] { "SprintId", "ProjectId", "SprintDueDate", "SprintName" },
                values: new object[,]
                {
                    { "7767f6a6-de27-41c2-9702-3969b59cd093", "decffb60-ee7c-40a1-afc4-4b99bdc5663e", "2022.12.24", "Test Sprint1" },
                    { "925736e9-8a1b-4f64-8ae2-c99743899944", "decffb60-ee7c-40a1-afc4-4b99bdc5663e", "2022.12.14", "Test Sprint" },
                    { "d50dedee-b34d-4c74-ac9c-8e6af3aeeeb7", "decffb60-ee7c-40a1-afc4-4b99bdc5663e", "2022.12.30", "Test Sprint2" }
                });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserId", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "6ab2c194-90c5-4ac7-a471-f3543cd0068a", "7767f6a6-de27-41c2-9702-3969b59cd093", 0, null, "Just a test", "Test user story 3", 11 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserId", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "aef2684c-4806-497c-8441-134d291a4e92", "925736e9-8a1b-4f64-8ae2-c99743899944", 0, null, "Just a test", "Test user story 1", 5 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserId", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "ba0ea91d-f5ad-4c6f-97fd-b251b2b4399f", "925736e9-8a1b-4f64-8ae2-c99743899944", 0, null, "Just a test", "Test user story 2", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "c25e15fc-8ee2-41c9-be82-9823be744e13" });

            migrationBuilder.DeleteData(
                table: "ProjectAppUsersConnection",
                keyColumns: new[] { "AppUserId", "ProjectId" },
                keyValues: new object[] { "c25e15fc-8ee2-41c9-be82-9823be744e13", "decffb60-ee7c-40a1-afc4-4b99bdc5663e" });

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "d50dedee-b34d-4c74-ac9c-8e6af3aeeeb7");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "6ab2c194-90c5-4ac7-a471-f3543cd0068a");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "aef2684c-4806-497c-8441-134d291a4e92");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "ba0ea91d-f5ad-4c6f-97fd-b251b2b4399f");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "7767f6a6-de27-41c2-9702-3969b59cd093");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "925736e9-8a1b-4f64-8ae2-c99743899944");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: "decffb60-ee7c-40a1-afc4-4b99bdc5663e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c25e15fc-8ee2-41c9-be82-9823be744e13");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
    }
}
