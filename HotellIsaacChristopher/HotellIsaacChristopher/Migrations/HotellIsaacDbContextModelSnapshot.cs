﻿// <auto-generated />
using System;
using HotellIsaacChristopher.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotellIsaacChristopher.Migrations
{
    [DbContext(typeof(HotellIsaacDbContext))]
    partial class HotellIsaacDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HotellIsaacChristopher.Models.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<int>("GuestID")
                        .HasColumnType("int");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.HasKey("BookingID");

                    b.HasIndex("GuestID");

                    b.HasIndex("RoomID");

                    b.ToTable("Bookings");

                    b.HasData(
                        new
                        {
                            BookingID = 1,
                            CheckIn = new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckOut = new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestID = 1,
                            RoomID = 1
                        });
                });

            modelBuilder.Entity("HotellIsaacChristopher.Models.Guest", b =>
                {
                    b.Property<int>("GuestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookingID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderID")
                        .HasColumnType("int");

                    b.HasKey("GuestID");

                    b.HasIndex("OrderID")
                        .IsUnique()
                        .HasFilter("[OrderID] IS NOT NULL");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("HotellIsaacChristopher.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GuestID")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("OrderID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("HotellIsaacChristopher.Models.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookingID")
                        .HasColumnType("int");

                    b.Property<bool>("NeedsCleaning")
                        .HasColumnType("bit");

                    b.Property<int>("NoOfBeds")
                        .HasColumnType("int");

                    b.Property<double>("PricePerNight")
                        .HasColumnType("float");

                    b.Property<string>("RoomName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomID");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            RoomID = 1,
                            NeedsCleaning = false,
                            NoOfBeds = 1,
                            PricePerNight = 499.0,
                            RoomName = "Room 1"
                        },
                        new
                        {
                            RoomID = 2,
                            NeedsCleaning = false,
                            NoOfBeds = 1,
                            PricePerNight = 499.0,
                            RoomName = "Room 2"
                        },
                        new
                        {
                            RoomID = 3,
                            NeedsCleaning = false,
                            NoOfBeds = 1,
                            PricePerNight = 499.0,
                            RoomName = "Room 3"
                        },
                        new
                        {
                            RoomID = 4,
                            NeedsCleaning = false,
                            NoOfBeds = 1,
                            PricePerNight = 499.0,
                            RoomName = "Room 4"
                        },
                        new
                        {
                            RoomID = 5,
                            NeedsCleaning = false,
                            NoOfBeds = 1,
                            PricePerNight = 499.0,
                            RoomName = "Room 5"
                        },
                        new
                        {
                            RoomID = 6,
                            NeedsCleaning = false,
                            NoOfBeds = 2,
                            PricePerNight = 699.0,
                            RoomName = "Room 6"
                        },
                        new
                        {
                            RoomID = 7,
                            NeedsCleaning = false,
                            NoOfBeds = 2,
                            PricePerNight = 699.0,
                            RoomName = "Room 7"
                        },
                        new
                        {
                            RoomID = 8,
                            NeedsCleaning = false,
                            NoOfBeds = 2,
                            PricePerNight = 699.0,
                            RoomName = "Room 8"
                        },
                        new
                        {
                            RoomID = 9,
                            NeedsCleaning = false,
                            NoOfBeds = 2,
                            PricePerNight = 699.0,
                            RoomName = "Room 9"
                        },
                        new
                        {
                            RoomID = 10,
                            NeedsCleaning = false,
                            NoOfBeds = 2,
                            PricePerNight = 699.0,
                            RoomName = "Room 10"
                        });
                });

            modelBuilder.Entity("HotellIsaacChristopher.Models.Booking", b =>
                {
                    b.HasOne("HotellIsaacChristopher.Models.Guest", "Guest")
                        .WithMany("Booking")
                        .HasForeignKey("GuestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotellIsaacChristopher.Models.Room", "Room")
                        .WithMany("Bookings")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guest");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("HotellIsaacChristopher.Models.Guest", b =>
                {
                    b.HasOne("HotellIsaacChristopher.Models.Order", "Order")
                        .WithOne("Guest")
                        .HasForeignKey("HotellIsaacChristopher.Models.Guest", "OrderID");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("HotellIsaacChristopher.Models.Guest", b =>
                {
                    b.Navigation("Booking");
                });

            modelBuilder.Entity("HotellIsaacChristopher.Models.Order", b =>
                {
                    b.Navigation("Guest");
                });

            modelBuilder.Entity("HotellIsaacChristopher.Models.Room", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
