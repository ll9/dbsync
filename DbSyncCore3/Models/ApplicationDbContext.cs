using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbSyncCore3.Models
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Person> Person { get; set; }

        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }
    }
}
