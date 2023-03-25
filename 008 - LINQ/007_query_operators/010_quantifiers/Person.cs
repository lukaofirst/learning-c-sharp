namespace _010_quantifiers
{
	public class Person
	{
		public string Name { get; set; } = string.Empty;
		public int Age { get; set; }

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}
	}
}