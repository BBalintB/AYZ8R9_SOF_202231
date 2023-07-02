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
    [Migration("20230130113444_mergemigration")]
    partial class mergemigration
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
                            Id = "24b4fea0-490e-4695-bb8a-4edb4105bb07",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "10bf0f45-d596-419b-bf12-2def7a9a7e11",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            FirstName = "Big",
                            LastName = "Boss",
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN@ADMIN.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEHWF0dU6gizrMsrmDNbr05WS61srt50Sxmk371zLt3aLSIsAORrBIMwZl9IhoK0gog==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "62aade1a-6dc9-43b0-a4e7-53ff15c140c0",
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
                            ProjectId = "e38d0daf-c878-42e9-ac4c-a485bfd3a77b",
                            OwnerId = "24b4fea0-490e-4695-bb8a-4edb4105bb07",
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
                            ProjectId = "e38d0daf-c878-42e9-ac4c-a485bfd3a77b",
                            AppUserId = "24b4fea0-490e-4695-bb8a-4edb4105bb07",
                            ConnectionId = "b7ee27dc-4c1f-445c-90f7-95a90b719f80"
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
                            SprintId = "bcee3f9d-06c6-41b7-9c11-c15074466399",
                            ProjectId = "e38d0daf-c878-42e9-ac4c-a485bfd3a77b",
                            SprintDueDate = "2022.12.14",
                            SprintName = "Test Sprint"
                        },
                        new
                        {
                            SprintId = "f38492e9-d82f-4d82-b5f6-774818b25212",
                            ProjectId = "e38d0daf-c878-42e9-ac4c-a485bfd3a77b",
                            SprintDueDate = "2022.12.24",
                            SprintName = "Test Sprint1"
                        },
                        new
                        {
                            SprintId = "71f22f40-b04b-4535-9ea9-7cddfc785257",
                            ProjectId = "e38d0daf-c878-42e9-ac4c-a485bfd3a77b",
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
                            UserStoryId = "e8b01434-4a64-45a8-9222-0e8880ad8be1",
                            SprintId = "bcee3f9d-06c6-41b7-9c11-c15074466399",
                            Status = 0,
                            UserStoryDescription = "Just a test",
                            UserStoryName = "Test user story 1",
                            UserStoryPriority = 5
                        },
                        new
                        {
                            UserStoryId = "5938b15f-cab7-4424-8285-472ebefc6638",
                            SprintId = "bcee3f9d-06c6-41b7-9c11-c15074466399",
                            Status = 0,
                            UserStoryDescription = "Just a test",
                            UserStoryName = "Test user story 2",
                            UserStoryPriority = 3
                        },
                        new
                        {
                            UserStoryId = "82a74005-892a-45a5-aac6-2efea8ae13a1",
                            SprintId = "f38492e9-d82f-4d82-b5f6-774818b25212",
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
                            ConcurrencyStamp = "c5ddbddc-1f35-4c92-95bd-a3dd9bcdb73f",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "e8e5a889-eff7-4182-a6fd-cd86602a7806",
                            Name = "Scrum_Master",
                            NormalizedName = "SCRUM_MASTER"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "aec4c6a0-1668-4862-b3fc-221e69a95737",
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
                            UserId = "24b4fea0-490e-4695-bb8a-4edb4105bb07",
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