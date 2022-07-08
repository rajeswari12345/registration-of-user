// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;
class PasswordValidator
{

	// A utility function to check
	// whether a password is valid or not
	public static bool isValid(String password)
	{

		// for checking if password length
		// is between 8 and 15
		if (!((password.Length >= 8)
			&& (password.Length <= 15)))
		{
			return false;
		}

		// to check space
		if (password.Contains(" "))
		{
			return false;
		}
		if (true)
		{
			int count = 0;

			// check digits from 0 to 9
			for (int i = 0; i <= 9; i++)
			{

				// to convert int to string
				String str1 = i.ToString();

				if (password.Contains(str1))
				{
					count = 1;
				}
			}
			if (count == 0)
			{
				return false;
			}
		}

		// for special characters
		if (!(password.Contains("@") || password.Contains("#")
			|| password.Contains("!") || password.Contains("~")
			|| password.Contains("$") || password.Contains("%")
			|| password.Contains("^") || password.Contains("&")
			|| password.Contains("*") || password.Contains("(")
			|| password.Contains(")") || password.Contains("-")
			|| password.Contains("+") || password.Contains("/")
			|| password.Contains(":") || password.Contains(".")
			|| password.Contains(", ") || password.Contains("<")
			|| password.Contains(">") || password.Contains("?")
			|| password.Contains("|")))
		{
			return false;
		}

		if (true)
		{
			int count = 0;

			// checking capital letters
			for (int i = 65; i <= 90; i++)
			{

				// type casting
				char c = (char)i;

				String str1 = c.ToString();
				if (password.Contains(str1))
				{
					count = 1;
				}
			}
			if (count == 0)
			{
				return false;
			}
		}

		if (true)
		{
			int count = 0;

			// checking small letters
			for (int i = 97; i <= 122; i++)
			{

				// type casting
				char c = (char)i;
				String str1 = c.ToString();

				if (password.Contains(str1))
				{
					count = 1;
				}
			}
			if (count == 0)
			{
				return false;
			}
		}

		// if all conditions fails
		return true;
	}

	// Driver code
	public static void Main(String[] args)
	{

		String password1 = "jammulaa";

		if (isValid(password1))
		{
			Console.WriteLine("Valid Password");
		}
		else
		{
			Console.WriteLine("Invalid Password!!!");
		}

		String password2 = "jammulaa";
		if (isValid(password2))
		{
			Console.WriteLine("Valid Password");
		}
		else
		{
			Console.WriteLine("Invalid Password!!!");
		}
	}
}