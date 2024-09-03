using ApiFluentValidation.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiFluentValidation.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>option):base(option) {}

        public DbSet<User> Users { get; set; }
    }
}
