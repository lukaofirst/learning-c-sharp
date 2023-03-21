/* --- Query Operators - Joining --- */

using _003_joining;

var companyList = new List<Company>()
{
	new Company(1, "Company1"),
	new Company(2, "Company2"),
	new Company(3, "Company3"),
};

var employeeList = new List<Employee>()
{
	new Employee(Guid.NewGuid(), "Employee1", 1),
	new Employee(Guid.NewGuid(), "Employee2", 1),
	new Employee(Guid.NewGuid(), "Employee3", 2),
	new Employee(Guid.NewGuid(), "Employee4", 2),
	new Employee(Guid.NewGuid(), "Employee5", 3),
	new Employee(Guid.NewGuid(), "Employee6", 3),
};

/* --- .Join() --- */
var joinResult = employeeList.Join( // outer sequence
	companyList,                    // inner sequence
	x => x.CompanyId,               // outer key selector
	y => y.Id,                      // inner key selector
	(x, y) => new                   // result
	{
		EmployeeName = x.Name,
		CompanyName = y.Name
	});

joinResult.ToList().ForEach(x => Console.WriteLine($"{x.EmployeeName} | {x.CompanyName}"));

Console.WriteLine();

/* --- .GroupJoin() --- */
var groupByJoinResult = companyList.GroupJoin( // outer sequence
	employeeList,                              // inner sequence
	company => company.Id,                     // outer key selector
	employee => employee.CompanyId,            // inner key selector
	(company, employeeGroup) => new            // result
	{
		CompanyName = company.Name,
		EmployeeGroup = employeeGroup
	});

groupByJoinResult.ToList().ForEach(x =>
{
	Console.WriteLine(x.CompanyName);

	foreach (var item in x.EmployeeGroup)
	{
		Console.WriteLine($"  {item.Name}");
	}
});