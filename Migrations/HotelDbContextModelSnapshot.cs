﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hotel.Data;

#nullable disable

namespace hotel.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    partial class HotelDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("hotel.Entities.HotelRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AmoundOfBed")
                        .HasColumnType("int");

                    b.Property<int>("AmoundOfPeople")
                        .HasColumnType("int");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Flour")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HotelRooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AmoundOfBed = 1,
                            AmoundOfPeople = 2,
                            Discount = 7m,
                            Flour = 1,
                            Number = 101,
                            Price = 1400m,
                            Rating = 3
                        },
                        new
                        {
                            Id = 2,
                            AmoundOfBed = 3,
                            AmoundOfPeople = 3,
                            Discount = 3m,
                            Flour = 2,
                            Number = 201,
                            Price = 1500m,
                            Rating = 5
                        },
                        new
                        {
                            Id = 3,
                            AmoundOfBed = 2,
                            AmoundOfPeople = 2,
                            Discount = 0m,
                            Flour = 2,
                            Number = 202,
                            Price = 1250m,
                            Rating = 3
                        },
                        new
                        {
                            Id = 4,
                            AmoundOfBed = 1,
                            AmoundOfPeople = 1,
                            Discount = 4m,
                            Flour = 2,
                            Number = 203,
                            Price = 1130m,
                            Rating = 3
                        },
                        new
                        {
                            Id = 5,
                            AmoundOfBed = 2,
                            AmoundOfPeople = 4,
                            Discount = 1m,
                            Flour = 3,
                            Number = 301,
                            Price = 1376m,
                            Rating = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}