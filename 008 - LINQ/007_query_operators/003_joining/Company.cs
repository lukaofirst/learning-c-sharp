namespace _003_joining
{
	public class Company
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public Company(int id, string name)
		{
			Id = id;
			Name = name;
		}
	}
}