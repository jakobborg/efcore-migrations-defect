using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Model
{
    public class Bid
    {
        public Guid Id { get; private set; } = Guid.NewGuid();

        public Allocation ExpectedAllocation { get; set; }

        public Allocation ActualAllocation { get; set; }
    }
}
