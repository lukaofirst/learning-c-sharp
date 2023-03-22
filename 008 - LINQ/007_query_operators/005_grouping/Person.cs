namespace _005_grouping
{
	public class Person
	{
		public string Name { get; set; } = string.Empty;
		public string Gender { get; set; } = string.Empty;

		public Person(string name, string gender)
		{
			Name = name;
			Gender = gender;
		}
	}
}