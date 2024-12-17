using System;
using Microsoft.EntityFrameworkCore;
using AccountingSupportSystem.Entities;

namespace AccountingSupportSystem.EF
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
