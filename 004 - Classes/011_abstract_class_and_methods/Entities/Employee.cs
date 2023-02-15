using System.Globalization;

namespace _011_abstract_class_and_methods.Entities
{
    public class Employee : Person
    {
        public string Role { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, DateTime createdAt, string role, double salary) 
            : base(id, name, createdAt)
        {
            Role = role;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Id: {Id} - Name: {Name} - Role: {Role}" +
                $" - Salary: ${Salary.ToString("F2", CultureInfo.InvariantCulture)} | CreatedAt: {CreatedAt}";
        }
    }
}
