using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Hotell_Isaac.Models;

namespace Hotell_Isaac.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<Hotell_Isaac.Models.projectRoles> projectRoles { get; set; }
        public DbSet<Hotell_Isaac.Models.Book> Book { get; set; }
       
    }
}
