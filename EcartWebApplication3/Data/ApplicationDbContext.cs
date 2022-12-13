using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using EcartWebApplication3.Models;

namespace EcartWebApplication3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }
        public DbSet<EcartWebApplication3.Models.Cart> Cart { get; set; }
        public DbSet<EcartWebApplication3.Models.Product> Product { get; set; }
    }
}
