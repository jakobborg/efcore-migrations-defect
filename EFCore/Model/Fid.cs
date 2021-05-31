namespace EFCore.Model
{
    public class Fid
    {
        public static readonly Fid Pre = new("pre");

        public static readonly Fid Post = new("post");

        private Fid(string value)
        {
            this.Value = value;
        }

        private Fid()
        {
        }

        public string Value { get; private set; }
    }
}
