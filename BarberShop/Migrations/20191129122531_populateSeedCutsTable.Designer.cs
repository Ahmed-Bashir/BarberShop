﻿// <auto-generated />
using System;
using Barber_shop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BarberShop.Migrations
{
    [DbContext(typeof(BarberShopDbContext))]
    [Migration("20191129122531_populateSeedCutsTable")]
    partial class populateSeedCutsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BarberShop.Models.Barber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Shop")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Barbers");
                });

            modelBuilder.Entity("BarberShop.Models.Cut", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cuts")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cuts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cuts = "Regular Cut",
                            Price = 15
                        },
                        new
                        {
                            Id = 2,
                            Cuts = "Childrens Cut",
                            Price = 6
                        },
                        new
                        {
                            Id = 3,
                            Cuts = "Beard Trim",
                            Price = 5
                        },
                        new
                        {
                            Id = 4,
                            Cuts = "Mustache Trim",
                            Price = 3
                        },
                        new
                        {
                            Id = 5,
                            Cuts = "Shape Ups",
                            Price = 3
                        });
                });

            modelBuilder.Entity("BarberShop.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BarbersId")
                        .HasColumnType("int");

                    b.Property<int>("CustomersId")
                        .HasColumnType("int");

                    b.Property<int>("CutsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BarbersId");

                    b.HasIndex("CustomersId");

                    b.HasIndex("CutsId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Barber_shop.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomersId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomersId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Barber_shop.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ahmed",
                            Number = 7805,
                            Surname = "Bashir"
                        });
                });

            modelBuilder.Entity("BarberShop.Models.Order", b =>
                {
                    b.HasOne("BarberShop.Models.Barber", "Barbers")
                        .WithMany()
                        .HasForeignKey("BarbersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Barber_shop.Models.Customer", "Customers")
                        .WithMany()
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BarberShop.Models.Cut", "Cuts")
                        .WithMany()
                        .HasForeignKey("CutsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Barber_shop.Models.Booking", b =>
                {
                    b.HasOne("Barber_shop.Models.Customer", "Customers")
                        .WithMany()
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
