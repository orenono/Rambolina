using Microsoft.EntityFrameworkCore;
using Rambolina.API.Models;

namespace Rambolina.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        
    }
}