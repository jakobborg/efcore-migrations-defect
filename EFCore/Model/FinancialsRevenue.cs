using System;
using System.Collections.Generic;

namespace EFCore.Model
{
    public class FinancialsRevenue
    {
        public Guid Id { get; private set; } = Guid.NewGuid();

        public List<PowerPurchaseAgreement> PowerPurchaseAgreements { get; set; } = new();
    }
}
