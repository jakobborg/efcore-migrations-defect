using EFCore.Model;
using EFCore.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Persistence
{
    public class DefaultContext : DbContext
    {
        public DbSet<FinancialsRevenue> FinancialsRevenue { get; set; }

        public DefaultContext(DbContextOptions<DefaultContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FinancialsRevenueMap());
            modelBuilder.ApplyConfiguration(new PowerPurchaseAgreementMap());
        }
    }
}
