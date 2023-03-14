namespace _003_deferred_execution
{
	public static class EnumerableExtensionMethods
	{
		public static IEnumerable<Person> GetElegibleAdults(this IEnumerable<Person> persons)
		{
			foreach (var person in persons)
			{
				if (person.Age >= 18 && person.Age <= 65)
					yield return new Person { Name = person.Name, Age = person.Age };
			}
		}
	}
}