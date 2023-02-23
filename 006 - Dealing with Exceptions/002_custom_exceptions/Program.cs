/* --- Custom Exceptions --- */

// Custom exception should derive from Exception class
// instead of ApplicationException

var age = 16;
var adultAge = 21;

if (age < adultAge)
	throw new CustomException("Invalid Age! To be considered adult, age must be greater than 21");

public class CustomException : Exception
{
	public CustomException(string message) : base(message)
	{

	}
}