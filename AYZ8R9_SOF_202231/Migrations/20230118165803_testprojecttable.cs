using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AYZ8R9_SOF_202231.Migrations
{
    public partial class testprojecttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1f952b17-93e7-4d1f-9bcd-2e6fa1dc86d6" });

            migrationBuilder.DeleteData(
                table: "ProjectAppUsersConnection",
                keyColumns: new[] { "AppUserId", "ProjectId" },
                keyValues: new object[] { "1f952b17-93e7-4d1f-9bcd-2e6fa1dc86d6", "85838fb0-95fc-4d3d-9d5a-8e1cc26099fe" });

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "07e17c02-9f2f-4dd6-be92-fda85fa4cb49");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "5b011a31-f903-4fa9-a4f8-fbda4908b76b");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "bb21966b-44bb-4a87-ad27-00aca9a11eda");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "ea15ffbd-bbdf-4ee6-8b25-01909e846d0b");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "5a0be00c-5bc9-475f-b11c-214cd5661952");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "c1a48244-c304-4116-8dd7-fddb37ebce2e");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: "85838fb0-95fc-4d3d-9d5a-8e1cc26099fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f952b17-93e7-4d1f-9bcd-2e6fa1dc86d6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "558c4a7d-f641-4548-a139-eb84d19b9d43");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "1ce9735b-08ab-4a8d-974d-e290143c0050");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bb189d89-6deb-45b7-9f83-3901a4225286", 0, "ed4a36e4-573d-41f0-b1d9-0355ff049fd7", "admin@admin.com", true, "Big", "Boss", false, null, null, "ADMIN@ADMIN.com", "AQAAAAEAACcQAAAAEBcUrD1J03nimedp0O0HPN/IxBafDhzLOxDriC1B2Aa53W9r1Sw+dUIMe0EmYqwXxQ==", null, false, null, null, "539903b0-7e96-4547-b523-0081d4fa4753", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "bb189d89-6deb-45b7-9f83-3901a4225286" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "OwnerId", "ProjectName" },
                values: new object[] { "e3a14d4e-e67a-490d-bb49-9e2f64d227d5", "bb189d89-6deb-45b7-9f83-3901a4225286", "Test Project" });

            migrationBuilder.InsertData(
                table: "ProjectAppUsersConnection",
                columns: new[] { "AppUserId", "ProjectId", "ConnectionId" },
                values: new object[] { "bb189d89-6deb-45b7-9f83-3901a4225286", "e3a14d4e-e67a-490d-bb49-9e2f64d227d5", "f79b75d7-2b5e-40f9-8691-59b49ca95e7f" });

            migrationBuilder.InsertData(
                table: "Sprints",
                columns: new[] { "SprintId", "ProjectId", "SprintDueDate", "SprintName" },
                values: new object[,]
                {
                    { "4e3a7ed4-6977-4d4a-9f2d-edb989bdf96b", "e3a14d4e-e67a-490d-bb49-9e2f64d227d5", "2022.12.24", "Test Sprint1" },
                    { "f6898f85-4b33-48a9-9528-42f26b96009c", "e3a14d4e-e67a-490d-bb49-9e2f64d227d5", "2022.12.14", "Test Sprint" },
                    { "fa76b81d-9fcc-4eec-bf97-cb0bc1d2f7ac", "e3a14d4e-e67a-490d-bb49-9e2f64d227d5", "2022.12.30", "Test Sprint2" }
                });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "3c9122ab-f3e1-4826-a79b-b28696d96764", "f6898f85-4b33-48a9-9528-42f26b96009c", 0, "Just a test", "Test user story 2", 3 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "85e863e8-5bcb-44ba-8ec4-0e76a0c6712b", "f6898f85-4b33-48a9-9528-42f26b96009c", 0, "Just a test", "Test user story 1", 5 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "acec15a7-67de-4153-b506-e84bcbd48ca8", "4e3a7ed4-6977-4d4a-9f2d-edb989bdf96b", 0, "Just a test", "Test user story 3", 11 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "bb189d89-6deb-45b7-9f83-3901a4225286" });

            migrationBuilder.DeleteData(
                table: "ProjectAppUsersConnection",
                keyColumns: new[] { "AppUserId", "ProjectId" },
                keyValues: new object[] { "bb189d89-6deb-45b7-9f83-3901a4225286", "e3a14d4e-e67a-490d-bb49-9e2f64d227d5" });

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "fa76b81d-9fcc-4eec-bf97-cb0bc1d2f7ac");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "3c9122ab-f3e1-4826-a79b-b28696d96764");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "85e863e8-5bcb-44ba-8ec4-0e76a0c6712b");

            migrationBuilder.DeleteData(
                table: "UserStories",
                keyColumn: "UserStoryId",
                keyValue: "acec15a7-67de-4153-b506-e84bcbd48ca8");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "4e3a7ed4-6977-4d4a-9f2d-edb989bdf96b");

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "SprintId",
                keyValue: "f6898f85-4b33-48a9-9528-42f26b96009c");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: "e3a14d4e-e67a-490d-bb49-9e2f64d227d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb189d89-6deb-45b7-9f83-3901a4225286");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "eb25735e-5925-4e5b-bd0d-162b8327ccc3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d98a1f95-e8a8-4479-9e8b-e0faabf6df9e");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1f952b17-93e7-4d1f-9bcd-2e6fa1dc86d6", 0, "276af19b-7bbc-4b5c-8ac2-60b2651a360e", "admin@admin.com", true, "Big", "Boss", false, null, null, "ADMIN@ADMIN.com", "AQAAAAEAACcQAAAAELb9XWKTA5CfuRC23miBBHl8Q4Z287BJ/DEomqp/ahwSQ/NiA8AsfUM/08DPGM+eMA==", null, false, null, null, "8c60e9c1-5bca-4c18-a8a5-d5f1a96859aa", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1f952b17-93e7-4d1f-9bcd-2e6fa1dc86d6" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "OwnerId", "ProjectName" },
                values: new object[] { "85838fb0-95fc-4d3d-9d5a-8e1cc26099fe", "1f952b17-93e7-4d1f-9bcd-2e6fa1dc86d6", "Test Project" });

            migrationBuilder.InsertData(
                table: "ProjectAppUsersConnection",
                columns: new[] { "AppUserId", "ProjectId", "ConnectionId" },
                values: new object[] { "1f952b17-93e7-4d1f-9bcd-2e6fa1dc86d6", "85838fb0-95fc-4d3d-9d5a-8e1cc26099fe", "41abdb91-a9a2-4da2-b1e0-ade826aa641a" });

            migrationBuilder.InsertData(
                table: "Sprints",
                columns: new[] { "SprintId", "ProjectId", "SprintDueDate", "SprintName" },
                values: new object[,]
                {
                    { "07e17c02-9f2f-4dd6-be92-fda85fa4cb49", "85838fb0-95fc-4d3d-9d5a-8e1cc26099fe", "2022.12.30", "Test Sprint2" },
                    { "5a0be00c-5bc9-475f-b11c-214cd5661952", "85838fb0-95fc-4d3d-9d5a-8e1cc26099fe", "2022.12.24", "Test Sprint1" },
                    { "c1a48244-c304-4116-8dd7-fddb37ebce2e", "85838fb0-95fc-4d3d-9d5a-8e1cc26099fe", "2022.12.14", "Test Sprint" }
                });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "5b011a31-f903-4fa9-a4f8-fbda4908b76b", "c1a48244-c304-4116-8dd7-fddb37ebce2e", 0, "Just a test", "Test user story 2", 3 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "bb21966b-44bb-4a87-ad27-00aca9a11eda", "c1a48244-c304-4116-8dd7-fddb37ebce2e", 0, "Just a test", "Test user story 1", 5 });

            migrationBuilder.InsertData(
                table: "UserStories",
                columns: new[] { "UserStoryId", "SprintId", "Status", "UserStoryDescription", "UserStoryName", "UserStoryPriority" },
                values: new object[] { "ea15ffbd-bbdf-4ee6-8b25-01909e846d0b", "5a0be00c-5bc9-475f-b11c-214cd5661952", 0, "Just a test", "Test user story 3", 11 });
        }
    }
}
