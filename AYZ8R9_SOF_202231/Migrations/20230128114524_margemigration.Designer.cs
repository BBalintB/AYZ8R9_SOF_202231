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
    [Migration("20230128114524_margemigration")]
    partial class margemigration
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
                            Id = "64959a98-e31f-4d86-ac63-1cce79235550",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "99834752-2aae-4414-9357-2d9cec3e6028",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            FirstName = "Big",
                            LastName = "Boss",
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN@ADMIN.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEPwVMZ4Cvtjo8nmnBjYwqRSYTT5dNr2A8MVncdI1RQK5ddOTB24Pw6wfw3Ey43DOcQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "dace7d7c-f80f-4a51-9d3c-fe89e596f259",
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
                            ProjectId = "1789a7ef-fb93-4cab-a85e-3d6050026a26",
                            OwnerId = "64959a98-e31f-4d86-ac63-1cce79235550",
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
                            ProjectId = "1789a7ef-fb93-4cab-a85e-3d6050026a26",
                            AppUserId = "64959a98-e31f-4d86-ac63-1cce79235550",
                            ConnectionId = "fe60d1f3-cb53-4c22-adb3-d58b4377f9e1"
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
                            SprintId = "8555e016-fac0-42eb-97ab-f08cb98dae26",
                            ProjectId = "1789a7ef-fb93-4cab-a85e-3d6050026a26",
                            SprintDueDate = "2022.12.14",
                            SprintName = "Test Sprint"
                        },
                        new
                        {
                            SprintId = "0be36f37-6307-41cc-9664-cd65ec923c08",
                            ProjectId = "1789a7ef-fb93-4cab-a85e-3d6050026a26",
                            SprintDueDate = "2022.12.24",
                            SprintName = "Test Sprint1"
                        },
                        new
                        {
                            SprintId = "99252fdf-6dda-4c99-a86a-8ea155cf1a48",
                            ProjectId = "1789a7ef-fb93-4cab-a85e-3d6050026a26",
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

                    b.ToTable("UserStories");

                    b.HasData(
                        new
                        {
                            UserStoryId = "dded4d55-5a45-4f74-949f-a7ccdb28d45b",
                            SprintId = "8555e016-fac0-42eb-97ab-f08cb98dae26",
                            Status = 0,
                            UserStoryDescription = "Just a test",
                            UserStoryName = "Test user story 1",
                            UserStoryPriority = 5
                        },
                        new
                        {
                            UserStoryId = "0e1fe1d8-b3fd-4fb7-b189-d6bacc0b4c4f",
                            SprintId = "8555e016-fac0-42eb-97ab-f08cb98dae26",
                            Status = 0,
                            UserStoryDescription = "Just a test",
                            UserStoryName = "Test user story 2",
                            UserStoryPriority = 3
                        },
                        new
                        {
                            UserStoryId = "6ace01c6-7341-4ca5-bd56-7a0c6c1ca66c",
                            SprintId = "0be36f37-6307-41cc-9664-cd65ec923c08",
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
                            ConcurrencyStamp = "0fe3b626-9391-4c2c-8b17-e692588b01ff",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "f204f12a-274a-45c0-93f4-5efc51077059",
                            Name = "Scrum_Master",
                            NormalizedName = "SCRUM_MASTER"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "37fcce2b-ee39-4eb4-b5eb-cc8c5fe65e95",
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
                            UserId = "64959a98-e31f-4d86-ac63-1cce79235550",
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
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Sprint");
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