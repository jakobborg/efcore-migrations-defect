using EFCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Persistence.Configuration
{
    public class PowerPurchaseAgreementMap : IEntityTypeConfiguration<PowerPurchaseAgreement>
    {
        public void Configure(EntityTypeBuilder<PowerPurchaseAgreement> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedNever()
                .IsRequired();

            builder.OwnsOne(x => x.Fid, fid =>
            {
                fid.Property(x => x.Value).HasMaxLength(8).HasColumnName("Fid");
            });
        }
    }
}
