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
    [Migration("20230302092003_edittbRestaurant2")]
    partial class edittbRestaurant2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

            modelBuilder.Entity("webanthuc.Entity.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("id_dish")
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

            modelBuilder.Entity("webanthuc.Entity.Image_Dish", b =>
                {
                    b.HasOne("webanthuc.Entity.Dish", "Dish")
                        .WithMany("Image_Dishes")
                        .HasForeignKey("IdDish");

                    b.Navigation("Dish");
                });

            modelBuilder.Entity("webanthuc.Entity.Image_Restaurant", b =>
                {
                    b.HasOne("webanthuc.Entity.Restaurant", "Restaurant")
                        .WithMany("Image_Restaurant")
                        .HasForeignKey("IdRestaurant");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("webanthuc.Entity.Menu", b =>
                {
                    b.HasOne("webanthuc.Entity.Dish", "Dish")
                        .WithMany()
                        .HasForeignKey("id_dish")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webanthuc.Entity.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("id_restaurant");

                    b.Navigation("Dish");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("webanthuc.Entity.Dish", b =>
                {
                    b.Navigation("Image_Dishes");
                });

            modelBuilder.Entity("webanthuc.Entity.Restaurant", b =>
                {
                    b.Navigation("Image_Restaurant");
                });
#pragma warning restore 612, 618
        }
    }
}