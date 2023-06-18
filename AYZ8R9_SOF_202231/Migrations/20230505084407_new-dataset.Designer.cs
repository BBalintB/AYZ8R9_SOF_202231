﻿// <auto-generated />
using System;
using AYZ8R9_SOF_202231.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AYZ8R9_SOF_202231.Migrations
{
    [DbContext(typeof(SCRUMDbContext))]
    [Migration("20230505084407_new-dataset")]
    partial class newdataset
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AYZ8R9_SOF_202231.Model.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("PhotoContentType")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("PhotoData")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "408b5c67-2ad2-4ed8-91f4-88627ab20a0f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4b1e9b80-a671-4961-b637-b11b7d62efa3",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            FirstName = "Big",
                            LastName = "Boss",
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN@ADMIN.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEHew1oNsril+WzlOBb3HfRQzMrnLsZHIVHD+vWCFk6TeIzUd8QQLv5LZPq0EKYzPWA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "94214fa3-f98f-4ba5-9bf9-469a3704b1e8",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        });
                });

            modelBuilder.Entity("AYZ8R9_SOF_202231.Model.Project", b =>
                {
                    b.Property<string>("ProjectId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ProjectId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectId = "88bac5c3-9a06-4b16-b72e-b0205e8d16ef",
                            OwnerId = "408b5c67-2ad2-4ed8-91f4-88627ab20a0f",
                            ProjectName = "Test Project"
                        });
                });

            modelBuilder.Entity("AYZ8R9_SOF_202231.Model.ProjectAppUser", b =>
                {
                    b.Property<string>("ProjectId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConnectionId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectId", "AppUserId");

                    b.HasIndex("AppUserId");

                    b.ToTable("ProjectAppUsersConnection");

                    b.HasData(
                        new
                        {
                            ProjectId = "88bac5c3-9a06-4b16-b72e-b0205e8d16ef",
                            AppUserId = "408b5c67-2ad2-4ed8-91f4-88627ab20a0f",
                            ConnectionId = "5f7097d6-50bd-4c73-a4f0-4ed83eb66615"
                        });
                });

            modelBuilder.Entity("AYZ8R9_SOF_202231.Model.Sprint", b =>
                {
                    b.Property<string>("SprintId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProjectId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SprintDueDate")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("SprintName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("SprintId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Sprints");

                    b.HasData(
                        new
                        {
                            SprintId = "a6a2110e-8861-44da-9ec4-583057e82dc8",
                            ProjectId = "88bac5c3-9a06-4b16-b72e-b0205e8d16ef",
                            SprintDueDate = "2022.12.14",
                            SprintName = "Test Sprint"
                        },
                        new
                        {
                            SprintId = "f86024d0-8dc2-4ace-834b-6e4e484b4326",
                            ProjectId = "88bac5c3-9a06-4b16-b72e-b0205e8d16ef",
                            SprintDueDate = "2022.12.24",
                            SprintName = "Test Sprint1"
                        },
                        new
                        {
                            SprintId = "f0cafaf6-c765-4e45-a049-a95507d77008",
                            ProjectId = "88bac5c3-9a06-4b16-b72e-b0205e8d16ef",
                            SprintDueDate = "2022.12.30",
                            SprintName = "Test Sprint2"
                        });
                });

            modelBuilder.Entity("AYZ8R9_SOF_202231.Model.UserStory", b =>
                {
                    b.Property<string>("UserStoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SprintId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserStoryDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserStoryName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("UserStoryPriority")
                        .HasColumnType("int");

                    b.HasKey("UserStoryId");

                    b.HasIndex("SprintId");

                    b.HasIndex("UserId");

                    b.ToTable("UserStories");

                    b.HasData(
                        new
                        {
                            UserStoryId = "485d91c4-b9e8-4da5-8382-67a06db957e6",
                            SprintId = "a6a2110e-8861-44da-9ec4-583057e82dc8",
                            Status = 0,
                            UserStoryDescription = "Just a test",
                            UserStoryName = "Test user story 1",
                            UserStoryPriority = 5
                        },
                        new
                        {
                            UserStoryId = "d0d1cb39-b534-4830-bbbf-a494e8d296f0",
                            SprintId = "a6a2110e-8861-44da-9ec4-583057e82dc8",
                            Status = 0,
                            UserStoryDescription = "Just a test",
                            UserStoryName = "Test user story 2",
                            UserStoryPriority = 3
                        },
                        new
                        {
                            UserStoryId = "e19e293f-e818-443f-b7ba-8592795505c0",
                            SprintId = "f86024d0-8dc2-4ace-834b-6e4e484b4326",
                            Status = 0,
                            UserStoryDescription = "Just a test",
                            UserStoryName = "Test user story 3",
                            UserStoryPriority = 11
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "aa645127-1d14-4782-b765-9b44b0465dce",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "eb0f2f83-c811-485f-a2b4-04a623f19229",
                            Name = "Scrum_Master",
                            NormalizedName = "SCRUM_MASTER"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "8fa16004-643d-480c-8260-c8bedb8bbfd0",
                            Name = "Developer",
                            NormalizedName = "DEVELOPER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "408b5c67-2ad2-4ed8-91f4-88627ab20a0f",
                            RoleId = "1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AYZ8R9_SOF_202231.Model.Project", b =>
                {
                    b.HasOne("AYZ8R9_SOF_202231.Model.AppUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("AYZ8R9_SOF_202231.Model.ProjectAppUser", b =>
                {
                    b.HasOne("AYZ8R9_SOF_202231.Model.AppUser", "User")
                        .WithMany("WorkingProjects")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("AYZ8R9_SOF_202231.Model.Project", "Project")
                        .WithMany("ProjectUsers")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AYZ8R9_SOF_202231.Model.Sprint", b =>
                {
                    b.HasOne("AYZ8R9_SOF_202231.Model.Project", "Project")
                        .WithMany("ProjectSprints")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Project");
                });

            modelBuilder.Entity("AYZ8R9_SOF_202231.Model.UserStory", b =>
                {
                    b.HasOne("AYZ8R9_SOF_202231.Model.Sprint", "Sprint")
                        .WithMany("UserStories")
                        .HasForeignKey("SprintId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("AYZ8R9_SOF_202231.Model.AppUser", "User")
                        .WithMany("UserStories")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Sprint");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AYZ8R9_SOF_202231.Model.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AYZ8R9_SOF_202231.Model.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AYZ8R9_SOF_202231.Model.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AYZ8R9_SOF_202231.Model.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AYZ8R9_SOF_202231.Model.AppUser", b =>
                {
                    b.Navigation("UserStories");

                    b.Navigation("WorkingProjects");
                });

            modelBuilder.Entity("AYZ8R9_SOF_202231.Model.Project", b =>
                {
                    b.Navigation("ProjectSprints");

                    b.Navigation("ProjectUsers");
                });

            modelBuilder.Entity("AYZ8R9_SOF_202231.Model.Sprint", b =>
                {
                    b.Navigation("UserStories");
                });
#pragma warning restore 612, 618
        }
    }
}
