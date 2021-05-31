using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Model
{
    public class ConfirmableValue<T>
    {
        public ConfirmableValue(T value, bool confirmed)
        {
            this.Value = value ?? throw new ArgumentNullException(nameof(value));
            this.Confirmed = confirmed;
        }

        private ConfirmableValue()
        {
        }

        public T Value { get; set; }

        public bool Confirmed { get; set; }
    }
}
