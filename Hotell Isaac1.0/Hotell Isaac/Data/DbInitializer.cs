
using Hotell_Isaac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotell_Isaac.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Rooms.Any())
            {
                return;
            }

            var Mov = new Rooms[]
            {
                new Rooms { Name = "Rum 1", AntalRum = 1, PrisPerNatt = 200 },
                new Rooms { Name = "Rum 2", AntalRum = 1, PrisPerNatt = 200 },
                new Rooms { Name = "Rum 3", AntalRum = 1, PrisPerNatt = 200 },
                new Rooms { Name = "Rum 4", AntalRum = 1, PrisPerNatt = 200 },
                new Rooms { Name = "Rum 5", AntalRum = 1, PrisPerNatt = 200 },
                new Rooms { Name = "Rum 6", AntalRum = 2, PrisPerNatt = 350 },
                new Rooms { Name = "Rum 7", AntalRum = 2, PrisPerNatt = 350 },
                new Rooms { Name = "Rum 8", AntalRum = 2, PrisPerNatt = 350 },
                new Rooms { Name = "Rum 9", AntalRum = 2, PrisPerNatt = 350 },
                new Rooms { Name = "Rum 10", AntalRum = 2, PrisPerNatt = 350 },
            };

            context.Rooms.AddRange(Mov);
            context.SaveChanges();




        }

    }
}
