using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Superhero.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Superhero.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Hero> Heroes { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        
    }
}
