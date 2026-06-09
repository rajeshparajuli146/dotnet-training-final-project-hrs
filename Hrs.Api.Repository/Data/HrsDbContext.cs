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
        //public DbSet<Author> Author { get; set; }
    }
}
