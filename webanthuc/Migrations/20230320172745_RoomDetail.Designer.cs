﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webanthuc.Entity;

#nullable disable

namespace webanthuc.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230320172745_RoomDetail")]
    partial class RoomDetail
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("webanthuc.Entity.ApplicationUser", b =>
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

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("webanthuc.Entity.ApplicationUserRoles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("ApplicationUserRole");
                });

            modelBuilder.Entity("webanthuc.Entity.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("webanthuc.Entity.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_Ward")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("id_Ward");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("webanthuc.Entity.detailContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("id_Contact")
                        .HasColumnType("int");

                    b.Property<int?>("id_Restaurant1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("id_Contact");

                    b.HasIndex("id_Restaurant1");

                    b.ToTable("DetailContacts");
                });

            modelBuilder.Entity("webanthuc.Entity.DetailContact1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("id_Contact")
                        .HasColumnType("int");

                    b.Property<int?>("id_Restaurant1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("id_Contact");

                    b.HasIndex("id_Restaurant1");

                    b.ToTable("detailContact1s");
                });

            modelBuilder.Entity("webanthuc.Entity.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Dish");
                });

            modelBuilder.Entity("webanthuc.Entity.Dish1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Dish1");
                });

            modelBuilder.Entity("webanthuc.Entity.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("id_City")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("id_City");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("webanthuc.Entity.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MapData")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("hotels");
                });

            modelBuilder.Entity("webanthuc.Entity.Image_Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("IdDish")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdDish");

                    b.ToTable("images_dishes");
                });

            modelBuilder.Entity("webanthuc.Entity.Image_Dish1", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int?>("IdDish1")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdDish1");

                    b.ToTable("Image_Dish1s");
                });

            modelBuilder.Entity("webanthuc.Entity.Image_Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_Hotel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("id_Hotel");

                    b.ToTable("Image_Hotel");
                });

            modelBuilder.Entity("webanthuc.Entity.Image_Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("IdRestaurant")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdRestaurant");

                    b.ToTable("Image_Restaurants");
                });

            modelBuilder.Entity("webanthuc.Entity.Image_restaurant1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("IdRestaurant1")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdRestaurant1");

                    b.ToTable("Image_Restaurant1s");
                });

            modelBuilder.Entity("webanthuc.Entity.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("id_dish")
                        .HasColumnType("int");

                    b.Property<int?>("id_restaurant")
                        .HasColumnType("int");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("id_dish");

                    b.HasIndex("id_restaurant");

                    b.ToTable("menus");
                });

            modelBuilder.Entity("webanthuc.Entity.Menu1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("id_dish1")
                        .HasColumnType("int");

                    b.Property<int?>("id_restaurant1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("id_dish1");

                    b.HasIndex("id_restaurant1");

                    b.ToTable("menus1");
                });

            modelBuilder.Entity("webanthuc.Entity.Restaurant", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Mapdata")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("about")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("capacity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("restaurants");
                });

            modelBuilder.Entity("webanthuc.Entity.Restaurant1", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Mapdata")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("about")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("capacity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Restaurants1");
                });

            modelBuilder.Entity("webanthuc.Entity.RestaurantDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("id_restaurant")
                        .HasColumnType("int");

                    b.Property<string>("id_user")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("id_restaurant");

                    b.HasIndex("id_user");

                    b.ToTable("restaurantDetails");
                });

            modelBuilder.Entity("webanthuc.Entity.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("id_TypeRoom")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("id_TypeRoom");

                    b.ToTable("rooms");
                });

            modelBuilder.Entity("webanthuc.Entity.RoomDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("Id_Hotels")
                        .HasColumnType("int");

                    b.Property<int>("Id_Rooms")
                        .HasColumnType("int");

                    b.Property<bool>("IsActived")
                        .HasColumnType("bit");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<string>("View")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Hotels");

                    b.HasIndex("Id_Rooms");

                    b.ToTable("RoomDetail");
                });

            modelBuilder.Entity("webanthuc.Entity.TypeRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("typeRooms");
                });

            modelBuilder.Entity("webanthuc.Entity.Ward", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("id_District")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("id_District");

                    b.ToTable("Wards");
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
                    b.HasOne("webanthuc.Entity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("webanthuc.Entity.ApplicationUser", null)
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

                    b.HasOne("webanthuc.Entity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("webanthuc.Entity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webanthuc.Entity.Contact", b =>
                {
                    b.HasOne("webanthuc.Entity.Ward", "Ward")
                        .WithMany()
                        .HasForeignKey("id_Ward")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ward");
                });

            modelBuilder.Entity("webanthuc.Entity.detailContact", b =>
                {
                    b.HasOne("webanthuc.Entity.Contact", "contact")
                        .WithMany()
                        .HasForeignKey("id_Contact");

                    b.HasOne("webanthuc.Entity.Restaurant1", "restaurant1")
                        .WithMany()
                        .HasForeignKey("id_Restaurant1");

                    b.Navigation("contact");

                    b.Navigation("restaurant1");
                });

            modelBuilder.Entity("webanthuc.Entity.DetailContact1", b =>
                {
                    b.HasOne("webanthuc.Entity.Contact", "contact")
                        .WithMany()
                        .HasForeignKey("id_Contact");

                    b.HasOne("webanthuc.Entity.Restaurant1", "restaurant1")
                        .WithMany()
                        .HasForeignKey("id_Restaurant1");

                    b.Navigation("contact");

                    b.Navigation("restaurant1");
                });

            modelBuilder.Entity("webanthuc.Entity.District", b =>
                {
                    b.HasOne("webanthuc.Entity.City", "ctiy")
                        .WithMany()
                        .HasForeignKey("id_City");

                    b.Navigation("ctiy");
                });

            modelBuilder.Entity("webanthuc.Entity.Image_Dish", b =>
                {
                    b.HasOne("webanthuc.Entity.Dish", "Dish")
                        .WithMany("Image_Dishes")
                        .HasForeignKey("IdDish");

                    b.Navigation("Dish");
                });

            modelBuilder.Entity("webanthuc.Entity.Image_Dish1", b =>
                {
                    b.HasOne("webanthuc.Entity.Dish1", "Dish1")
                        .WithMany("Image_Dishes1")
                        .HasForeignKey("IdDish1");

                    b.Navigation("Dish1");
                });

            modelBuilder.Entity("webanthuc.Entity.Image_Hotel", b =>
                {
                    b.HasOne("webanthuc.Entity.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("id_Hotel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("webanthuc.Entity.Image_Restaurant", b =>
                {
                    b.HasOne("webanthuc.Entity.Restaurant", "Restaurant")
                        .WithMany("Image_Restaurant")
                        .HasForeignKey("IdRestaurant");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("webanthuc.Entity.Image_restaurant1", b =>
                {
                    b.HasOne("webanthuc.Entity.Restaurant1", "Restaurant1")
                        .WithMany()
                        .HasForeignKey("IdRestaurant1");

                    b.Navigation("Restaurant1");
                });

            modelBuilder.Entity("webanthuc.Entity.Menu", b =>
                {
                    b.HasOne("webanthuc.Entity.Dish", "Dish")
                        .WithMany()
                        .HasForeignKey("id_dish");

                    b.HasOne("webanthuc.Entity.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("id_restaurant");

                    b.Navigation("Dish");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("webanthuc.Entity.Menu1", b =>
                {
                    b.HasOne("webanthuc.Entity.Dish1", "Dish1")
                        .WithMany()
                        .HasForeignKey("id_dish1");

                    b.HasOne("webanthuc.Entity.Restaurant1", "Restaurant1")
                        .WithMany()
                        .HasForeignKey("id_restaurant1");

                    b.Navigation("Dish1");

                    b.Navigation("Restaurant1");
                });

            modelBuilder.Entity("webanthuc.Entity.RestaurantDetail", b =>
                {
                    b.HasOne("webanthuc.Entity.Restaurant1", "Restaurant1")
                        .WithMany()
                        .HasForeignKey("id_restaurant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webanthuc.Entity.ApplicationUser", "user")
                        .WithMany()
                        .HasForeignKey("id_user")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant1");

                    b.Navigation("user");
                });

            modelBuilder.Entity("webanthuc.Entity.Room", b =>
                {
                    b.HasOne("webanthuc.Entity.TypeRoom", "TypeRoom")
                        .WithMany()
                        .HasForeignKey("id_TypeRoom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeRoom");
                });

            modelBuilder.Entity("webanthuc.Entity.RoomDetail", b =>
                {
                    b.HasOne("webanthuc.Entity.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("Id_Hotels")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webanthuc.Entity.Room", "Room")
                        .WithMany()
                        .HasForeignKey("Id_Rooms")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("webanthuc.Entity.Ward", b =>
                {
                    b.HasOne("webanthuc.Entity.District", "dishtrict")
                        .WithMany()
                        .HasForeignKey("id_District");

                    b.Navigation("dishtrict");
                });

            modelBuilder.Entity("webanthuc.Entity.Dish", b =>
                {
                    b.Navigation("Image_Dishes");
                });

            modelBuilder.Entity("webanthuc.Entity.Dish1", b =>
                {
                    b.Navigation("Image_Dishes1");
                });

            modelBuilder.Entity("webanthuc.Entity.Restaurant", b =>
                {
                    b.Navigation("Image_Restaurant");
                });
#pragma warning restore 612, 618
        }
    }
}
