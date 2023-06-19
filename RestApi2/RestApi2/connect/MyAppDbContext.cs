using Microsoft.EntityFrameworkCore;
using RestApi2.model;

namespace RestApi2.connect
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<kisi> Kisi { get; set; }
    }
}
