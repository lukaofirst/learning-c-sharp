using structs;

/* --- Basic Types --- */

/* - structs - */
PersonStruct person1;
person1 = new("Lorem");

PersonStruct person2 = person1;
person2.Name = "Ipsum";

// Remember, struct is a value type
// so, the result here is going to be "Lorem"
Console.WriteLine(person1.ToString());

// if PersonStruct is declared as a class,
// the output, in this case is going to be "Ipsum"


