namespace _010_sealed_class_and_methods.Entities
{
    public class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Employee(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }

        // You cannot override this method on derived classes
        public sealed override string ToString()
        {
            return $"{Name} - {Email} - {Phone}";
        }
    }
}
