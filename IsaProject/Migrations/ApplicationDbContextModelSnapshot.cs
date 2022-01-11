﻿// <auto-generated />
using System;
using IsaProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IsaProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IsaProject.Models.DTO.AppointmentDTO", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("AverageScore")
                        .HasColumnType("float");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfGuest")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Rules")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("cottageAppointmentDTOs");
                });

            modelBuilder.Entity("IsaProject.Models.Entities.Appointment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DurationDays")
                        .HasColumnType("int");

                    b.Property<long>("EntityID")
                        .HasColumnType("bigint");

                    b.Property<int>("MaxNumberOfPeople")
                        .HasColumnType("int");

                    b.Property<string>("OwnerID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isScheduled")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("EntityID");

                    b.ToTable("Appointments");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Appointment");
                });

            modelBuilder.Entity("IsaProject.Models.Entities.AppointmentTag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AppointmentID")
                        .HasColumnType("bigint");

                    b.Property<bool>("ChoosenByUser")
                        .HasColumnType("bit");

                    b.Property<long>("TagId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentID");

                    b.ToTable("AppointmentTag");
                });

            modelBuilder.Entity("IsaProject.Models.Entities.Entity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("AverageScore")
                        .HasColumnType("float");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PromotionalDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rules")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Entities");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Entity");
                });

            modelBuilder.Entity("IsaProject.Models.Entities.Room", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CottageID")
                        .HasColumnType("bigint");

                    b.Property<int>("NumberOfBeds")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CottageID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("IsaProject.Models.Entities.Ship.NavigationEquipment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ShipId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ShipId");

                    b.ToTable("NavigationEquipment");
                });

            modelBuilder.Entity("IsaProject.Models.Entities.Tag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("AppointmentDTOId")
                        .HasColumnType("bigint");

                    b.Property<long?>("AppointmentId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentDTOId");

                    b.HasIndex("AppointmentId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("IsaProject.Models.Image", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("EntityID")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("ImageByte")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EntityID");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("IsaProject.Models.Users.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Explanation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<int>("Penalty")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ReasonForReject")
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("AspNetUsers");
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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("IsaProject.Models.Entities.FastReservation", b =>
                {
                    b.HasBaseType("IsaProject.Models.Entities.Appointment");

                    b.Property<double>("NewPrice")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("FastReservation");
                });

            modelBuilder.Entity("IsaProject.Models.Entities.Adventure.Adventure", b =>
                {
                    b.HasBaseType("IsaProject.Models.Entities.Entity");

                    b.Property<string>("FishingEquipment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstructorDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Adventure");
                });

            modelBuilder.Entity("IsaProject.Models.Entities.Cottage", b =>
                {
                    b.HasBaseType("IsaProject.Models.Entities.Entity");

                    b.HasDiscriminator().HasValue("Cottage");
                });

            modelBuilder.Entity("IsaProject.Models.Entities.Users.Ship", b =>
                {
                    b.HasBaseType("IsaProject.Models.Entities.Entity");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<double>("EngineNumber")
                        .HasColumnType("float");

                    b.Property<double>("EnginePower")
                        .HasColumnType("float");

                    b.Property<string>("FishingEquipment")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ship_FishingEquipment");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<double>("MaxSpeed")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Ship");
                });

            modelBuilder.Entity("IsaProject.Models.Entities.Appointment", b =>
                {
                    b.HasOne("IsaProject.Models.Entities.Entity", null)
                        .WithMany("Appointments")
                        .HasForeignKey("EntityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IsaProject.Models.Entities.AppointmentTag", b =>
                {
                    b.HasOne("IsaProject.Models.Entities.Appointment", null)
                        .WithMany("appointmentTags")
                        .HasForeignKey("AppointmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IsaProject.Models.Entities.Room", b =>
                {
                    b.HasOne("IsaProject.Models.Entities.Cottage", null)
                        .WithMany("Rooms")
                        .HasForeignKey("CottageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IsaProject.Models.Entities.Ship.NavigationEquipment", b =>
                {
                    b.HasOne("IsaProject.Models.Entities.Users.Ship", null)
                        .WithMany("NavigationEquipments")
                        .HasForeignKey("ShipId");
                });

            modelBuilder.Entity("IsaProject.Models.Entities.Tag", b =>
                {
                    b.HasOne("IsaProject.Models.DTO.AppointmentDTO", null)
                        .WithMany("Tags")
                        .HasForeignKey("AppointmentDTOId");

                    b.HasOne("IsaProject.Models.Entities.Appointment", null)
                        .WithMany("Tags")
                        .HasForeignKey("AppointmentId");
                });

            modelBuilder.Entity("IsaProject.Models.Image", b =>
                {
                    b.HasOne("IsaProject.Models.Entities.Entity", null)
                        .WithMany("Images")
                        .HasForeignKey("EntityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("IsaProject.Models.Users.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("IsaProject.Models.Users.AppUser", null)
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

                    b.HasOne("IsaProject.Models.Users.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("IsaProject.Models.Users.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IsaProject.Models.DTO.AppointmentDTO", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("IsaProject.Models.Entities.Appointment", b =>
                {
                    b.Navigation("appointmentTags");

                    b.Navigation("Tags");
                });

            modelBuilder.Entity("IsaProject.Models.Entities.Entity", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Images");
                });

            modelBuilder.Entity("IsaProject.Models.Entities.Cottage", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("IsaProject.Models.Entities.Users.Ship", b =>
                {
                    b.Navigation("NavigationEquipments");
                });
#pragma warning restore 612, 618
        }
    }
}
