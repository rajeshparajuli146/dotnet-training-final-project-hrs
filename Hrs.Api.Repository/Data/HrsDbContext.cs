using Hrs.Api.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hrs.Api.Repository.Data
{
    public class HrsDbContext : DbContext
    {
        public HrsDbContext(DbContextOptions<HrsDbContext> options)
            : base(options)
        {
        }
        public DbSet<Hotel> Hotels => Set<Hotel>();
        public DbSet<Room> Rooms => Set<Room>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Booking> Bookings => Set<Booking>();

    }
}
