using classes;

var person1 = new Person("Lorem", 25);

var person2 = person1;

person2.Name = "Ipsum";
person2.Age = 22;

Console.WriteLine(person1.Name);
Console.WriteLine(person1.Age);