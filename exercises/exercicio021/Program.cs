using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using exercicio21.Entities;

namespace exercicio21 {
    class Program {
        static void Main(string[] args) {
            /* LINQ - Exercício de Fixação */
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: $");
            double compareSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while(!sr.EndOfStream) {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, email, salary));
                    }

                    Console.WriteLine();
                    Console.WriteLine($"Email of people whose salary is more then ${compareSalary}:");
                    var emails = list.Where(e => e.Salary > compareSalary).OrderBy(e => e.Email);
                    foreach(Employee email in emails) {
                        Console.WriteLine(email.Email);
                    }

                    Console.WriteLine();
                    var sumSalary = list.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
                    Console.Write($"Sum o salary of people whose name starts with 'M': ${sumSalary}");
                }
            } catch (IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
