using EFCore.Model;
using EFCore.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Persistence
{
    public class DefaultContext : DbContext
    {
        public DbSet<Bid> Bid { get; set; }

        public DefaultContext(DbContextOptions<DefaultContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BidMap());
        }
    }
}
