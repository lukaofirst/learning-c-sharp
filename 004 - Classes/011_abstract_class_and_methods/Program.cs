/* --- Abstract Classes and Methods --- */

using _011_abstract_class_and_methods.Entities;

// You cannot instantiate an abstract class
// var person = new Person();

var employee = new Employee(1, "Lorem", DateTime.Now, "Developer", 3000);

Console.WriteLine(employee.ToString());