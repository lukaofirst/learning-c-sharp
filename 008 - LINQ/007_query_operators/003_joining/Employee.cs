namespace _003_joining
{
	public class Employee
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public int CompanyId { get; set; }

		public Employee(Guid id, string name, int companyId)
		{
			Id = id;
			Name = name;
			CompanyId = companyId;
		}
	}
}