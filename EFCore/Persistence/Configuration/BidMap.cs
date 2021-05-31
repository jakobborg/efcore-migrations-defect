using EFCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Persistence.Configuration
{
    public class BidMap : IEntityTypeConfiguration<Bid>
    {
        public void Configure(EntityTypeBuilder<Bid> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedNever()
                .IsRequired();

            builder.OwnsOne(x => x.ExpectedAllocation, allocation =>
            {
                allocation.OwnsOne(x => x.Capacity, confirmableValue =>
                {
                    confirmableValue.OwnsOne(x => x.Value, capacity =>
                    {
                        capacity.Property(x => x.Value);
                    });
                    confirmableValue.Property(x => x.Confirmed);
                });
            });

            builder.OwnsOne(x => x.ActualAllocation, allocation =>
            {
                allocation.OwnsOne(x => x.Capacity, confirmableValue =>
                {
                    confirmableValue.OwnsOne(x => x.Value, capacity =>
                    {
                        capacity.Property(x => x.Value);
                    });
                    confirmableValue.Property(x => x.Confirmed);
                });
            });
        }
    }
}
