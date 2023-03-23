namespace _007_conversion_methods
{
	public class Person
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;

		public Person(int id, string name)
		{
			Id = id;
			Name = name;
		}
	}
}