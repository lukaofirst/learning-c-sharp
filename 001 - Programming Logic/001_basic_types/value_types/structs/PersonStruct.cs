namespace structs
{
    public struct PersonStruct
    {
        public string Name { get; set; }

        public PersonStruct(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
