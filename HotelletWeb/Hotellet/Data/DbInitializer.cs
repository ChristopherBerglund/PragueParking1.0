using Hotellet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotellet.Data
{
    public class DbInitializer
    {
        public static void Initialize(HotelContext context)
        {
            context.Database.EnsureCreated();
            if (context.Movies.Any())
            {
                return;
            }

            var Mov = new Rooms[]
            {
                new Rooms {RoomNumber = 1, RoomPrice = 299, RoomCapacity = 1, RoomDescription = "Lovely room with sea-view", IsActive = false},

            };

            context.Movies.AddRange(Mov);
            context.SaveChanges();

            


        }
    }
}
