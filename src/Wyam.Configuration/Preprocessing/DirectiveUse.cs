namespace Wyam.Configuration.Preprocessing
{
    public class DirectiveUse
    {
        public int? Line { get; }
        public string Name { get; }
        public string Value { get; }

        public DirectiveUse(int line, string name, string value)
        {
            Line = line;
            Name = name;
            Value = value;
        }

        public DirectiveUse(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}