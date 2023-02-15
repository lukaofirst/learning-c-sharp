/* --- Sealed Class and Methods --- */

using _010_sealed_class_and_methods.Entities;

var person1 = new Person(1, "Lorem", 25, "lorem@gmail.com");

Console.WriteLine($"{person1.Id} - {person1.Name} - {person1.Age} - {person1.Email}");

var employee1 = new Employee("Ipsum", "ipsum@gmail.com", "923409");

Console.WriteLine(employee1.ToString());