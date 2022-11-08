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
                new User { Name = "John", Email = "John@gmail.com", Phone = "+998912345678", Id = 1 },
                new User { Name = "Wade", Email = "Wade@gmail.com", Phone = "+998912345678", Id = 3 },
                new User { Name = "Alex", Email = "Alex@gmail.com", Phone = "+998912345678", Id = 2 },
                new User { Name = "Seth", Email = "Seth@gmail.com", Phone = "+998912345678", Id = 4 },
                new User { Name = "Ivan", Email = "Ivan@gmail.com", Phone = "+998912345678", Id = 5 },
                new User { Name = "Riley", Email = "Riley@gmail.com", Phone = "+998912345678", Id = 6 },
                new User { Name = "Gibert", Email = "Gibert@gmail.com", Phone = "+998912345678", Id = 7 },
                new User { Name = "Jorge", Email = "Jorge@gmail.com", Phone = "+998912345678", Id = 8 },
                new User { Name = "Jeff", Email = "Jeff@gmail.com", Phone = "+998912345678", Id = 9 },
                new User { Name = "Dan", Email = "Dan@gmail.com", Phone = "+998912345678", Id = 10 },
                new User { Name = "Brian", Email = "Brian@gmail.com", Phone = "+998912345678", Id = 11 },
                new User { Name = "Robert", Email = "Robert@gmail.com", Phone = "+998912345678", Id = 12 },
                new User { Name = "Miles", Email = "Miles@gmail.com", Phone = "+998912345678", Id = 13 },
                new User { Name = "Nathaniel", Email = "Nathaniel@gmail.com", Phone = "+998912345678", Id = 14 },
                new User { Name = "Ethan", Email = "Ethan@gmail.com", Phone = "+998912345678", Id = 15 },
                new User { Name = "Lewis", Email = "Lewis@gmail.com", Phone = "+998912345678", Id = 16 },
                new User { Name = "Milton", Email = "Milton@gmail.com", Phone = "+998912345678", Id = 17 },
                new User { Name = "Joshua", Email = "Joshua@gmail.com", Phone = "+998912345678", Id = 18 },
                new User { Name = "Glen", Email = "Glen@gmail.com", Phone = "+998912345678", Id = 19 },
                new User { Name = "Harvey", Email = "Harvey@gmail.com", Phone = "+998912345678", Id = 20 },
                new User { Name = "Blake", Email = "Blake@gmail.com", Phone = "+998912345678", Id = 21 },
                new User { Name = "Antonio", Email = "Antonio@gmail.com", Phone = "+998912345678", Id = 22 },
                new User { Name = "Connar", Email = "Connar@gmail.com", Phone = "+998912345678", Id = 23 },
                new User { Name = "Julian", Email = "Julian@gmail.com", Phone = "+998912345678", Id = 24 },
                new User { Name = "Aidan", Email = "Aidan@gmail.com", Phone = "+998912345678", Id = 25 },
                new User { Name = "Horald", Email = "Horald@gmail.com", Phone = "+998912345678", Id = 26 },
                new User { Name = "Conner", Email = "Conner@gmail.com", Phone = "+998912345678", Id = 27 },
                new User { Name = "Mac", Email = "Mac@gmail.com", Phone = "+998912345678", Id = 28 }
                );
        }
    }

        }