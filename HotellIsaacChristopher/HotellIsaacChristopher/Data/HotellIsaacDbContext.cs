using HotellIsaacChristopher.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotellIsaacChristopher.Data
{
    public class HotellIsaacDbContext : DbContext
    {
        public HotellIsaacDbContext(DbContextOptions<HotellIsaacDbContext> options) : base(options)
        {
        }



        public DbSet<Guest> Guests { get; set; }
        //public DbSet<Employees> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Guest>()
                 .HasOne(a => a.Order)
                 .WithOne(a => a.Guest);

            modelBuilder.Entity<Guest>()
                .HasMany(a => a.Booking)
                .WithOne(b => b.Guest);

            modelBuilder.Entity<Order>()
                .HasOne(a => a.Guest)
                .WithOne(b => b.Order)
                .HasForeignKey<Guest>(c => c.OrderID);

            modelBuilder.Entity<Room>()
                .HasMany(a => a.Bookings)
                .WithOne(b => b.Room);

            modelBuilder.Entity<Booking>()
                .HasOne(a => a.Guest)
                .WithMany(b => b.Booking);

            modelBuilder.Entity<Booking>()
                .HasOne(a => a.Room)
                .WithMany(b => b.Bookings);

            //modelBuilder.Entity<Anställd>()
            //    .HasData(new Anställd { Id = 1, Förnamn = "Anders", Efternamn = "Anka" },
            //                        new Anställd { Id = 2, Förnamn = "Bertil", Efternamn = "Bengtsson", },
            //                        new Anställd { Id = 3, Förnamn = "Ceasar", Efternamn = "Cello", });
            modelBuilder.Entity<Room>()
                .HasData(
                new Room { RoomID = 1, RoomName = "Room 1", NoOfBeds = 1, NeedsCleaning = false, PricePerNight = 499 },
                new Room { RoomID = 2, RoomName = "Room 2", NoOfBeds = 1, NeedsCleaning = false, PricePerNight = 499  },
                new Room { RoomID = 3, RoomName = "Room 3", NoOfBeds = 1, NeedsCleaning = false, PricePerNight = 499  },
                new Room { RoomID = 4, RoomName = "Room 4", NoOfBeds = 1, NeedsCleaning = false, PricePerNight = 499  },
                new Room { RoomID = 5, RoomName = "Room 5", NoOfBeds = 1, NeedsCleaning = false, PricePerNight = 499  },
                new Room { RoomID = 6, RoomName = "Room 6", NoOfBeds = 2, NeedsCleaning = false, PricePerNight = 699  },
                new Room { RoomID = 7, RoomName = "Room 7", NoOfBeds = 2, NeedsCleaning = false, PricePerNight = 699  },
                new Room { RoomID = 8, RoomName = "Room 8", NoOfBeds = 2, NeedsCleaning = false, PricePerNight = 699  },
                new Room { RoomID = 9, RoomName = "Room 9", NoOfBeds = 2, NeedsCleaning = false, PricePerNight = 699 },
                new Room { RoomID = 10, RoomName = "Room 10", NoOfBeds = 2, NeedsCleaning = false, PricePerNight = 699 }
                );
            //fler rum
            modelBuilder.Entity<Booking>()
                .HasData(new Booking { BookingID = 1, GuestID = 1, RoomID = 1, CheckIn = new DateTime(2021, 4, 22), CheckOut = new DateTime(2021, 4, 23) }
        
               

                );

           
        }
    }


}

