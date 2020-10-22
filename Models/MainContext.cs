using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Task6.Models
{
    public class MainContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }        
        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {            
            Database.EnsureCreated();
        }
    }
}
