// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;

public class MainClass
{
	public static void Main(string[] args)
	{
		Console.WriteLine(validateFirstName("Tom"));
		Console.WriteLine(validateLastName("Tom"));
	}
	// validate first name
	public static bool validateFirstName(string firstName)
	{
		return firstName.matches("[A-Z][a-zA-Z]*");
	} // end method validateFirstName

	// validate last name
	public static bool validateLastName(string lastName)
	{
		return lastName.matches("[a-zA-z]+([ '-][a-zA-Z]+)*");
	} // end method validateLastName

}
