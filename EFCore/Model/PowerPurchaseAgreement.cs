using System;

namespace EFCore.Model
{
    public class PowerPurchaseAgreement
    {
        public Guid Id { get; private set; } = Guid.NewGuid();

        public Guid FinancialsRevenueId { get; private set; }

        public Fid Fid { get; set; }

        public PriceType PriceType { get; set; }
    }
}
