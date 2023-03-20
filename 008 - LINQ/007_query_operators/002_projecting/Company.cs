namespace _002_projecting
{
	public class Company
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int FoundedYear { get; set; }
		public List<Employee> Employees { get; set; }

		public Company(int id, string name, int foundedYear, List<Employee> employees)
		{
			Id = id;
			Name = name;
			FoundedYear = foundedYear;
			Employees = employees;
		}
	}
}