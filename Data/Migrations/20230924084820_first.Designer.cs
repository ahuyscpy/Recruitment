﻿// <auto-generated />
using System;
using Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(RecruimentWebsiteDbContext))]
    [Migration("20230924084820_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ba1d1035-a824-49c9-9169-d71e3049611b"),
                            ConcurrencyStamp = "0e46037c-f2dc-4859-b70d-51d8c6a25d12",
                            Description = "Company role",
                            Name = "company",
                            NormalizedName = "company"
                        },
                        new
                        {
                            Id = new Guid("e1026231-9435-43ab-8c94-b25d682da123"),
                            ConcurrencyStamp = "f06f9db8-6104-4677-88cd-75da11549961",
                            Description = "User role",
                            Name = "user",
                            NormalizedName = "user"
                        },
                        new
                        {
                            Id = new Guid("670e2b28-d5f4-4264-bdca-e1a113a2e40e"),
                            ConcurrencyStamp = "89a179ff-e9dc-4c61-ae77-b6ee50e3e4cf",
                            Description = "Admin role",
                            Name = "admin",
                            NormalizedName = "admin"
                        });
                });

            modelBuilder.Entity("Data.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSave")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("95e0a3f8-95d6-407a-b625-e2d5fcd557ba"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "521fa893-0afd-4136-926b-c966bb7e2afb",
                            DateCreated = new DateTime(2023, 9, 24, 15, 48, 20, 144, DateTimeKind.Local).AddTicks(2588),
                            Email = "hoangthanh01022000@gmail.com",
                            EmailConfirmed = true,
                            IsSave = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "hoangthanh01022000@gmail.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEMYjP8moPfwK4YFMlPkNHs1gRI+3qAKoK8KtmrLGjgv5QXrK49IwPf4xri6kf0CMaw==",
                            PhoneNumber = "11111",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Data.Entities.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Data.Entities.BranchRecruitment", b =>
                {
                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("RecruimentId")
                        .HasColumnType("int");

                    b.HasKey("BranchId", "RecruimentId");

                    b.HasIndex("RecruimentId");

                    b.ToTable("BranchRecruiments");
                });

            modelBuilder.Entity("Data.Entities.Career", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Careers");
                });

            modelBuilder.Entity("Data.Entities.CareerRecruitment", b =>
                {
                    b.Property<int>("CareerId")
                        .HasColumnType("int");

                    b.Property<int>("RecruimentId")
                        .HasColumnType("int");

                    b.HasKey("CareerId", "RecruimentId");

                    b.HasIndex("RecruimentId");

                    b.ToTable("CareerRecruitments");
                });

            modelBuilder.Entity("Data.Entities.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 24, 15, 48, 20, 107, DateTimeKind.Local).AddTicks(6477));

                    b.Property<string>("Performer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("UserId");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Data.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("RecruimentId")
                        .HasColumnType("int");

                    b.Property<string>("SubcommentId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("RecruimentId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Data.Entities.CompanyAvatar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<long>("FizeSize")
                        .HasColumnType("bigint");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId")
                        .IsUnique();

                    b.ToTable("CompanyAvatars");
                });

            modelBuilder.Entity("Data.Entities.CompanyBranch", b =>
                {
                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BranchId", "CompanyId");

                    b.HasIndex("CompanyId");

                    b.ToTable("CompanyBranches");
                });

            modelBuilder.Entity("Data.Entities.CompanyCoverImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<long>("FizeSize")
                        .HasColumnType("bigint");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId")
                        .IsUnique();

                    b.ToTable("CompanyCoverImages");
                });

            modelBuilder.Entity("Data.Entities.CompanyImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<long>("FizeSize")
                        .HasColumnType("bigint");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("CompanyImages");
                });

            modelBuilder.Entity("Data.Entities.CompanyInformation", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkerNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("UserId");

                    b.ToTable("CompanyInformations");
                });

            modelBuilder.Entity("Data.Entities.CurriculumVitae", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RecruimentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 24, 15, 48, 20, 120, DateTimeKind.Local).AddTicks(6799));

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "RecruimentId");

                    b.HasIndex("RecruimentId");

                    b.ToTable("CurriculumVitaes");
                });

            modelBuilder.Entity("Data.Entities.Follow", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "CompanyId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Follows");
                });

            modelBuilder.Entity("Data.Entities.MailSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Port")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MailSettings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayName = "Admin",
                            Email = "hoangthanh01022000@gmail.com",
                            Host = "smtp.gmail.com",
                            Password = "Thanhngo@123",
                            Port = 587
                        });
                });

            modelBuilder.Entity("Data.Entities.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 24, 15, 48, 20, 124, DateTimeKind.Local).AddTicks(2098));

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Data.Entities.Recruitment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Benefits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DetailedExperience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Education")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experience")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("none");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rank")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Recruitments");
                });

            modelBuilder.Entity("Data.Entities.UserAvatar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<long>("FizeSize")
                        .HasColumnType("bigint");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserAvatars");
                });

            modelBuilder.Entity("Data.Entities.UserInformation", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AcademicLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("UserInformations");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("AppUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("95e0a3f8-95d6-407a-b625-e2d5fcd557ba"),
                            RoleId = new Guid("670e2b28-d5f4-4264-bdca-e1a113a2e40e")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens");
                });

            modelBuilder.Entity("Data.Entities.BranchRecruitment", b =>
                {
                    b.HasOne("Data.Entities.Branch", "Branch")
                        .WithMany("BranchRecruiments")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Recruitment", "Recruitment")
                        .WithMany("BranchRecruiments")
                        .HasForeignKey("RecruimentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.CareerRecruitment", b =>
                {
                    b.HasOne("Data.Entities.Career", "Career")
                        .WithMany("CareerRecruitments")
                        .HasForeignKey("CareerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Recruitment", "Recruitment")
                        .WithMany("CareerRecruitments")
                        .HasForeignKey("RecruimentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.Chat", b =>
                {
                    b.HasOne("Data.Entities.CompanyInformation", "CompanyInformation")
                        .WithMany("Chats")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Data.Entities.UserInformation", "UserInformation")
                        .WithMany("Chats")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.Comment", b =>
                {
                    b.HasOne("Data.Entities.AppUser", "AppUser")
                        .WithMany("Comments")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Data.Entities.Recruitment", "Recruitment")
                        .WithMany("Comments")
                        .HasForeignKey("RecruimentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.CompanyAvatar", b =>
                {
                    b.HasOne("Data.Entities.CompanyInformation", "CompanyInformation")
                        .WithOne("CompanyAvatar")
                        .HasForeignKey("Data.Entities.CompanyAvatar", "CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.CompanyBranch", b =>
                {
                    b.HasOne("Data.Entities.Branch", "Branch")
                        .WithMany("CompanyBranches")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.CompanyInformation", "CompanyInformation")
                        .WithMany("CompanyBranches")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.CompanyCoverImage", b =>
                {
                    b.HasOne("Data.Entities.CompanyInformation", "CompanyInformation")
                        .WithOne("CompanyCoverImage")
                        .HasForeignKey("Data.Entities.CompanyCoverImage", "CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.CompanyImage", b =>
                {
                    b.HasOne("Data.Entities.CompanyInformation", "CompanyInformation")
                        .WithMany("CompanyImages")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.CompanyInformation", b =>
                {
                    b.HasOne("Data.Entities.AppUser", "AppUser")
                        .WithOne("CompanyInformation")
                        .HasForeignKey("Data.Entities.CompanyInformation", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.CurriculumVitae", b =>
                {
                    b.HasOne("Data.Entities.Recruitment", "Recruitment")
                        .WithMany("CurriculumVitaes")
                        .HasForeignKey("RecruimentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Data.Entities.UserInformation", "UserInformation")
                        .WithMany("CurriculumVitaes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.Follow", b =>
                {
                    b.HasOne("Data.Entities.CompanyInformation", "CompanyInformation")
                        .WithMany("Follows")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Data.Entities.UserInformation", "UserInformation")
                        .WithMany("Follows")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.Notification", b =>
                {
                    b.HasOne("Data.Entities.AppUser", "AppUser")
                        .WithMany("Notifications")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.Recruitment", b =>
                {
                    b.HasOne("Data.Entities.CompanyInformation", "CompanyInformation")
                        .WithMany("Recruitments")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.UserAvatar", b =>
                {
                    b.HasOne("Data.Entities.UserInformation", "UserInformation")
                        .WithOne("UserAvatar")
                        .HasForeignKey("Data.Entities.UserAvatar", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.UserInformation", b =>
                {
                    b.HasOne("Data.Entities.AppUser", "AppUser")
                        .WithOne("UserInformation")
                        .HasForeignKey("Data.Entities.UserInformation", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
