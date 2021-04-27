using Bed20HotellIsaac.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bed20HotellIsaac.Data
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options)
           : base(options)
        {

        }

        public DbSet<Room> Rooms { get; set; }
    }
}
