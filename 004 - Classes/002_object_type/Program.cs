/* --- Object Type --- */

using _002_object_type.Entities;

object example = "hello world";
object num1 = 10;
object isOkay = false;
object product1 = new Product(1, "TV", 1400);
object product2 = new Product(2, "Smartphone", 1800);

Console.WriteLine(example);
Console.WriteLine(example.GetHashCode());
Console.WriteLine(example.GetType());
Console.WriteLine();

Console.WriteLine(num1);
Console.WriteLine(num1.GetHashCode());
Console.WriteLine(num1.GetType());
Console.WriteLine();

Console.WriteLine(isOkay.Equals(false));
Console.WriteLine();

Console.WriteLine(product1.ToString());
Console.WriteLine(product2.ToString());
Console.WriteLine();

Console.WriteLine(ReferenceEquals(product1, product1));
Console.WriteLine(ReferenceEquals(product1, product2));
