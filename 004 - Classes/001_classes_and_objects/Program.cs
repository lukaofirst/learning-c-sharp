using _001_classes_and_objects.Entities;

/* --- Classes and Objects --- */

// Classes are blueprints for their instances

// person1 and person2 is an instance/object of Person's class
var person1 = new Person(1, "Lorem", 25);

// * Alternative syntax to initialize values
// use in case if you have a parameterless constructor
var person2 = new Person()
{
    Id = 2,
    Name = "Ipsum",
    Age = 22
};