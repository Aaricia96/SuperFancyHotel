using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SuperFancyHotel.Models
{
    public class SuperFancyHotelContext : DbContext
    {
        public SuperFancyHotelContext (DbContextOptions<SuperFancyHotelContext> options)
            : base(options)
        {
        }

        public DbSet<SuperFancyHotel.Models.Room> Room { get; set; }
    }
}
