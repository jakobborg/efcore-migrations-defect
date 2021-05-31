namespace EFCore.Model
{
    public class PriceType
    {
        public static readonly PriceType Fixed = new("fixed");

        public static readonly PriceType Variable = new("variable");

        private PriceType(string value)
        {
            this.Value = value;
        }

        private PriceType()
        {
        }

        public string Value { get; private set; }
    }
}
