using System;
using Insta.Models;
using Microsoft.EntityFrameworkCore;

namespace Insta.API.Data
{
    public class InstaContext : DbContext
    {
        public InstaContext(DbContextOptions<InstaContext> options) : base(options) { }

        public DbSet<Moment> Moment { get; set; }
        public DbSet<Comment> Comment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(InstaContext).Assembly);
        }
    }
}
