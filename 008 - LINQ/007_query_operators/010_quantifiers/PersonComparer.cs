namespace _010_quantifiers
{
	public class PersonComparer : IEqualityComparer<Person>
	{
		public bool Equals(Person? x, Person? y)
		{
			if (x!.Name.ToLower() == y!.Name.ToLower() && x.Age == y.Age)
				return true;

			return false;
		}

		public int GetHashCode(Person obj)
		{
			return obj.GetHashCode();
		}
	}
}