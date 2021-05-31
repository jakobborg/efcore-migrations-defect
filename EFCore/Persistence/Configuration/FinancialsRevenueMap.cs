using EFCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Persistence.Configuration
{
    public class FinancialsRevenueMap : IEntityTypeConfiguration<FinancialsRevenue>
    {
        public void Configure(EntityTypeBuilder<FinancialsRevenue> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedNever()
                .IsRequired();

            builder.HasMany(x => x.PowerPurchaseAgreements)
                .WithOne()
                .HasForeignKey(x => x.FinancialsRevenueId)
                .IsRequired();
        }
    }
}
