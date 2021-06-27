using System.Globalization;

namespace exercicio10 {
    class Employee {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary) {
            ID = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage) {
            Salary += (Salary * percentage / 100);
        }

        public override string ToString() {
            return $"{ID}, " +
                $"{Name}, " +
                $"{Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
