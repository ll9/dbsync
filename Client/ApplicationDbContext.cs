using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Client
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<SyncPerson> SyncPerson { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("test.db");
        }
    }
}
