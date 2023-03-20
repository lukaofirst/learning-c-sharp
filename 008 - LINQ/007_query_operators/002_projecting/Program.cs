/* --- Query Operators - Projecting --- */

using _002_projecting;

var companyList = new List<Company>()
{
	new Company(1, "Company1", 2018, new List<Employee> { new Employee(1, "Lorem", 2500), new Employee(2, "Bill", 2100)}),
	new Company(2, "Company2", 2017, new List<Employee> { new Employee(1, "John", 3000), new Employee(2, "Walter", 2600)}),
	new Company(3, "Company3", 2022, new List<Employee> { new Employee(1, "Ipsum", 2000), new Employee(2, "Washington", 1900)}),
	new Company(4, "Company4", 2023, new List<Employee> { new Employee(1, "Irvine", 4000), new Employee(2, "Bob", 3500)}),
};

/* - .Select() - */
// Returns an IEnumerable collection which contains elements
// based on a transformation function
var resultSelect = companyList.Select(x => x.Name);
resultSelect.ToList().ForEach(x => Console.WriteLine(x));
Console.WriteLine();

/* - .SelectMany() - */
// Extracts a sequence and then flattens the result into one sequence
var resultSelectMany = companyList.SelectMany(x => x.Employees);
resultSelectMany.ToList().ForEach(x => Console.WriteLine(x.Name));