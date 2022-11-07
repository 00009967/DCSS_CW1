using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersApi.src.users.Models;

namespace UsersApi.src.Data
{
    public class UsersApiContext : DbContext
    {
        public UsersApiContext(DbContextOptions<UsersApiContext> options)
            : base(options)
        { }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            builder.Entity<User>().HasData(
                new User { Name = "John", Email = "john@gmail.com", Phone = "+998912345678", Id = 1 }
                );
        }
    }
}
