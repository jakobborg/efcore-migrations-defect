using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Model
{
    public class Capacity
    {
        private Capacity(decimal value)
        {
            this.Value = value;
        }

        private Capacity()
        {
        }

        public enum Unit
        {
            W,
            KW,
            MW,
            GW,
        }

        public decimal Value { get; private set; }

        public static Capacity Create(decimal value, Unit unit)
        {
            return unit switch
            {
                Unit.W => new Capacity(value),
                Unit.KW => new Capacity(value * 1000),
                Unit.MW => new Capacity(value * 1000 * 1000),
                Unit.GW => new Capacity(value * 1000 * 1000 * 1000),
                _ => throw new ArgumentException("Unknown unit."),
            };
        }
    }
}
