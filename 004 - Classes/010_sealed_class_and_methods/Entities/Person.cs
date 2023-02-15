namespace _010_sealed_class_and_methods.Entities
{
    // You cannot inherit from this class
    public sealed class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Person(int id, string name, int age, string email)
        {
            Id = id;
            Name = name;
            Age = age;
            Email = email;
        }
    }
}
